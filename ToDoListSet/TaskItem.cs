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
        public Task task = null;
        public int amount;

        public TaskItem(int ID, Task t, int a)
        {
            this.id = ID;
            this.task = t;
            this.amount = a;
        }
        
        public override string ToString()
        {
            return "Id: "+id + '\n' + " task name: " + task.Name + '\n'+ "Task status: " + task.Status + '\n' + "  Amount: "+amount +'\n' ;
        }
    }
}
