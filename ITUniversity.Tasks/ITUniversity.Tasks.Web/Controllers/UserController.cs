
using AutoMapper;

using ITUniversity.Tasks.Application.Services;
using ITUniversity.Tasks.Web.Models;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ITUniversity.Tasks.Web.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserAppService userAppService;
        private readonly IMapper mapper;

        public UserController(IUserAppService userAppService, IMapper mapper)
        {
            this.userAppService = userAppService;
            this.mapper = mapper;
        }

        [Authorize(Roles ="admin")]
        public IActionResult Index()
        {
            var users = userAppService.GetAll();
            return View(users);
        }

        public IActionResult Edit(int id)
        {
            var userDto = userAppService.Get(id);
            var model = mapper.Map<UserEditModel>(userDto);
            model.RoleId = userDto.Role?.Id;
            return View(model);
        }
    }
}