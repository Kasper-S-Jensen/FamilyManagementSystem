using System.Collections.Generic;
using BakeryProject.Models;

namespace BakeryProject.Data
{
    public interface IproductsService
    {
        public IList<Product> Products { get; }
    }
}