using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ITUniversity.Tasks.Entities;
using ITUniversity.Tasks.Managers;
using Microsoft.AspNetCore.Mvc;

namespace ITUniversity.Tasks.Web.Controllers
{
    public class TaskController : Controller
    {
        private readonly ITaskManager taskManager;

        public TaskController(ITaskManager taskManager)
        {
            this.taskManager = taskManager;
        }

        public IActionResult Index()
        {
            var tasks = taskManager.GetAll();
            return View(tasks);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(TaskBase taskBase)
        {
            if (taskBase.Subject != null && taskBase.Description != null)
            {
                taskManager.Create(taskBase);
                return RedirectToAction("Index");
            }
            else return View();
        }
    }
}