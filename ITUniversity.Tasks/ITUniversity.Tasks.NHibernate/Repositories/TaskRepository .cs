using System.Collections.Generic;
using System.Linq;
using ITUniversity.Tasks.Entities;
using ITUniversity.Tasks.Repositories;

using NHibernate;

namespace ITUniversity.Tasks.NHibernate.Repositories
{
    /*
    public class TaskRepository : ITaskRepository
    {
        private readonly ISession session;

        public TaskRepository(ISession session)
        {
            this.session = session;
        }

       public TaskBase Save(TaskBase task)
        {
            session.Save(task);
            session.Flush();
            return task;
        }

        public IQueryable<TaskBase> GetAll()
        {
            return session.Query<TaskBase>();
        }

        public ICollection<TaskBase> GetAllList()
        {
            return this.GetAll().ToList();
        }

        public void Delete(long id)
        {
            var entity = GetAll().FirstOrDefault(item => item.Id == id);
            session.Delete(entity);
            session.Flush();
        }

        public TaskBase Get(long id)
        {
            return GetAll().FirstOrDefault(item => item.Id == id);
        }

        public TaskBase Update(TaskBase task)
        {
            session.Update(task);
            session.Flush();
            return task;
        }
    }*/

    /// <summary>
    /// Репозиторий сущности <see cref="TaskBase"/>
    /// </summary>
    public class TaskRepository : NhRepositoryBase<TaskBase, long>, ITaskRepository
    {
        /// <summary>
        /// Инициализировать экземпляр <see cref="TaskRepository"/>
        /// </summary>
        /// <param name="session">Сессия NHibernate</param>
        public TaskRepository(ISession session)
            : base(session)
        {

        }
    }
}