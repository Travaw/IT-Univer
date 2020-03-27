using System;
using System.Collections.Generic;
using System.Text;
using ITUniversity.Application.Services;
using ITUniversity.Tasks.Application.Services.Dto;

namespace ITUniversity.Tasks.Application.Services
{
    public interface IRoleAppService: IApplicationService
    {
        ICollection<RoleDto> GetAll();
    }
}
