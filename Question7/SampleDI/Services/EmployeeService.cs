using SampleDI.Models;

namespace SampleDI.Services
{
    public class EmployeeService : IEmployeeService
    {
        // Sample list to store employee details
        private static List<Employee> empList = new List<Employee>
        {
            new Employee {Id = 1, Name = "Ram", Salary = 50000},
            new Employee {Id = 2, Name = "Shyam", Salary = 25000 }
        };

        // return all employees
        public List<Employee> GetEmployees()
        {
            return empList;
        }

        // Add new employee
        public Employee AddEmployee(Employee emp)
        {
            if(emp == null)
            {
                throw new ArgumentNullException("Enter employee details...");
            }

            if (empList.Any(e => e.Id == emp.Id))
            {
                throw new Exception("Employee already exist...");
            }

            empList.Add(emp);
            return emp;
        }
    }
}
