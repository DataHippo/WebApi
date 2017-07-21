using System.Collections.Generic;
using System.Threading.Tasks;
using DataHippo.Services.Entities;

namespace DataHippo.Services.Repositories.Contracts
{
    public interface ITestRepository
    {
        Task<IEnumerable<Test>> GetAllAsync();
        Task<Test> GetByIdAsync(string id);
        Task<string> CreateAsync(Test entity);
    }
}
