using EDP.ExceptionHandling;
using EDP.TestWeb.Models;
using EDP.TestWeb.Validators;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace EDP.TestWeb.Controllers
{
    public class HomeController : BaseController
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
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

        public string AddCategory()
        {

            CategoryModel model = new CategoryModel();
            model.CategoryID = 0;
            model.CategoryName = "";
            model.Description = "Deneme deneme";

            CategoryValidator validator = new CategoryValidator(model);
            if (!validator.IsValid)
            {
                throw new ModelNotValidException(validator.ValidationMessages);
            }

            return "Kayıt eklendi";

        }
    }
}
