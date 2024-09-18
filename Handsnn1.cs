using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    public   class Person
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public int Salary { get; set; }

    }
    internal class Handsnn1
    {
        public void People()
        {
            List<Person> people = new List<Person>();

            while (true)
            {
                Console.WriteLine("\nEnter Person details or enter 'exit' to Exit");
                string? name = Console.ReadLine();
                if (name.ToLower() == "exit") break;

                Console.WriteLine("Age:");
                if (!int.TryParse(Console.ReadLine(), out int age))
                {
                    Console.WriteLine("Invalid Age");
                    continue;
                }

                Console.WriteLine("Salary: ");
                if (!int.TryParse(Console.ReadLine(), out int salary))
                {
                    Console.WriteLine("Invalid Salary");
                    continue;
                }

                people.Add(new Person { Name = name, Age = age, Salary = salary });
            }

            //Using LINQ

            //Query1: Age Greater than 30:
            var query1 = people.Where(p => p.Age > 30).ToList();

            //Query2: Sort By Name
            var query2 = people.OrderBy(p => p.Name).ToList();

            //Query3: Average Salary
            var query3 = people.Average(p => p.Salary);
        }
    }
}
