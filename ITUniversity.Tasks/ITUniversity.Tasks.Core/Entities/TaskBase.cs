﻿using System;
using ITUniversity.Domain.Entities;
using ITUniversity.Tasks.Enums;

namespace ITUniversity.Tasks.Entities
{
    /// <summary>
    /// Базовый класс задач
    /// </summary>
    public class TaskBase : Entity<long>
    {
        /// <summary>
        /// Имя таблицы
        /// </summary>
        public const string TableName = "Tasks";

        /// <summary>
        /// Тема
        /// </summary>
        public virtual string Subject { get; set; }

        /// <summary>
        /// Описание
        /// </summary>
        public virtual string Description { get; set; }

        /// <summary>
        /// Дата создания
        /// </summary>
        public virtual DateTime CreationDate { get; set; }

        /// <summary>
        /// Статус
        /// </summary>
        public virtual TasksStatus Status { get; set; }

        /// <summary>
        /// Создатель задачи
        /// </summary>
        public virtual User CreationAuthor { get; set; }

        /// <summary>
        /// Исполнтель
        /// </summary>
        public virtual User Executor { get; set; }
    }
}
