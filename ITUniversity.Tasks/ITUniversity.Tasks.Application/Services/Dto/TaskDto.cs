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
        /// Статус
        /// </summary>
        public virtual TasksStatus Status { get; set; }
    }
}
