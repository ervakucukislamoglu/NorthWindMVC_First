using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using NorthWindMVC_First.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NorthWindMVC_First.Controllers
{
    public class OrderController : Controller
    {
        public static List<Order> orders = new List<Order>()
        {
            new Order {ID=1, Date=DateTime.Now,Address="China", ShippingFee=23},
            new Order {ID=2, Date=DateTime.Now,Address="Canada", ShippingFee=456},
            new Order {ID=3, Date=DateTime.Now,Address="Iceland", ShippingFee=46},
            new Order {ID=4, Date=DateTime.Now,Address="Denmark", ShippingFee=7856},
        };
        public IActionResult Index()
        {
            ViewBag.Orders = orders;
            return View(orders);
        }

        public IActionResult AddOrder()
        {
            ViewBag.Orders = orders;
            return View();
        }

        [HttpPost]
        public IActionResult AddOrder(Order model)
        {
            ViewBag.Orders = orders;
            orders.Add(model);
            return View(orders);
        }

        public ActionResult DeleteOrder(int OrderId)
        {
            ViewBag.Orders = orders;
            orders.Remove(orders.FirstOrDefault(x => x.ID == OrderId));
            return View("Index");
        }
    }
}
