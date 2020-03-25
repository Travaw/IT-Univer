using System;
using System.Collections.Generic;
using System.Text;

namespace ITUniversity.Domain.Entities
{
    /// <summary>
    /// Сущность
    /// </summary>
    /// <typeparam name="TPrimaryKey">Тип первичного ключа</typeparam>
    public interface IEntity<TPrimaryKey>
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        TPrimaryKey Id { get; set; }
    }
}
