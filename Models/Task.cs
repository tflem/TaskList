using System;
using System.ComponentModel.DataAnnotations;

namespace TaskList.Models
{
    public class Task
    {
        public int ID { get; set; }
        public string TaskDescription { get; set; }

        [Display(Name = "Due Date")]
        [DataType(DataType.Date)]
        public DateTime DueDate { get; set; }        
    }
}