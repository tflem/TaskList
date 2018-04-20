using System;
using System.ComponentModel.DataAnnotations;

namespace TaskList.Models
{
    public class Task
    {
        public int ID { get; set; }
        
        [StringLength(60, MinimumLength = 8)]
        [Required]
        public string TaskDescription { get; set; }

        [Display(Name = "Due Date")]
        [DataType(DataType.Date)]
        public DateTime DueDate { get; set; }    
        
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        [StringLength(15)]
        [Required]
        public string Priority { get; set; }    
    }
}