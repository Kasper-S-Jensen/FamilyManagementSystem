using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment02_WebAPI.Models
{
    public class Adult : Person
    {
       
        public Job Job { get; set; }
    }
}


