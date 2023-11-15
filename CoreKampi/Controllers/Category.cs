using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreKampi.Controllers
{
    public class Category : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
