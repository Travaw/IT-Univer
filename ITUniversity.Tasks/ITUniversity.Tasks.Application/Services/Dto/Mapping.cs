using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using ITUniversity.Tasks.Entities;

namespace ITUniversity.Tasks.Application.Services.Dto
{
    class Mapping : Profile
    {
        public Mapping()
        {
            CreateMap<TaskBase, TaskDto>();
            CreateMap<CreateTaskDto, TaskBase>().ForMember(dest => dest.Executor, opt => opt.Ignore());
            CreateMap<UpdateTaskDto, TaskBase>();
            CreateMap<CreateUserDto, User>();
            CreateMap<User, UserDto>();
            CreateMap<Role, RoleDto>();
        }
    }
}
