using System.Collections.Generic;
using System.Threading.Tasks;
using DataHippo.Repositories.Entities;

namespace DataHippo.Repositories.Contracts
{
    public interface ITestRepository
    {
        Task<IEnumerable<TestDto>> GetAllAsync();
        Task<TestDto> GetByIdAsync(string id);
        Task<string> CreateAsync(TestDto entity);
    }
}
