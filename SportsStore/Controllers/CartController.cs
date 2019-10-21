using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SportsStore.Infrastructure;
using SportsStore.Models;
using SportsStore.Models.ViewModels;

namespace SportsStore.Controllers
{
  public class CartController : Controller
  {
    readonly IProductRepository repository;
    
    private Cart cart;

    public IActionResult Index(string returnUrl) => View(new CartIndexViewModel { Cart = cart, ReturnUrl = returnUrl });

    public CartController(Cart cartService, IProductRepository repo )
    {
      repository = repo;
      cart = cartService;
    }

    public RedirectToActionResult AddToCart(int productId, string returnUrl)
    {
      Product product = repository.Products.FirstOrDefault(p => p.ProductID == productId);

      if (product != null)
      {
        cart.AddItem(product, 1);

      }
      return RedirectToAction("Index", new { returnUrl });
    }

    public RedirectToActionResult RemoveFromCart(int productId, string returnUrl)
    {
      Product product = repository.Products.FirstOrDefault(p => p.ProductID == productId);
      if (product != null)
      {
        cart.RemoveLine(product);
      }
      return RedirectToAction("Index", new { returnUrl });
    }
  }
}