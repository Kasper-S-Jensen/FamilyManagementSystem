using System.Collections.Generic;

namespace Assignment02_WebAPI.Models
{
    public class Child : Person
    {
        public List<Interest> Interests { get; set; }
        public List<Pet> Pets { get; set; }

        public string InterestToString()
        {
            string s = "";
            foreach (var interest in Interests)
            {
                s += interest.Type + ", ";
            }

            if (s.EndsWith(", "))
            {
                s = s.Remove(s.Length - 2);
            }

            return s;
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