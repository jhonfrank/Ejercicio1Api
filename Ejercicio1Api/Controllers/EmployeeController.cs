using Microsoft.AspNetCore.Mvc;
using Ejercicio1Api.Model;
using Ejercicio1Api.Repository;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Ejercicio1Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private IEmployeeRepository repository = new EmployeeRepository();

        // GET: api/<EmployeeController>
        [HttpGet]
        public IEnumerable<Employee> Get()
        {
            return repository.GetAllEmployees();
        }

        // GET api/<EmployeeController>/5
        [HttpGet("{id}")]
        public Employee Get(int id)
        {
            return repository.GetEmployee(id);
        }

        // GET api/<EmployeeController>/78456948
        [HttpGet("{document_number}")]
        public Employee Get(string document_number)
        {
            return repository.GetEmployee(document_number);
        }

        // POST api/<EmployeeController>
        [HttpPost]
        public void Post([FromBody] Employee item)
        {
            repository.SaveEmployee(item);
        }

        // PUT api/<EmployeeController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Employee item)
        {
            repository.UpdateEmployee(item);
        }

        // DELETE api/<EmployeeController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            repository.DeleteEmployee(id);
        }
    }
}
