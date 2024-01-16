using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Manager
{
    internal class TaskManager
    {
        // Properties
        private List<Task> Tasks = new List<Task>();

        // Methods: AddTask, ListTasks, MarkTaskAsComplete, DeleteTask, FilterTasks, etc.

        //Constructor
        public TaskManager() { }

        //Method to Add Task
        public void AddTask()
        {
            Console.WriteLine("Add Task");
            Console.WriteLine("Enter the title of the task: ");
            string title = Console.ReadLine();
            Console.WriteLine("Enter the description of the task: ");
            string description = Console.ReadLine();
            Console.WriteLine("Enter the due date of the task: ");
            DateTime dueDate = DateTime.Parse(Console.ReadLine());
            Task task = new Task(title, description, dueDate);
            Tasks.Add(task);
            Console.WriteLine("Task added successfully!");
        }

        //Method to List Tasks
        public void ListTasks()
        {
            Console.WriteLine("List Tasks");
            if (Tasks.Count == 0)
            {
                Console.WriteLine("No tasks to display!");
            }
            else
            {
                foreach (Task task in Tasks)
                {
                    Console.WriteLine(task);
                }
            }
        }

        //Method to Mark Task as Complete
        public void MarkTaskAsComplete()
        {
            Console.WriteLine("Mark Task as Complete");
            Console.WriteLine("Enter the title of the task to mark as complete: ");
            string title = Console.ReadLine();
            Task task = Tasks.Find(t => t.Title == title);
            if (task == null)
            {
                Console.WriteLine("Task not found!");
            }
            else
            {
                task.IsCompleted = true;
                Console.WriteLine("Task marked as complete successfully!");
            }
        }

        //Method to Delete Task
        public void DeleteTask()
        {
            Console.WriteLine("Delete Task");
            Console.WriteLine("Enter the title of the task to delete: ");
            string title = Console.ReadLine();
            Task task = Tasks.Find(t => t.Title == title);
            if (task == null)
            {
                Console.WriteLine("Task not found!");
            }
            else
            {
                Tasks.Remove(task);
                Console.WriteLine("Task deleted successfully!");
            }
        }

        //Method to Filter Tasks
        public void FilterTasks()
        {
            Console.WriteLine("Filter Tasks");
            Console.WriteLine("1. Filter by Due Date");
            Console.WriteLine("2. Filter by Status");
            Console.WriteLine("Enter your choice: ");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    FilterByDueDate();
                    break;
                case "2":
                    FilterByStatus();
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }

        //Method to Filter by Due Date
        public void FilterByDueDate()
        {
            Console.WriteLine("Filter by Due Date");
            Console.WriteLine("Enter the due date to filter tasks: ");
            DateTime dueDate = DateTime.Parse(Console.ReadLine());
            List<Task> filteredTasks = Tasks.FindAll(t => t.DueDate == dueDate);
            if (filteredTasks.Count == 0)
            {
                Console.WriteLine("No tasks found!");
            }
            else
            {
                foreach (Task task in filteredTasks)
                {
                    Console.WriteLine(task);
                }
            }
        }

        //Method to Filter by Status
        public void FilterByStatus()
        {
            Console.WriteLine("Filter by Status");
            Console.WriteLine("Enter the status to filter tasks: ");
            bool isCompleted = bool.Parse(Console.ReadLine());
            List<Task> filteredTasks = Tasks.FindAll(t => t.IsCompleted == isCompleted);
            if (filteredTasks.Count == 0)
            {
                Console.WriteLine("No tasks found!");
            }
            else
            {
                foreach (Task task in filteredTasks)
                {
                    Console.WriteLine(task);
                }
            }
        }


    }
}
