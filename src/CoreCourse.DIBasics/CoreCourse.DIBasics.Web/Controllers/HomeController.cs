using CoreCourse.DIBasics.Core.CoffeeSystem;
using CoreCourse.DIBasics.Web.CoffeeWeb;
using CoreCourse.DIBasics.Web.Models;
using CoreCourse.DIBasics.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CoreCourse.DIBasics.Web.Controllers
{
    public class HomeController : Controller
    {

        private ICoffeeCup _coffeeCup;
        public HomeController(ICoffeeCup coffeeCup)
        {
            _coffeeCup = coffeeCup;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Coffee()
        {
            var viewModel = new CoffeeViewModel();
            ICreamer creamer = new Milk();
            ISweetener sugar = new Sugar();
            viewModel.CoffeeCup = new CoffeeCup(creamer, sugar);

            return View(viewModel);

        }


        public IActionResult CoffeeDI()
        {
            var viewModel = new CoffeeViewModel();
            viewModel.CoffeeCup = _coffeeCup;

            return View(viewModel);

        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
