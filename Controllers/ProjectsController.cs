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
    public class ProjectsController : Controller
    {
        private readonly ILogger<ProjectsController> _logger;

        public ProjectsController(ILogger<ProjectsController> logger)
        {
            _logger = logger;
        }

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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
