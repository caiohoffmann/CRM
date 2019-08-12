using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRM.Controllers
{
    public class HomeController :  Controller
    {
        [Route("/")]
        public ActionResult Index()
        {
            return View();
        }
    }
}
