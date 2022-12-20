using Microsoft.EntityFrameworkCore;
using WebApi.Models;

namespace WebApi.Repositories
{
    public class EmployeeRepository : IEmpRepository
    {
        private readonly EmployeeContext _contect;

        public EmployeeRepository(EmployeeContext context)
        {
            _contect = context;
        }
        public async Task<Employee1> Create(Employee1 employee)
        {
           _contect.Employees.Add(employee);
            await _contect.SaveChangesAsync();
            return employee;
        }

        public async Task Delete(int EmpID)
        {
            var employeeToDelete = await _contect.Employees.FindAsync(EmpID);
            _contect.Employees.Remove(employeeToDelete);
            await _contect.SaveChangesAsync();
        }

        public async Task<IEnumerable<Employee1>> Get()
        {
            return await _contect.Employees.ToListAsync();

        }

        public async Task<Employee1> Get(int EmpID)
        {
            return await _contect.Employees.FindAsync(EmpID);
        }

        public async Task Update(Employee1 employee)
        {
            _contect.Entry(employee).State = EntityState.Modified;
            await _contect.SaveChangesAsync();
        }
    }
}
