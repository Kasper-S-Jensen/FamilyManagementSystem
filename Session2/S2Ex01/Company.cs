using System.Collections.Generic;

namespace S2Ex01
{
    public class Company
    {
        public List<Employee> Employees { get; set; } = new List<Employee>();
        public double getMonthlySalaryTotal()
        {
            double total = 0.0;
            
            foreach (var employee in Employees)
            {
               total+= employee.GetMonthlySalary();
            }

            return total;
        }

        public void HireNewEmployee(Employee employee)
        {
            Employees.Add(employee);
        }
    }
}