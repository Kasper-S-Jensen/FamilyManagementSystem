using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Assignment1.Models {
public class Family {
    
    //public int Id { get; set; }
    public string StreetName { get; set; }
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
            ss= ss.Remove(ss.Length - 2);
        }
        return ss;
    }
    
}


}