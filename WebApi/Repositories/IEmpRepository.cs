using WebApi.models;

namespace WebApi.Repositories
{
    public interface IEmpRepository
    {
        Task<IEnumerable<emplyoyee>> Get();
        Task<emplyoyee> Get(int EmpId);
        Task<emplyoyee> Create(emplyoyee employee);
        Task Update(emplyoyee employee);
        Task Delete(int EmpId);

    }
}
