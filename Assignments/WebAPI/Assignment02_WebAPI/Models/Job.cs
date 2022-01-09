using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Assignment02_WebAPI.Models
{
    public class Job
    {
       
        public string JobTitle { get; set; }
        [Required, Range(1, int.MaxValue, ErrorMessage = "Please enter a value bigger than {1}")]
        public int Salary { get; set; }
        
    }
}