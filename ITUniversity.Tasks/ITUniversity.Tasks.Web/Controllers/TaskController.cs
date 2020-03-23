using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ITUniversity.Tasks.Entities;
using ITUniversity.Tasks.Managers;
using ITUniversity.Tasks.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace ITUniversity.Tasks.Web.Controllers
{
    public class TaskController : Controller
    {
        private readonly ITaskManager taskManager;

        private readonly IMapper mapper;

        public TaskController(ITaskManager taskManager, IMapper mapper)
        {
            this.taskManager = taskManager;
            this.mapper = mapper;
        }

        public IActionResult Index()
        {
            var tasks = taskManager.GetAll();
            return View(tasks);
        }

        public IActionResult Create()
        {

            return View(TaskCreateModel.New);
        }

        [HttpPost]
        public IActionResult Create(TaskCreateModel task)
        {
            if (!ModelState.IsValid)
            {
                return View(task);
            }
            else
            {
                var entity = mapper.Map<TaskBase>(task);
                taskManager.Create(entity);
                return RedirectToAction("Index");
            } 
        }

        [HttpPost]
        public IActionResult Delete(long id)
        {
            taskManager.Delete(id);
            return Json(new { success = true });
        }

        [HttpGet]
        public IActionResult Details(long id)
        {
            var task = taskManager.Get(id);
            return View(task);
        }

        [HttpGet]
        public IActionResult Edit(long id)
        {
            var task = mapper.Map<TaskEditModel>(taskManager.Get(id));
            return View(task);
        }

        [HttpPost]
        public IActionResult Edit(TaskEditModel task)
        {
            var entity = taskManager.Get(task.Id);
            entity.Description = task.Description;
            taskManager.Update(entity);
            return RedirectToAction("Index");
        }
    }
}