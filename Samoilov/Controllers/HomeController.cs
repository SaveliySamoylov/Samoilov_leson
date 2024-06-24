﻿using Samoilov.Models;
using Microsoft.AspNetCore.Mvc;
using Samoilov.Models;
using System.Diagnostics;

namespace Di_25.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
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

        public String index(int a)
        {
            var answer = "";
            for (int i = 0; i < ProductList.products.Count; i++)
            {
                answer += ProductList.products[i].Id;
                answer += "\n";
                answer += ProductList.products[i].Name;
                answer += "\n";
                answer += ProductList.products[i].Price;
                answer += "\n";
                answer += ProductList.products[i].Description;
                answer += "\n";
                answer += "\n";
            }
            return answer;
        }
    }
}
//https://localhost:7124/Home/Index