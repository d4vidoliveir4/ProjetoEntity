using System.Collections.Generic;

namespace Entity.Models
{
    public interface IEmployeeService
    {

        Employee AddEmployee(Employee employee);
        List<Employee> GetEmployees();
        void UpdateEmployee(Employee employee);
        void DeleteEmployee(int Id);
        Employee GetEmployee(int Id);
    }
}
