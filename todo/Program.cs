using System;
using System.Collections.Generic;

namespace ToDoListApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> tasks = new List<string>();
            bool running = true;

            while (running)
            {
                Console.Clear();
                Console.WriteLine("====== TO-DO LIST APP ======");
                Console.WriteLine("1. View Tasks");
                Console.WriteLine("2. Add Task");
                Console.WriteLine("3. Delete Task");
                Console.WriteLine("4. Mark Task as Done");
                Console.WriteLine("5. Exit");
                Console.Write("Choose an option: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1": // View Tasks
                        Console.Clear();
                        if (tasks.Count == 0)
                        {
                            Console.WriteLine("No tasks available.");
                        }
                        else
                        {
                            Console.WriteLine("Your Tasks:");
                            for (int i = 0; i < tasks.Count; i++)
                            {
                                Console.WriteLine($"{i + 1}. {tasks[i]}");
                            }
                        }
                        Console.ReadKey();
                        break;

                    case "2": // Add Task
                        Console.Write("Enter a new task: ");
                        string newTask = Console.ReadLine();
                        tasks.Add(newTask);
                        Console.WriteLine("Task added successfully!");
                        Console.ReadKey();
                        break;

                    case "3": // Delete Task
                        Console.Write("Enter task number to delete: ");
                        int delIndex;
                        if (int.TryParse(Console.ReadLine(), out delIndex) && delIndex > 0 && delIndex <= tasks.Count)
                        {
                            tasks.RemoveAt(delIndex - 1);
                            Console.WriteLine("Task deleted successfully!");
                        }
                        else
                        {
                            Console.WriteLine("Invalid task number.");
                        }
                        Console.ReadKey();
                        break;

                    case "4": // Mark Task as Done
                        Console.Write("Enter task number to mark as done: ");
                        int doneIndex;
                        if (int.TryParse(Console.ReadLine(), out doneIndex) && doneIndex > 0 && doneIndex <= tasks.Count)
                        {
                            tasks[doneIndex - 1] += " (Done)";
                            Console.WriteLine("Task marked as done!");
                        }
                        else
                        {
                            Console.WriteLine("Invalid task number.");
                        }
                        Console.ReadKey();
                        break;

                    case "5": // Exit
                        running = false;
                        break;

                    default:
                        Console.WriteLine("Invalid choice, try again.");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}
