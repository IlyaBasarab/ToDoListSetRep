using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoListSet
{
    class TaskItem
    {
        public int id ;
        Task task = null;
        public int amount;

        public TaskItem(int ID, Task t, int a)
        {
            this.id = ID;
            this.task = t;
            this.amount = a;
        }

        public string GetDescription()
        {
            return task.Description;
        }
        public void SetDescription(string desc)
        {
            task.Description = desc;
        }

        public string GetTaskName()
        {
            return task.Name;
        }
        public override string ToString()
        {
            return "Id: "+id + '\n' + " task name: " + task.Name + '\n'+ "Task status: " + task.Status + '\n' + "  Amount: "+amount +'\n' ;
        }
    }
}
