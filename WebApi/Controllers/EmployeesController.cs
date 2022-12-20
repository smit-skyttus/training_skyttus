using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models;
using WebApi.Repositories;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmpRepository _empRepository;

        public EmployeesController(IEmpRepository empRepository)
        {
            _empRepository = empRepository;
        }
        [HttpGet]
        public async Task<IEnumerable<Employee1>> GetEmployees()
        {
            return await _empRepository.Get();
        }
        [HttpGet("{EmpID}")]
        public async Task<ActionResult<Employee1>> GetEmployee(int EmpID)
        {
            return await _empRepository.Get(EmpID);
        }
        [HttpPost]
        public async Task<ActionResult<Employee1>> PostEmployees([FromBody]Employee1 employee1)
        {
            var newEmpoyee = await _empRepository.Create(employee1);
            return CreatedAtAction(nameof(GetEmployees),new {EmpID=newEmpoyee.EmpID}, newEmpoyee);
        }
        [HttpPut]
        public async Task<ActionResult>PutEmployees(int EmpID, [FromBody] Employee1 employee1)
        {
            if(EmpID!=employee1.EmpID)
            {
                return BadRequest();
            }
            await _empRepository.Update(employee1);
            return NoContent();
        }
        [HttpDelete("{EmpID}")]
        public async Task<ActionResult>Delete(int EmpID)
        {
            var employeeToDelete = await _empRepository.Get(EmpID);
            if(employeeToDelete == null)
            {
                return NotFound();
            }
            await _empRepository.Delete(employeeToDelete.EmpID);
            return NoContent();
        }
    }
       

    
}
