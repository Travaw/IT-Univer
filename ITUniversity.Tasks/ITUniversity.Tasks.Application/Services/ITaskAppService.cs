using ITUniversity.Application.Services;
using ITUniversity.Tasks.Application.Services.Dto;

namespace ITUniversity.Tasks.Application.Services
{
    public interface ITaskAppService : IApplicationService
    {
        TaskDto Add(TaskCreateDto task);

        TaskDto Update(TaskUpdateDto task);

        void Delete(long id);

        TaskDto Get(long id);
    }

}