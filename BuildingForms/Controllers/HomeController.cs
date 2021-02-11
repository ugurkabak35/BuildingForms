using BuildingForms.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuildingForms.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(string Name, string Description, decimal Price, bool isApproved)
        {
            //Gelen bilgilerle kayı işlemi
            return View();
        }

        [HttpGet]
        public IActionResult Search(string q)
        {
            // gelen q değeri ile arama işlemi yapıldı
            return View();
        }
    }
}
