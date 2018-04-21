using System;
using System.ComponentModel.DataAnnotations;

namespace TaskList.Models
{
    public class Task
    {
        public int ID { get; set; }
        
        [StringLength(60, MinimumLength = 8)]
        [Display(Name = "Task Description")]
        public string TaskDescription { get; set; }

        [Display(Name = "Due Date"), DataType(DataType.Date)]
        public DateTime DueDate { get; set; }    
        
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        [Required, StringLength(15)]
        public string Priority { get; set; }    
    }
}