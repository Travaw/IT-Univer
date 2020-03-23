using System;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using ITUniversity.Tasks.Web.Models;
using ITUniversity.Tasks.Stores;

namespace ITUniversity.Tasks.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> logger;

        private readonly ITaskStore taskStore;

        public HomeController(ILogger<HomeController> logger, ITaskStore taskStore)
        {
            this.logger = logger;
            this.taskStore = taskStore;
        }

        public IActionResult Index()
        {
           // var a = taskStore.Save(new Entities.TaskBase { Subject = "Hello", Description= "Hello"});
            //var b = taskStore.Save(new Entities.TaskBase { Subject = "Hello World", Description = "Hello World" });
            
            return View();
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
    }
}
