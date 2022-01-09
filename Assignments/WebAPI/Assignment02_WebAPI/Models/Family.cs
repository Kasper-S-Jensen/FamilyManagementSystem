using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Assignment02_WebAPI.Models {
public class Family {
    
    [Key]
    public int Id { get; set; }
    [Required]
    public string StreetName { get; set; }
    [Required]
    public int HouseNumber{ get; set; }
    public List<Adult> Adults { get; set; }
    
    public List<Child> Children{ get; set; }
    public List<Pet> Pets{ get; set; }

    public Family() {
        Adults = new List<Adult>();     
    }
    
    public string petsToString()
    {
        string ss = "";
        foreach (var pet in Pets)
        {
            ss += pet.Species + ", ";
        }

        if (ss.EndsWith(", "))
        {
            ss = ss.Remove(ss.Length - 2);
        }

        return ss;
    }
    

}


}