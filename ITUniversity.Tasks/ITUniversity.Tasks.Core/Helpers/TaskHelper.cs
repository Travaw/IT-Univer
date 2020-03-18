using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

using ITUniversity.Tasks.Entities;

namespace ITUniversity.Tasks.Helpers
{
    public static class TaskHelper
    {
        public static bool Equal(this TaskBase taskBase1, TaskBase taskBase2)
        {
            List<PropertyInfo> propertyInfos = new List<PropertyInfo>(typeof(TaskBase).GetProperties());
            propertyInfos.Remove(propertyInfos.FirstOrDefault(item=>item.Name=="Id"));
            foreach(var pi in propertyInfos)
            {
                object property1 = pi.GetValue(taskBase1);
                object property2 = pi.GetValue(taskBase2);
                if(property1.GetType().BaseType==typeof(ValueType)|| property1.GetType().BaseType == typeof(Enum))
                {
                    if (property1.ToString() != property2.ToString())
                    {
                        return false;
                    }
                }
                else
                {
                    if (property1 != property2)
                    {
                        return false;
                    }
                }
                
            }
            return true;
        }
        public static TaskBase Copy(this TaskBase entity)
        {
            var copy = new TaskBase();
            List<PropertyInfo> propertyInfos = new List<PropertyInfo>(typeof(TaskBase).GetProperties());
            foreach (var pi in propertyInfos)
            {
                object propertyValue = pi.GetValue(entity);
                pi.SetValue(copy, propertyValue);
            }
            return copy;
        }
    }

    
}
