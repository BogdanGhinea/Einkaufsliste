using Einkaufsliste.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Einkaufsliste.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult ArtikelForm()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ArtikelForm(Position position)
        {
            if (ModelState.IsValid)
            {
                Repository.AddPosition(position);
                return View("ArticleNumber", Repository.Positions.Count());
            }
            else
            {
                return View();
            }

        }
        public IActionResult Angelegt()
        {
            return View(Repository.Positions);
        }
       
       
    }

}