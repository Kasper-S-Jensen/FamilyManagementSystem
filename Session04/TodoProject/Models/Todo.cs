using System.ComponentModel.DataAnnotations;

namespace TodoProject.Models
{
    public class Todo
    {
        [Range(1, int.MaxValue, ErrorMessage = "Please enter a value bigger than {1}")]
        public int UserID { get; set; }

        public int TodoID { get; set; }
        [Required, MaxLength(128)] public string Title { get; set; }
        public bool IsCompleted { get; set; }
    }
}