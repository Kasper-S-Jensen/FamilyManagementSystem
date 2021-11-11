using System.ComponentModel.DataAnnotations;

namespace Assignment02_WebAPI.Models
{
    public class Adult : Person
    {
        [Required]
        public Job JobTitle { get; set; }

    }
}