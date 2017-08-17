using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RP.GOF.ChainOfResposibility.Core.Validators.HotelBooking;
using RP.GOF.ChainOfResposibility.Models;

namespace RP.GOF.ChainOfResposibility.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var errorsResult = HotelBookingValidationContext.Validate(new HotelBooking());
            if (errorsResult.Any())
            {
               // handle validation
            }
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
