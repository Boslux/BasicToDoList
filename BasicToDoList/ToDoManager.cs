using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicToDoList
{
    internal class ToDoManager
    {
        List<string> taskList = new List<string>();
        string choice = "";
        string answer;        
        public void Process()
        {
            
            while (choice != "4") { 
                Console.WriteLine("**************************");
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("press '1' for add new task");
                Console.WriteLine("press '2' for delete task");
                Console.WriteLine("press '3' for view list");
                Console.WriteLine("press '4' for Exit");
                Console.WriteLine("**************************");
                choice = Console.ReadLine();
                if (choice == "1")
                {
                    Console.WriteLine("Text your task");
                    answer = Console.ReadLine();
                    taskList.Add(answer);
                }
                else if (choice == "2")
                {
                    if (taskList.Count != 0)
                    {
                        Console.WriteLine("Which task do you want to delete?");
                        Console.WriteLine("Task List:");
                        for (int i = 0; i < taskList.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}. {taskList[i]}");

                        }
                        int delete = Convert.ToInt32(Console.ReadLine());
                        taskList.RemoveAt(delete - 1);
                    }
                    else
                        Console.WriteLine("First you need do add a task");

                }
                else if (choice == "3")
                {
                    if (taskList.Count !=0)
                    {
                        Console.WriteLine("Task List:");
                        for (int i = 0; i < taskList.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}. {taskList[i]}");
                        }
                    }
                    else
                        Console.WriteLine("First you need do add a task ");
                }
                else
                {
                    Console.WriteLine("Please enter valid number");
                }
            }
        }
    }
}
