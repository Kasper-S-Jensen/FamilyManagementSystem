using System;

namespace S2Ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Company company = new Company();
            Employee e1 = new FullTimeEmployee("Bob", 32000.0);
            Employee e2 = new PartTimeEmployee("Bubo", 100,37);
            Employee e3 = new FullTimeEmployee("Bobu", 34000.0);
            company.HireNewEmployee(e1);
            company.HireNewEmployee(e2);
            company.HireNewEmployee(e3);

            Console.WriteLine(company.getMonthlySalaryTotal());
            
        }
    }
}