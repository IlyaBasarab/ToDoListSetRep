using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoListSet
{
     class TaskNameCompare : IComparer<TaskItem>
        {
            public int Compare(TaskItem t1, TaskItem t2)
            {
                return t1.task.Name.CompareTo(t2.task.Name);
            }
        }
    }

