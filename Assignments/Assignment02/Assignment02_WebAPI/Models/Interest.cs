using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Assignment02_WebAPI.Models {
public class Interest {
    [Key]
    public string Type { get; set; }
    [Required]
    public string Description { get; set; }
    public List<Child> Children { get; set; }

}
}