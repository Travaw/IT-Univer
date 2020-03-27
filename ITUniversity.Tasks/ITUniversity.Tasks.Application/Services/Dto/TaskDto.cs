using System;
using System.Collections.Generic;
using System.Text;
using ITUniversity.Tasks.Enums;

namespace ITUniversity.Tasks.Application.Services.Dto
{
    public class TaskDto
    {
        public virtual long Id { get; set; }
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
        /// Автор
        /// </summary>
        public UserDto CreationAuthor
        {
            get;
            set;
        }

        /// <summary>
        /// Статус
        /// </summary>
        public TasksStatus Status
        {
            get;
            set;
        }

        /// <summary>
        /// Исполнитель
        /// </summary>
        public UserDto Executor
        {
            get;
            set;
        }
    }
}
