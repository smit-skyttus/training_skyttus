using WebApi.Models;

namespace WebApi.Repositories
{
    public interface IEmpRepository
    {
        Task<IEnumerable<Employee1>> Get();
        Task<Employee1> Get(int EmpID);
        Task<Employee1> Create(Employee1 employee);
        Task Update(Employee1 employee);
        Task Delete(int EmpID);

    }
}

