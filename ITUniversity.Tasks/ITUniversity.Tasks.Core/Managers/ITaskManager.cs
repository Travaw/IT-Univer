using System.Collections.Generic;

using ITUniversity.Tasks.Entities;

namespace ITUniversity.Tasks.Managers
{
    /// <summary>
    /// Менеджер сущностей <see cref="TaskBase">
    /// </summary>
    public interface ITaskManager
    {
        /// <summary>
        /// Создание задачи
        /// </summary>
        /// <param name="task"></param>
        /// <returns></returns>
        TaskBase Create(TaskBase task);

        /// <summary>
        /// Создание задачи
        /// </summary>
        /// <param name="subject"></param>
        /// <returns></returns>
        TaskBase Create(string subject);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        ICollection<TaskBase> GetAll();
    }
}
