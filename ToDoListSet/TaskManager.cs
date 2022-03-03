using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoListSet
{
    class TaskManager
    {
        private List <TaskItem> activeTasks = new List <TaskItem> ();
        private List<TaskItem> doneTasks = new List<TaskItem>();
        SortedSet<TaskItem> sorted = new SortedSet<TaskItem> (new TaskNameCompare());

        int indx = 0;


        public void CreateTask(string name, string description)
        {
            TaskItem taskItem = new TaskItem(indx, new Task(true, name, description), 1);
            bool result = sorted.Add(taskItem);

            if (result)
            {
                activeTasks.Add(taskItem);
                indx++;
                Console.WriteLine("Task " + name + " created");
            }
            else
            {

                int idx = 0;
                TaskItem item = null;

                for (int i = 0; i < activeTasks.Count; i++)
                {
                    item = activeTasks[i];
                    if (item.task.Name.Equals(name))
                    {
                        idx = i;
                        break;
                    }
                }

                item.amount += 1;
                activeTasks[idx] = item;
                Console.WriteLine("Task already exist: " + item.task.Name + " new amount  " + item.amount);
                    
            }

        }

        public void ShowTasks()
        {

            foreach(TaskItem item in activeTasks)
            {
                Console.WriteLine(item.ToString());

            }

        }

        public void UpdateTask(int id)
        {
            Console.WriteLine("\nWhich parametr to change:\n"
                +"1.description\n"
                +"2.status");
            int var = Convert.ToInt32( Console.ReadLine());

            switch(var)
            {

                case 1:
                    Console.WriteLine("Enter new description:");
                    string newDescr = Console.ReadLine();

                    activeTasks[id].task.Description = newDescr;
                    Console.WriteLine("Description changed.");
                    break;


                case 2:
                    activeTasks[id].task.Status = false;
                    doneTasks.Add(activeTasks[id]);
                    DeleteTask(id);
                    Console.WriteLine("Task completed.\n");
                    break;
                default:
                    break;
                    
            }



        }

        public void DeleteTask(int id)
        {
            activeTasks.RemoveAt(id);
            Console.WriteLine("Task removed from active.");
        }

        public void ShowUnique()
        {


            foreach(TaskItem item in activeTasks)
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
            foreach(TaskItem item in activeTasks)
            {
                if (item.amount > 1)
                    Console.WriteLine(item.ToString());
            }

        }

        public void ShowSortNeverRepeated()
        {

            SortedSet<TaskItem> sort = new SortedSet<TaskItem>(new TaskNameCompare());
            foreach (TaskItem item in activeTasks)
            {
                sort.Add(item);
            }

            foreach (TaskItem item in doneTasks)
            {
                sort.Add(item);
            }

            foreach(TaskItem item in sort)
            { Console.WriteLine(item.ToString()); }    
        }



    }
}
