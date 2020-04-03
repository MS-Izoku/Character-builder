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
    public class DocumentsController : Controller
    {
        // private readonly ILogger<DocumentsController> _logger;

        // public ProjectsController(ILogger<DocumentsController> logger)
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
            return View();
        }

        public IActionResult Edit(){
            return View();
        }

        [HttpPatch]
        public IActionResult Update(){
            return View();
        }

        [HttpDelete]
        public IActionResult Delete(){
            return View();
        }
    }
}
