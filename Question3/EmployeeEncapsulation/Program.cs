namespace EmployeeEncapsulation
{
    class Employee
    {
        // Private fields - data is hidden from outside i.e Encapsulation
        private int id;
        private string name;
        private double salary;

        // Public properties for accessing only essential fields outside
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

                // Employee class object to access fields
                Employee emp = new Employee();

                // Assign value to fields using public properties
                Console.Write("Enter employee ID: ");
                emp.Id = int.Parse(Console.ReadLine());

                Console.Write("Enter employee Name: ");
                emp.Name = Console.ReadLine();

                Console.Write("Enter employee Salary: ");
                emp.Salary = double.Parse(Console.ReadLine());

                // Display employee details
                Console.WriteLine("\nEmployee Details: ");
                Console.WriteLine($"ID: {emp.Id}");
                Console.WriteLine($"Name: {emp.Name}");
                Console.WriteLine($"Salary: {emp.Salary}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }

}