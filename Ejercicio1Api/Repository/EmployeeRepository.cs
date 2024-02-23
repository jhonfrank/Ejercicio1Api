using Ejercicio1Api.Model;
using System.Collections.Generic;

namespace Ejercicio1Api.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public List<Employee> GetAllEmployees()
        {
            List<Employee> list = new List<Employee>();
            list.Add(new Employee());
            list.Add(new Employee());
            list.Add(new Employee());
            return list;
        }
        public Employee GetEmployee(int id)
        {
            return new Employee();
        }
        public Employee GetEmployee(string document_number)
        {
            return new Employee();
        }
        public void SaveEmployee(Employee item)
        {
        }
        public void UpdateEmployee(Employee item)
        {
        }
        public void DeleteEmployee(int id)
        {
        }
    }
}
