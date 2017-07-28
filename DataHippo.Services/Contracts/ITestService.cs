using System.Collections.Generic;
using System.Threading.Tasks;
using DataHippo.Services.Entities;

namespace DataHippo.Services.Contracts
{
    public interface ITestService
    {
        Task<IEnumerable<Test>> GetAllAsync(string filters, string fields);
        Task<Test> GetByIdAsync(string id);
        Task<Test> CreateAsync(Test entity);
    }
}
