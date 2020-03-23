using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

using ITUniversity.Tasks.Entities;

namespace ITUniversity.Tasks.Web.Models
{
    public class TaskEditModel
    {
        
        public TaskEditModel()
        {

        }
        
        public long Id { get; set; }

        

        /// <summary>
        /// Описание
        /// </summary>
        [Required(ErrorMessage = "Заполните обязательное поле")]
        [DisplayName("Описание")]
        public string Description { get; set; }
    }
}
