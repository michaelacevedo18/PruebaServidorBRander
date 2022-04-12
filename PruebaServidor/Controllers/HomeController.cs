using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PruebaServidor.Data;
using PruebaServidor.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaServidor.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;
        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var resultados= _context.InteresteDatas.ToList();
            return View(resultados);
        }

        public IActionResult Privacy()
        {
            return View();
        }

    }
}
