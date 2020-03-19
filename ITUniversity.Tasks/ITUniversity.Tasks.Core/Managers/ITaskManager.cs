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
        /// Поиск задачи
        /// </summary>
        /// <returns></returns>
        TaskBase Get(long id);

        /// <summary>
        /// Вернуть все задачи
        /// </summary>
        /// <returns></returns>
        ICollection<TaskBase> GetAll();

        /// <summary>
        /// Изменение задачи
        /// </summary>
        /// <returns></returns>
        TaskBase Update(TaskBase task);

        /// <summary>
        /// Удаление задачи
        /// </summary>
        /// <returns></returns>
        void Delete(long id);
    }
}
