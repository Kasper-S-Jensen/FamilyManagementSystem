using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace TodosWebAPI.Models
{
    public class Todo
    {
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Please enter a value bigger than {1}")]
        [JsonPropertyName("userId")]
        public int UserID { get; set; }

        [JsonPropertyName("id"),Key]
        public int TodoID { get; set; }
        
        [Required, MaxLength(128)] 
        [JsonPropertyName("title")]
        public string Title { get; set; }
        
        [JsonPropertyName("completed"), Required]
        public bool IsCompleted { get; set; }
    }
}