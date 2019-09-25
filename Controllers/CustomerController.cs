using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vlidly.Models;

namespace Vlidly.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {

            var customers = new List<Customer>
            {
                new Customer() {Name = "Omar Soto"},
                new Customer() {Name = "Magda Soto"}
            };

            return View(customers);
        }
    }
}