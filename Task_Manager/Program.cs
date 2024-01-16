namespace Task_Manager
{
    internal class Program
    {
        static void Main(string[] args)
        {
           //object of TaskManager class
            TaskManager taskManager = new TaskManager();

            while (true)
            {
                Console.WriteLine("Welcome to the Task Manager App!");
                Console.WriteLine("1. Add Task");
                Console.WriteLine("2. List Tasks");
                Console.WriteLine("3. Mark Task as Complete");
                Console.WriteLine("4. Delete Task");
                Console.WriteLine("5. Filter Tasks");
                Console.WriteLine("6. Exit");

                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                //switch case for the choice
                switch (choice)
                {
                    case "1":
                        taskManager.AddTask();
                        break;
                    case "2":
                        taskManager.ListTasks();
                        break;
                    case "3":
                        taskManager.MarkTaskAsComplete();
                        break;
                    case "4":
                        taskManager.DeleteTask();
                        break;
                    case "5":
                        taskManager.FilterTasks();
                        break;
                    case "6":
                        Console.WriteLine("Thank you for using the Task Manager App!");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
}
