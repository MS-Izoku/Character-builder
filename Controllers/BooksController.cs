using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using testMVC.Models;

namespace testMVC.Controllers
{
    public class BooksController : Controller
    {
        // private readonly ILogger<BooksController> _logger;

        // public ProjectsController(ILogger<BooksController> logger)
        // {
        //     _logger = logger;
        // }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Show(int index){
            return View();
        }

        public IActionResult New(){
            return View();
        }

        [HttpPost]
        public IActionResult Create(){
            return RedirectToAction("Show" , "BooksController");
        }

        public IActionResult Edit(){
            return View();
        }

        [HttpPatch]
        public IActionResult Update(){
            return RedirectToAction("Show" , "BooksController");
        }

        [HttpDelete]
        public IActionResult Delete(){
            return RedirectToAction("Show" , "BooksController");
        }
    }
}
