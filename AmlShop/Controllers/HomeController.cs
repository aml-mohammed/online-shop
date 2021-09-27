using AmlShop.Models;
using AmlShop.Models.Home;
using AmlShop.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace AmlShop.Controllers
{
    public class HomeController : Controller
    {

        public GenericUnitOfWork<Product> _product;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, GenericUnitOfWork<Product> product)
        {
            _logger = logger;
            _product = product;
        }

        public IActionResult Index()
        {
           var HomeIndexViewModel  = new HomeIndexViewModel
            {
                ListOfProducts = _product.GetRepositoryInstance.GetAllRecords()
            };
            return View(HomeIndexViewModel);
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
