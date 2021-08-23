using Microsoft.AspNetCore.Mvc;
using MVCExample.Models;
using MVCExample.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCExample.Controllers
{
    public class CalculatorController : Controller
    {
        private CalculatorService _calculatorService;
        public CalculatorController(CalculatorService calculatorService)
        {
            _calculatorService = calculatorService;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Results(string num1, string num2, char operation)
        {
            var result = _calculatorService.GetCalculation(num1, num2, operation);
            ViewBag.Message = result;
            return View("Result");
        }

    }
}
