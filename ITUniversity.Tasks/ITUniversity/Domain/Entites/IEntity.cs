using System;
using System.Collections.Generic;
using System.Text;

namespace ITUniversity.Domain.Entities
{
    /// <summary>
    /// Сущность, с первичным ключем с типа <see cref="int"/>
    /// </summary>
    public interface IEntity : IEntity<int>
    {

    }
}
