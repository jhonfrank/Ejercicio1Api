using Ejercicio1Api.Model;

namespace Ejercicio1Api.Repository
{
    public interface IEmployeeRepository    {
        public List<Employee> GetAllEmployees();
        public Employee GetEmployee(int id);
        public Employee GetEmployee(string document_number);
        public void SaveEmployee(Employee item);
        public void UpdateEmployee(int id, Employee item);
        public void DeleteEmployee(int id);
    }
}
