using System.Threading.Tasks;
using DataHippo.Services.Entities;

namespace DataHippo.Services.Contracts
{
    public interface ITestService
    {
        Task<PagedResult<Test>> GetAllAsync(int page, int pageSize, string filters, string fields);
        Task<Test> GetByIdAsync(string id);
        Task<Test> CreateAsync(Test entity);
    }
}
