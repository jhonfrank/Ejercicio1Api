using Microsoft.AspNetCore.Mvc;
using Ejercicio1Api.Model;
using Ejercicio1Api.Repository;
using System.Net;

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
        public ActionResult<IEnumerable<Employee>> Get()
        {
            return Ok(repository.GetAllEmployees());
        }

        // GET api/<EmployeeController>/5
        [HttpGet("{id}")]
        public ActionResult<Employee> Get(int id)
        {
            return Ok(repository.GetEmployee(id));
        }

        // GET api/<EmployeeController>/78456948
        [HttpGet("document_number/{document_number}")]
        public ActionResult<Employee> Get(string document_number)
        {
            if (!document_number.Length.Equals(8))
            {
                return NotFound();
            }
            return Ok(repository.GetEmployee(document_number));
        }

        // POST api/<EmployeeController>
        [HttpPost]
        public ActionResult Post([FromBody] Employee item)
        {
            repository.SaveEmployee(item);
            return Ok();
        }

        // PUT api/<EmployeeController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Employee item)
        {
            repository.UpdateEmployee(id, item);
        }

        // DELETE api/<EmployeeController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            repository.DeleteEmployee(id);
            return Ok();
        }
    }
}
