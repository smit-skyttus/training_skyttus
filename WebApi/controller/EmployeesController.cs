using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi.models;
using WebApi.Repositories;

namespace WebApi.controller
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
        public async Task<IEnumerable<emplyoyee>> GetEmployees()
        {
            return await _empRepository.Get();
        }
        [HttpGet("{EmpId}")]
        public async Task<ActionResult<emplyoyee>> GetEmployees(int EmpId)
        {
            return await _empRepository.Get(EmpId);


        }
        [HttpPost]
        public async Task<ActionResult<emplyoyee>> PostEmployees(int EmpId, [FromBody] emplyoyee employee)
        {
            var newEmployee = await _empRepository.Create(employee);
            return CreatedAtAction(nameof(GetEmployees), new { EmpId = newEmployee.EmpId },newEmployee);
        }
        [HttpPut]
        public async Task<ActionResult> putEmployees(int EmpId, [FromBody] emplyoyee Employee)
        {
            if (EmpId != Employee.EmpId)
            {
                return BadRequest();
            }
            await _empRepository.Update(Employee);
            return NoContent();
        }
        [HttpDelete("{EmpId}")]
        public async Task<ActionResult>Delete(int EmpId)
        {
            var employeeTodelete = await _empRepository.Get(EmpId);
            if(employeeTodelete == null)
            
                return NotFound();
                await _empRepository.Delete(employeeTodelete.EmpId);
                return NoContent();
            
        }
    }    

}
