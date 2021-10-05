using System;
using System.Collections.Generic;

namespace Assignment1.Models {
public class Child : Person {
    
    public List<Interest> Interests { get; set; }
    public List<Pet> Pets { get; set; }

    public  string InterestToString()
    {
        string s = "";
        foreach (var interest in Interests)
        {
            s += interest.Type + ", ";
           
        }
        if (s.EndsWith(", "))
        {
            Console.WriteLine("test");
            s= s.Remove(s.Length - 2);
        }

        Console.WriteLine(s);
        return s;
    }
    public  string petsToString()
    {
        string s = "";
        foreach (var pet in Pets)
        {
            s += pet.Species + ", ";
            
        }
        if (s.EndsWith(", "))
        {
           s= s.Remove(s.Length - 2);
        }
        return s;
    }
}
}