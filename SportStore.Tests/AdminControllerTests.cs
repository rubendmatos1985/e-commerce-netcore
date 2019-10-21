﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Moq;
using SportsStore.Controllers;
using SportsStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace SportStore.Tests
{
  public class AdminControllerTests
  {
    private T GetViewModel<T>(IActionResult result) where T : class
    {
      return (result as ViewResult)?.ViewData.Model as T;
    }

    [Fact]
    public void Index_Contains_All_Products()
    {
      // Arrange - create the mock repository

      Mock<IProductRepository> mock = new Mock<IProductRepository>();

      mock.Setup(m => m.Products).Returns(new Product[]
      {
        new Product{ProductID= 1, Name="P1"},
        new Product{ProductID= 2, Name="P2"},
        new Product{ProductID= 3, Name="P3"}
      }.AsQueryable<Product>());

      // Arrange - create controller
      AdminController target = new AdminController(mock.Object);

      // Action 
      Product[] result = GetViewModel<IEnumerable<Product>>(target.Index())?.ToArray();

      // Assert
      Assert.Equal(3, result.Length);
      Assert.Equal("P1", result[0].Name);
      Assert.Equal("P2", result[1].Name);
      Assert.Equal("P3", result[2].Name);

    }

    [Fact]
    public void Can_Edit_Product()
    {
      // Arrange - create mock repository
      Mock<IProductRepository> mock = new Mock<IProductRepository>();
      mock.Setup(p => p.Products).Returns(new Product[]
      {
        new Product{ProductID=1, Name="P1"},
        new Product{ProductID=1, Name="P2"},
        new Product{ProductID=1, Name="P3"},
      }.AsQueryable<Product>());

      // Arrange - create the controller
      AdminController target = new AdminController(mock.Object);

      //Act
      Product p1 = GetViewModel<Product>(target.Edit(1));
      Product p2 = GetViewModel<Product>(target.Edit(2));
      Product p3 = GetViewModel<Product>(target.Edit(3));

      // Assert
      Assert.Equal(1, p1.ProductID);
      Assert.Equal(2, p2.ProductID);
      Assert.Equal(3, p3.ProductID);
    }

    [Fact]
    public void Cannot_Edit_Nonexistent_Product()
    {
      // Arrange - create the mock repository
      var mock = new Mock<IProductRepository>();
      mock.Setup(m => m.Products).Returns(new Product[]
      {
        new Product{ ProductID=1, Name="P1" },
        new Product{ ProductID=2, Name="P2" },
        new Product{ ProductID=3, Name="P3" }
      }.AsQueryable());

      // Arrange - cretate controller
      var target = new AdminController(mock.Object);

      // Act
      Product result = GetViewModel<Product>(target.Edit(4));

      // Assert
      Assert.Null(result);

    }

    [Fact]
    public void Can_Save_Valid_Changes()
    {
      // Arrange - create mock repository
      var mock = new Mock<IProductRepository>();

      // Arrange - create mock temp data
      var tempData = new Mock<ITempDataDictionary>();

      // create the controller
      var target = new AdminController(mock.Object)
      {
        TempData = tempData.Object
      };

      // Arrange - create product
      var product = new Product { Name = "Test" };

      // Action - try to save the product
      IActionResult result = target.Edit(product);

      // Assert - check that the repository was called
      mock.Verify(m => m.SaveProduct(product));

      // Assert - check the result type is a redirection
      Assert.IsType<RedirectToActionResult>(result);
      Assert.Equal("Index", (result as RedirectToActionResult).ActionName);
    }

    [Fact]
    public void Cannot_Save_Invalid_Changes()
    {
      // Arrange - create mock repository
      var mock = new Mock<IProductRepository>();

      // Arrange - create controller
      var target = new AdminController(mock.Object);

      // Arrange - create product
      Product product = new Product { Name = "Test" };

      // Act - Add error to model state
      target.ModelState.AddModelError("Error", "error");

      // Act - try to edit product
      target.Edit(product);

      // Assert - check the repository was not called
      mock.Verify(m => m.SaveProduct(It.IsAny<Product>()), Times.Never);
    }

    [Fact]
    public void Can_Delete_Valid_Products()
    {
      // Arrange - create Product
      Product prod = new Product { ProductID = 2, Name = "Test" };

      // Arrange - create mock repository
      Mock<IProductRepository> mock = new Mock<IProductRepository>();
      mock.Setup(m => m.Products).Returns(new Product[]{
        new Product{ ProductID = 1, Name="P1" },
        prod,
        new Product{ ProductID = 3, Name="P3" },
        
      }.AsQueryable());

      // Arrange - create the controller
      AdminController target = new AdminController(mock.Object);

      // Act - delete product
      target.Delete(prod.ProductID);

      // Assert - ensure repository delete method was called with correct Product
      mock.Verify(repo => repo.DeleteProduct(prod.ProductID));
    }

  }
}
