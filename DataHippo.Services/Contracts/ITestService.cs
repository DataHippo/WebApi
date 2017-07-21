using System.Collections.Generic;
using System.Threading.Tasks;
using DataHippo.Services.Entities;

namespace DataHippo.Services.Contracts
{
    public interface ITestService
    {
        Task<IEnumerable<Test>> GetAllAsync();
        Task<Test> GetByIdAsync(string id);
        Task<string> CreateAsync(Test entity);
    }
}
