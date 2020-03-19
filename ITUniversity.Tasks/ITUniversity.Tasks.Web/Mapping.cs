using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ITUniversity.Tasks.Entities;
using ITUniversity.Tasks.Web.Models;

namespace ITUniversity.Tasks.Web
{
    public class Mapping:Profile
    {
       public Mapping()
       {
            CreateMap<TaskCreateModel, TaskBase>();
            CreateMap<TaskBase, TaskEditModel>();
        }
    }
}
