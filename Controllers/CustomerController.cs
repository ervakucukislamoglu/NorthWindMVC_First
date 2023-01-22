using Microsoft.AspNetCore.Mvc;
using NorthWindMVC_First.Models;
using System.Collections.Generic;
using System.Linq;

namespace NorthWindMVC_First.Controllers
{
    public class CustomerController : Controller
    {
        List<Customer> customers = new List<Customer>()
        {
            new Customer(){ID=1,CompanyName="Soundgarden", ContactNumber="55555555", Address = "İstanbul"},
            new Customer(){ID=2,CompanyName="AC/DC", ContactNumber="567785654", Address = "New York"},
            new Customer(){ID=3,CompanyName="Thunder", ContactNumber="58956247856", Address = "London"},
            new Customer(){ID=4,CompanyName="Phenomena", ContactNumber="4589656", Address = "Morocco"}
        };
        public IActionResult Index()
        {
            ViewBag.Customers = customers;
            return View();
        }

        public IActionResult AddCustomer()
        {
            ViewBag.Customers = customers;
            return View();
        }

        [HttpPost]
        public IActionResult AddCustomer(Customer model)
        {
            ViewBag.Customers = customers;
            customers.Add(model);
            return View(customers);
        }

        public ActionResult DeleteCustomer(int CustomerId)
        {
            ViewBag.Customers = customers;
            customers.Remove(customers.FirstOrDefault(x => x.ID == CustomerId));
            return View("Index");
        }
    }
}
