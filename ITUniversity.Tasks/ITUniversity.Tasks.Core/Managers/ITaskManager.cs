﻿using System.Collections.Generic;

using ITUniversity.Tasks.Entities;

namespace ITUniversity.Tasks.Managers
{
    /// <summary>
    /// Менеджер сущностей <see cref="TaskBase">
    /// </summary>
    /// <summary>
    /// Менеджер сущности <see cref="TaskBase"/>
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
        /// 
        /// </summary>
        /// <param name="subject"></param>
        /// <returns></returns>
        TaskBase Create(string subject);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        TaskBase Get(long id);

        /// <summary>
        /// Получить все
        /// </summary>
        /// <returns></returns>
        ICollection<TaskBase> GetAll();

        /// <summary>
        /// Получить входящие задачи
        /// </summary>
        /// <param name="user">Пользователь</param>
        ICollection<TaskBase> GetIncoming(User user);

        /// <summary>
        /// Получить исходящие задачи
        /// </summary>
        /// <param name="user">Пользователь</param>
        ICollection<TaskBase> GetOutgoing(User user);

        /// <summary>
        /// Обновить
        /// </summary>
        /// <param name="task">Задача</param>
        TaskBase Update(TaskBase task);

        /// <summary>
        /// Удалить
        /// </summary>
        /// <param name="id">Идентификатор</param>
        void Delete(long id);
    }
}
