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
        public Task<Employee1> Create(Employee1 employee)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int EmpID)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Employee1>> Get()
        {
            throw new NotImplementedException();
        }

        public Task<Employee1> Get(int EmpID)
        {
            throw new NotImplementedException();
        }

        public Task Update(Employee1 employee)
        {
            throw new NotImplementedException();
        }
    }
}
