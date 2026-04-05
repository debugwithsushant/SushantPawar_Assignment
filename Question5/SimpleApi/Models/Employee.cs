namespace SimpleApi.Models
{
    public class Employee
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
}
