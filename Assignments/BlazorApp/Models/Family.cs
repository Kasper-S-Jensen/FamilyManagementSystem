using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BlazorApp.Models {
public class Family {
    
    public string StreetName { get; set; }
    public int HouseNumber{ get; set; }
    public List<Adult> Adults { get; set; }
    public List<Child> Children{ get; set; }
    public List<Pet> Pets{ get; set; }

    public Family() {
        Adults = new List<Adult>();     
    }
    
    public string PetsToString()
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