using System.Collections.Generic;
using System.Linq;
using System.Reflection;

using ITUniversity.Tasks.Entities;
using ITUniversity.Tasks.Helpers;


namespace ITUniversity.Tasks.Stores
{
    public class TaskMemoryStore : ITaskStore
    {
        private List<TaskBase> tasks;

        private long counter=0;

        public TaskMemoryStore()
        {
            tasks = new List<TaskBase>();
        }

        public TaskBase Save(TaskBase task)
        {
            var saved = tasks.FirstOrDefault(item => item.Equal(task));
            if (saved != null)
            {
                return saved;
            }
            task.Id = counter++;
            tasks.Add(task);
            return task;
        }

        public TaskBase Get(long id)
        {
            var task= tasks.FirstOrDefault(item => item.Id==id);
            return task;
        }

        
        /// <inheritdoc/>
        public ICollection<TaskBase> GetAll()
        {
            return tasks.Select(task => task.Copy()).ToList();
        }
        public TaskBase Update(TaskBase entity)
        {
            var taskToUpdate = tasks.FirstOrDefault(item => item.Id == entity.Id);
            List<PropertyInfo> propertyInfos = new List<PropertyInfo>(typeof(TaskBase).GetProperties());
            foreach (var pi in propertyInfos)
            {
                object propertyValue = pi.GetValue(entity);
                pi.SetValue(taskToUpdate, propertyValue);
            }
            return taskToUpdate;
        }

        public void Delete(long id)
        {
            var taskToDelete = tasks.FirstOrDefault(item => item.Id == id);
            tasks.Remove(taskToDelete);
        }
    }
}
