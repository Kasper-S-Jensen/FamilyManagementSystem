using System.ComponentModel.DataAnnotations;

namespace Assignment02_WebAPI.Models
{
    public class Job
    {
        [Key]
        public string JobTitle { get; set; }
        [Required, Range(1, int.MaxValue, ErrorMessage = "Please enter a value bigger than {1}")]
        public int Salary { get; set; }
    }
}