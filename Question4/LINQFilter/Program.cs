using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQFilter
{
    class Employee
    {
        // Private fields
        private int id;
        private string name;
        private double salary;

        // Public properties
        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Invalid, Id must be greater than zero...");
                }
                id = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Invalid, Name must not be empty...");
                }
                name = value;
            }
        }

        public double Salary
        {
            get
            {
                return salary;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Invalid, Salary must be greater than zero...");
                }
                salary = value;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                // Enter employee records
                Console.Write("Enter number of employees: ");
                int n = int.Parse(Console.ReadLine());

                if (n <= 0)
                {
                    Console.WriteLine("Invalid, Enter at least one record...");
                    return;
                }

                // Store employees in list
                List<Employee> list = new List<Employee>();

                for (int i = 1; i <= n; i++)
                {
                    Employee emp = new Employee();

                    Console.Write("\nEnter employee ID: ");
                    emp.Id = int.Parse(Console.ReadLine());

                    Console.Write("Enter employee Name: ");
                    emp.Name = Console.ReadLine();

                    Console.Write("Enter employee Salary: ");
                    emp.Salary = double.Parse(Console.ReadLine());

                    list.Add(emp);
                }

                // LINQ query
                var empSal = list.Where(emp => emp.Salary > 50000);

                // Check LINQ result is empty
                if (!empSal.Any())
                {
                    Console.WriteLine("No employee found...");
                    return;
                }

                // Display employee name with salary
                Console.WriteLine("\nEmployees with more than 50000 salary: ");
                Console.WriteLine($"Name \t - \t Salary");

                foreach (var emp in empSal)
                {
                    Console.WriteLine($"{emp.Name} \t - \t {emp.Salary}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}