using System.ComponentModel.DataAnnotations;

namespace Assignment02_WebAPI.Models
{
    public class User
    {
        [Key]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public int SecurityLevel { get; set; }
    }
}