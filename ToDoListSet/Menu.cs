using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoListSet
{
    class Menu
    {

        public void Start()
        {
            TaskManager manager =  new TaskManager();



            bool work = true;

            while(work)
            {
                Console.WriteLine("Choose function: \n"
                + "1.Create new task\n"
                + "2.Get tasklist \n"
                + "3.Update task \n"
                + "4.Delete task \n"
                + "5.Get unique task \n"
                + "6.Show repeated tasks \n"
                + "7.Show never repeated tasks \n"
                + "8.Exit program \n");

                switch(Convert.ToInt32(Console.ReadLine()))
                {


                    case 1:
                        Console.WriteLine("Enter name: ");
                        string name = Console.ReadLine();
                        Console.WriteLine("Enter description: ");
                        string descr = Console.ReadLine();
                        manager.CreateTask(name, descr);
                        Console.WriteLine(" ");
                        break;


                    case 2:
                        manager.ShowTasks();
                        Console.WriteLine(" ");
                        break;

                    case 3:

                        Console.WriteLine("Enter ID to update:");
                        manager.UpdateTask(Convert.ToInt32(Console.ReadLine()));
                        Console.WriteLine("Task updated \n");

                        break;

                    case 4:
                        Console.WriteLine("Enter ID to delete:");
                        manager.UpdateTask(Convert.ToInt32(Console.ReadLine()));
                        Console.WriteLine("Task updated \n");
                        break;

                    case 5:

                        manager.ShowUnique();
                        break;

                    case 6:
                        manager.ShowSortRepeated();
                        break;


                    case 7:
                        manager.ShowSortNeverRepeated();
                        break;




                    case 8:

                        work = false;

                        break;

                    default:
                        break;

                }

                    



            }



        }


    }
}
