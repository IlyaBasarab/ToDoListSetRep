using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoListSet
{
    internal class Task
    {
        private bool status;
        private string name;
        private string description;


        public Task (bool s,string n , string descr)
        {
            status = s;
            name = n;
            description = descr;

        }

        public bool Status { get => status; set => status = value; }
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }


        
    }
}
