using EDP.ExceptionHandling;
using EDP.TestWeb.Models;
using EDP.TestWeb.Validators;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDP.TestWeb.Controllers
{
    public class CategoryController : BaseController
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(CategoryModel model)
        {

            CategoryValidator validator = new CategoryValidator(model);
            if (!validator.IsValid)
            {
                throw new ModelNotValidException(validator.ValidationMessages);
            }

            return View(model);
        }
    }
}
