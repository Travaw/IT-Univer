using System;
using System.Collections.Generic;
using System.Text;

namespace ITUniversity.Tasks.Application.Services.Dto
{
    public class UpdateUserDto
    {/// <summary>
     /// Идентификатор
     /// </summary>
        public int Id
        {
            get;
            set;
        }

       

        /// <summary>
        /// Почта
        /// </summary>
        public string Email
        {
            get;
            set;
        }


        /// <summary>
        /// Роль
        /// </summary>
        public int? RoleId
        {
            get;
            set;
        }
    }
}

