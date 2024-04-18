using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicToDoList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ToDoManager toDoManager = new ToDoManager();
            toDoManager.Process();
        }
    }

}
