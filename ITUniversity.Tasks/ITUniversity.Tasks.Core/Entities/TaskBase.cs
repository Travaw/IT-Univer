using System;

using ITUniversity.Tasks.Enums;

namespace ITUniversity.Tasks.Entities
{
    ///<summary>
    ///Базовый класс задач
    ///</summary>
    public class TaskBase
    {        
        /// <summary>
        /// Идентификатор
        /// </summary>
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
        public virtual DateTime CreationDate{ get; set; }

        public virtual TasksStatus Status { get; set; } 

    }
}
