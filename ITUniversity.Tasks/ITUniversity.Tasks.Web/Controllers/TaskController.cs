using AutoMapper;

using ITUniversity.Tasks.Application.Services;
using ITUniversity.Tasks.Web.Models;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ITUniversity.Tasks.Web.Controllers
{
    /// <summary>
    /// Контроллер для работы с задачами
    /// </summary>
    [Authorize(Roles = "admin, user")]
    public class TaskController : Controller
    {
        private readonly ITaskAppService taskAppService;

        private readonly IMapper mapper;

        /// <summary>
        /// Инициализировать экземпляр <see cref="TaskController"/>
        /// </summary>
        /// <param name="taskAppService">Сервис для работы с задачами</param>
        /// <param name="mapper">Маппер</param>
        public TaskController(ITaskAppService taskAppService, IMapper mapper)
        {
            this.taskAppService = taskAppService;
            this.mapper = mapper;
        }

        /// <summary>
        /// Получить страницу со списком задач
        /// </summary>
        [HttpGet]
        public IActionResult Index()
        {
            var dtos = taskAppService.GetAll();
            return View(dtos);
        }

        /// <summary>
        /// Получить страницу добавления задачи
        /// </summary>
        [HttpGet]
        public IActionResult Add()
        {
            return View(TaskCreateModel.New);
        }

        /// <summary>
        /// Удалить задачу
        /// </summary>
        /// <param name="id">Идентификатор задачи</param>
        [HttpPost]
        public IActionResult Delete(long id)
        {
            taskAppService.Delete(id);

            return Json(new { success = true });
        }

        /// <summary>
        /// Получить страницу с описанием задачи
        /// </summary>
        /// <param name="id">Идентификатор задачи</param>
        [HttpGet]
        public IActionResult Details(long id)
        {
            var dto = taskAppService.Get(id);

            return View(dto);
        }

        /// <summary>
        /// Получить стрицу редактирования задачи
        /// </summary>
        /// <param name="id">Идентификатор задачи</param>
        [HttpGet]
        public IActionResult Edit(long id)
        {
            var dto = taskAppService.Get(id);
            var model = mapper.Map<TaskEditModel>(dto);

            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(TaskEditModel task)
        {
            //var entity = mapper.Map<TaskBase>(task);
            //taskAppService.Update(entity);

            return RedirectToAction("Index");
        }
    }
    /*
    public class TaskController : Controller
    {
        private readonly ITaskManager taskManager;

        private readonly IMapper mapper;

        public TaskController(ITaskManager taskManager, IMapper mapper)
        {
            this.taskManager = taskManager;
            this.mapper = mapper;
        }

        [Authorize(Roles = "admin, user")]
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
    }*/
}