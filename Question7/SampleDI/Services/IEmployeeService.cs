using SampleDI.Models;

namespace SampleDI.Services
{
    public interface IEmployeeService
    {
        // Return all employee list
        List<Employee> GetEmployees();

        // Add new employee
        Employee AddEmployee(Employee emp);
    }
}
