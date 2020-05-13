using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FlatFiguresFields.Models;
using FlatFiguresFields.ViewModels;
using System.Text.RegularExpressions;
using FlatFiguresFields.Services;

namespace FlatFiguresFields.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IFigureAreaCalculator _calculator;
        public HomeController(ILogger<HomeController> logger, IFigureAreaCalculator calculator)
        {
            _logger = logger;
            _calculator = calculator;
        }



        public IActionResult Privacy()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Figure figure)
        {
            return View(figure);
        }
        public IActionResult Calculate(Figure figure)
        {
            return View("Index", _calculator.CalculateArea(figure));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
