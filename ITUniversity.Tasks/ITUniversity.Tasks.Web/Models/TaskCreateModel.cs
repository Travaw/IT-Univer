using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using ITUniversity.Tasks.Enums;

namespace ITUniversity.Tasks.Web.Models
{
    public class TaskCreateModel
    {

        public static TaskCreateModel New
         {
            get { return new TaskCreateModel(); }
         }

        [Required(ErrorMessage ="Заполните обязательное поле")]
        [DisplayName("Тема")]
        public string Subject { get; set; }

        /// <summary>
        /// Описание
        /// </summary>
        [Required(ErrorMessage = "Заполните обязательное поле")]
        [DisplayName("Описание")]
        public string Description { get; set; }

        /// <summary>
        /// Дата создания
        /// </summary>
        public DateTime CreationDate { get; set; }

        public TasksStatus Status { get; set; }
    }
}
