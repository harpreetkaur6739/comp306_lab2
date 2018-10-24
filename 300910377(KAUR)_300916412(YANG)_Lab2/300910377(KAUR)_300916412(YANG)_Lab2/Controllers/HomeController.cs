using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using _300910377_KAUR__300916412_YANG__Lab2.Models;
using Microsoft.EntityFrameworkCore;

namespace _300910377_KAUR__300916412_YANG__Lab2.Controllers
{
    public class HomeController : Controller
    {
        private readonly _300910377_KAUR__300916412_YANG__Lab2Context _context;

        public HomeController(_300910377_KAUR__300916412_YANG__Lab2Context context)
        {
            _context = context;
        }

        public async Task<IActionResult> Home()
        {
            return View(await _context.Movie.ToListAsync());
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
