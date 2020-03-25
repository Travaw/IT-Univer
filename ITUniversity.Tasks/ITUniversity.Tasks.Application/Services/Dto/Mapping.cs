using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using ITUniversity.Tasks.Entities;

namespace ITUniversity.Tasks.Application.Services.Dto
{
    class Mapping:Profile
    {
        public Mapping()
        {
            CreateMap<TaskBase, TaskDto>();
            CreateMap<TaskCreateDto, TaskBase>();
            CreateMap<TaskUpdateDto, TaskBase>();
        }
    }
}
