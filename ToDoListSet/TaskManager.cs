using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoListSet
{
    class TaskManager
    {
        private List <TaskItem> tasks = new List <TaskItem> ();

        SortedSet<TaskItem> sorted = new SortedSet<TaskItem> (new TaskNameCompare());

        int indx = 0;


        public void CreateTask(string name, string description)
        {
            TaskItem taskItem = new TaskItem(indx, new Task(true, name, description), 1);
            bool result = sorted.Add(taskItem);

            if (result)
            {
                tasks.Add(taskItem);
                indx++;
                Console.WriteLine("Task " + name + " created");
            }
            else
            {

                int idx = 0;
                TaskItem item = null;

                for (int i = 0; i < tasks.Count; i++)
                {
                    item = tasks[i];
                    if (item.GetTaskName().Equals(name))
                    {
                        idx = i;
                        break;
                    }
                }

                item.amount += 1;
                tasks[idx] = item;
                Console.WriteLine("Task already exist: " + item.GetTaskName() + " new amount  " + item.amount);
                    
            }

        }

        public void ShowTasks()
        {

            foreach(TaskItem item in tasks)
            {
                Console.WriteLine(item.ToString());

            }

        }

        public void UpdateTask(int id)
        {
            Console.WriteLine("Enter new description:");
            string newDescr = Console.ReadLine();

            tasks[id].SetDescription(newDescr);


        }

        public void DeleteTask(int id)
        {
            tasks.RemoveAt(id);
            Console.WriteLine(id+" removed.");
        }

        public void ShowUnique()
        {


            foreach(TaskItem item in tasks)
            {
                sorted.Add(item);
            }
            foreach(TaskItem item in sorted)
            {
                Console.WriteLine( item.ToString());
            }
        }

        public void ShowSortRepeated()
        {
            foreach(TaskItem item in tasks)
            {
                if (item.amount > 1)
                    Console.WriteLine(item.ToString());
            }

        }

        public void ShowSortNeverRepeated()
        {

            ////    ¯\_(ツ)_/¯

        }



    }
}
