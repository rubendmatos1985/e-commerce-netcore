using Microsoft.AspNetCore.Mvc;
using SportsStore.Models;
using SportsStore.Models.ViewModels;
using System;
using System.Linq;

namespace SportsStore.Controllers
{
  public class ProductController : Controller
  {
    private IProductRepository repository;
    public int PageSize { get; set; } = 4;

    public ProductController(IProductRepository repo)
    {

      repository = repo; 
    }
    [HttpGet]
    public ViewResult List(string category, int productPage = 1)
    {
      return View(new ProductListViewModel
      {
        Products = repository.Products
             .Where(p => category == null || p.Category == category)
             .OrderBy(p => p.ProductID)
             .Skip((productPage - 1) * PageSize)
             .Take(PageSize),
        PagingInfo = new PagingInfo
        {
          CurrentPage = productPage,
          ItemsPerPage = PageSize,
          TotalItems = string.IsNullOrEmpty(category)
                 ? repository.Products.Count()
                 : repository.Products.Where(e => e.Category == category).Count()
        },
        CurrentCategory = category

      });

    }

  }

}
