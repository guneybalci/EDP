using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDP.TestWeb.Controllers
{
    public class HataController : Controller
    {
        public string Index(string HataMesaji)
        {
            return HataMesaji;
        }

        public string ValidationHandler(List<string> HataMesaji)
        {
            string message = string.Empty;
            foreach (var item in HataMesaji)
            {
                message += item + "<br/>";
            }

            return message;
        }
    }
}
