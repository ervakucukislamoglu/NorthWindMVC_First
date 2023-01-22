using Microsoft.AspNetCore.Mvc;
using NorthWindMVC_First.Context;
using NorthWindMVC_First.Models;
using System.Collections.Generic;
using System.Linq;

namespace NorthWindMVC_First.Controllers
{
    public class ProductController : Controller
    {
        public static List<Product> products = new List<Product>()
        {
            new Product {ID=1, ProductName="Çubuk kraker",CategoryName="Gıda", Supplier="Eti", UnitPrice=10, UnitsInstock=4875},
            new Product {ID=2, ProductName="Mont",CategoryName="Giyim", Supplier="Mavi", UnitPrice=500, UnitsInstock=625},
            new Product {ID=3, ProductName="Silgi",CategoryName="Kırtasiye", Supplier="Adel", UnitPrice=16, UnitsInstock=465},
            new Product {ID=4, ProductName="Laptop",CategoryName="Teknoloji", Supplier="Asus", UnitPrice=45621, UnitsInstock=3},
        };

        //private ProductContext context;
        //public ProductController()
        //{
        //    context = new ProductContext();
        //}

        //public ViewResult Index()
        //{
        //    return View(context.GetList());
        //}

        //public RedirectToRouteResult DeleteFromList(int ProductNumber)
        //{
        //    context.Delete(ProductNumber);
        //    return RedirectToAction("Index");
        //}
        public IActionResult Index()
        {
            ViewBag.Products = products;
            return View(products);
        }
        public IActionResult AddProduct()
        {
            ViewBag.Products = products;
            return View();
        }

        [HttpPost]
        public IActionResult AddProduct(Product model)
        {
            ViewBag.Products = products;
            products.Add(model);
            return View(products);
        }

        public ActionResult DeleteProduct(int ProductId)
        {
            ViewBag.Products = products;
            products.Remove(products.FirstOrDefault(x => x.ID == ProductId));
            return View("Index");
        }

    }
}
