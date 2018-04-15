using System;

namespace TaskList.Models
{
    public class Task
    {
        public int ID { get; set; }
        public string TaskDescription { get; set; }
        public DateTime DueDate { get; set; }        
    }
}