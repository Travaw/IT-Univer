﻿using System;
using System.Collections.Generic;

using ITUniversity.Tasks.Entities;
using ITUniversity.Tasks.Stores;

namespace ITUniversity.Tasks.Managers
{
    ///<inheritdoc/>
    public class TaskManager:ITaskManager
    {

        private readonly ITaskStore taskStore;

        public TaskManager(ITaskStore taskStore)
        {
            this.taskStore = taskStore;
        }
        ///<inheritdoc/>
        public TaskBase Create(TaskBase task) 
        {
            task.CreationDate = DateTime.Now;
            task.Status = Enums.TasksStatus.ToDo;
            return taskStore.Save(task);
        }

        ///<inheritdoc/>
        public TaskBase Create(string subject)
        {            
            return new TaskBase();
        }

        /// <inheritdoc/>
        public TaskBase Get(long id)
        {
            return taskStore.Get(id);
        }

        /// <inheritdoc/>
        public ICollection<TaskBase> GetAll()
        {
            return taskStore.GetAll();
        }

        /// <inheritdoc/>
        public TaskBase Update(TaskBase task)
        {
            return taskStore.Update(task);
        }

        /// <inheritdoc/>
        public void Delete(long id)
        {
            taskStore.Delete(id);
        }
    }
}
