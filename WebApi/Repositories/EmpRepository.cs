using Microsoft.EntityFrameworkCore;
using WebApi.models;

namespace WebApi.Repositories
{
    public class EmpRepository : IEmpRepository
    {
        private readonly EmployeeContext _context;
        public EmpRepository(EmployeeContext context)
        {
            _context = context;
        }

        public async Task<emplyoyee> Create(emplyoyee employee)
        {
            _context.employees.Add(employee);
            await _context.SaveChangesAsync();
            return employee;

            
        }

        public async Task Delete(int EmpId)
        {
            var employeetoDelete = await _context.employees.FindAsync(EmpId);
            _context.employees.Remove(employeetoDelete);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<emplyoyee>> Get()
        {
            return await _context.employees.ToListAsync();
        }

        public async Task<emplyoyee> Get(int EmpId)
        {
            return await _context.employees.FindAsync(EmpId);
        }

        public async Task Update(emplyoyee employee)
        {
            _context.Entry(employee).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
