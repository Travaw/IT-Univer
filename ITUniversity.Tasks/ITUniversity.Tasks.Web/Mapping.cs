using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ITUniversity.Tasks.Application.Services.Dto;
using ITUniversity.Tasks.Entities;
using ITUniversity.Tasks.Web.Models;
using ITUniversity.Tasks.Web.Models.Account;

namespace ITUniversity.Tasks.Web
{
    public class Mapping:Profile
    {
       public Mapping()
       {
            CreateMap<TaskCreateModel, TaskBase>();
            CreateMap<TaskBase, TaskEditModel>();
            CreateMap<TaskCreateModel, TaskBase>();
            CreateMap<TaskBase, TaskEditModel>();
            CreateMap<TaskEditModel, TaskBase>();
            CreateMap<RegisterModel, CreateUserDto>();
        }
    }
}
