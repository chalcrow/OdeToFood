using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OdeToFood.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OdeToFood.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            // return Content("Hello from homecontroller");
            var model = new Restaurant { Id = 1, Name = "TestRestaurant" };
            //return new ObjectResult(model);
            return View("Home", model);
        }
    }
}
