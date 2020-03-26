﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ITUniversity.Tasks.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace ITUniversity.Tasks.Web.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserAppService userAppService;

        public UserController(IUserAppService userAppService)
        {
            this.userAppService = userAppService;
        }
        public IActionResult Index()
        {
            var users = userAppService.GetAll();
            return View(users);
        }
    }
}