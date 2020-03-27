using System;
using System.Collections.Generic;
using System.Text;

namespace ITUniversity.Tasks.Application.Services.Dto
{
    public class CreateTaskDto
    {
        /// <summary>
        /// Тема
        /// </summary>
        public virtual string Subject { get; set; }

        /// <summary>
        /// Описание
        /// </summary>
        public virtual string Description { get; set; }

    }
}
