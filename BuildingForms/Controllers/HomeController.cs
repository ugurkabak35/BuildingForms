using BuildingForms.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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
            return View(ProductRepository.Products);
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Categories = new SelectList(new List<string>() { "Telefon","Tablet","Laptop"});

            return View();
        }

        [HttpPost]
        public IActionResult Create(Product model)
        {
            //Gelen bilgilerle kayıt işlemi
            //Validation
            ProductRepository.AddProduct(model);
            return RedirectToAction("Index");
        }

        //Home/Search?q=word
        [HttpGet]
        public IActionResult Search(string q)
        {
            if (string.IsNullOrWhiteSpace(q))
                return View();

            // gelen q değeri ile arama işlemi yapıldı
            return View("Index",ProductRepository.Products.Where(i=>i.Name.Contains(q)));
        }
    }
}
