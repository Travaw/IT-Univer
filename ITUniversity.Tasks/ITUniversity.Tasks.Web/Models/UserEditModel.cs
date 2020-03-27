using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using ITUniversity.Tasks.Application.Services.Dto;

namespace ITUniversity.Tasks.Web.Models
{
    public class UserEditModel
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public int Id
        {
            get;
            set;
        }

        /// <summary>
        /// Логин
        /// </summary>
        public string Login
        {
            get;
            set;
        }

        /// <summary>
        /// Почта
        /// </summary>
        [DisplayName("Электронная почта")]
        public string Email
        {
            get;
            set;
        }

        public bool IsBlocked
        {
            get;
            set;
        }

        /// <summary>
        /// Роль
        /// </summary>
        [DisplayName("Роль")]
        public int? RoleId
        {
            get;
            set;
        }
    }
}
