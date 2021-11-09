using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace TodosWebAPI.Models
{
    public class Todo
    {
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Please enter a value bigger than {1}")]
        [JsonPropertyName("UserID")]
        public int UserID { get; set; }

        [JsonPropertyName("TodoID"),Key]
        public int TodoID { get; set; }
        
        [Required, MaxLength(128)] 
        [JsonPropertyName("Title")]
        public string Title { get; set; }
        
        [JsonPropertyName("IsCompleted"), Required]
        public bool IsCompleted { get; set; }
    }
}