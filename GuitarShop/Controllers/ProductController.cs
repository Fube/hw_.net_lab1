using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using GuitarShop.Models;

namespace GuitarShop.Controllers
{
    public class ProductController : Controller
    {
        // Retrieve one product by id and return it to the view
        // Binds to /Product/Detail/{id}
        public IActionResult Detail(string id)
        {
            Product product = DB.GetProduct(id);
            return View(product);
        }

        // Retrieve all products and return them to the view
        // Binds to /Product/List
        public IActionResult List()
        {
            List<Product> products = DB.GetProducts();
            return View(products);
        }
    }
}