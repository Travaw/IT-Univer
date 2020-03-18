using System.Collections.Generic;
using ITUniversity.Tasks.Entities;

namespace ITUniversity.Tasks.Stores
{
    /// <summary>
    /// 
    /// </summary>
    public interface ITaskStore
    {   
        /// <summary>
        /// Create
        /// </summary>
        /// <param name="task"></param>
        /// <returns></returns>
        TaskBase Save(TaskBase task);

        /// <summary>
        /// Read
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        TaskBase Get(long id);

        /// <summary>
        /// Получить все
        /// </summary>
        ICollection<TaskBase> GetAll();

        /// <summary>
        /// Update
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        TaskBase Update(TaskBase entity);

        /// <summary>
        /// Delete
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        void Delete(long id);
        //TODO допилить CRUD (Get, Delete, Update), Equals для Save через расширения по всем свойствам (Get, Delete по id, Equals по всем свойствам,  в Update передавать Task)
    }
}
