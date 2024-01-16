using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Manager
{
    internal class Task
    {
        // Properties: Title, Description, DueDate, IsCompleted.
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public bool IsCompleted { get; set; }
        
        // Constructor
        public Task(string title, string description, DateTime dueDate)
        {
            Title = title;
            Description = description;
            DueDate = dueDate;
            IsCompleted = false;
        }

        // Methods: ToString(), etc.
        public override string ToString()
        {
            return $"Title: {Title}\nDescription: {Description}\nDue Date: {DueDate}\nIs Completed: {IsCompleted}";
        }


    }
}
