using System.Collections.Generic;
using System.Threading.Tasks;
using DataHippo.Services.Entities;

namespace DataHippo.Services.Repositories.Contracts
{
    public interface ITestRepository
    {
        Task<IEnumerable<Test>> GetAllAsync(int page, int pageSize, string queryFilter, string fieldsProjection);
        Task<Test> GetByIdAsync(string id);
        Task<Test> CreateAsync(Test entity);
        Task<long> CountAsync();
    }
}
