using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FlexiBackEnd.Controllers
{
    public class MyRequestForReviewController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}