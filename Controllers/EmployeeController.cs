using Microsoft.AspNetCore.Mvc;
using NorthWindMVC_First.Models;
using System.Collections.Generic;
using System.Linq;

namespace NorthWindMVC_First.Controllers
{
    public class EmployeeController : Controller
    {
        public static List<Employee> employees = new List<Employee>()
        {
            new Employee {ID=1, FirstName="Erva",LastName="Küçükislamoğlu", Speciality="Developer"},
            new Employee {ID=2, FirstName="Eylül",LastName="Küçükislamoğlu", Speciality="Stajyer"},
            new Employee {ID=3, FirstName="Merve",LastName="Ballıkaya", Speciality="Agile Koç"},
            new Employee {ID=4, FirstName="İlker",LastName="Ballıkaya", Speciality="CTO"},
        };
        public IActionResult Index()
        {
            ViewBag.Employees = employees;
            return View(employees);
        }
        public IActionResult AddEmployee()
        {
            ViewBag.Employees = employees;
            return View();
        }

        [HttpPost]
        public IActionResult AddEmployee(Employee model)
        {
            ViewBag.Employees = employees;
            employees.Add(model);
            return View(employees);
        }
        public ActionResult DeleteEmployee(int EmployeeId)
        {
            ViewBag.Employees = employees;
            employees.Remove(employees.FirstOrDefault(x => x.ID == EmployeeId));
            return View("Index");
        }
    }
}
