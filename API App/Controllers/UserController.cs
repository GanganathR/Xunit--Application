using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_App.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Sample()
        {
            // add comment 123
            return View();
        }

        public IActionResult SampleChange()
        {
            // add comment
            int i = 0;

            return null;
        }

    }
}
