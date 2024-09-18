using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{

    internal class Employee
    {
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public int Salary { get; set; }
    }
    internal class Employees
    {
        private void EmoployeeMethod()
        {
            Employee[] employeeArray = {
            new Employee() { EmployeeID = 1, EmployeeName = "Peter", Salary = 1000},
            new Employee() { EmployeeID = 2, EmployeeName = "Disha", Salary = 3000},
            new Employee() { EmployeeID = 3, EmployeeName = "Linda", Salary = 4000},
            new Employee() { EmployeeID = 4, EmployeeName = "Markus", Salary = 10000}
        };

            //Using Method
            Employee[] employees = employeeArray.Where(s => s.Salary < 1500).ToArray();
            foreach (Employee employee in employeeArray)
            {
                Console.WriteLine(employee);
            }
        }

    }
}
