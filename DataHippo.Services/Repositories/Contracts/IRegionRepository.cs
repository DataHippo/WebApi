using System.Collections.Generic;
using System.Threading.Tasks;
using DataHippo.Services.Entities;

namespace DataHippo.Services.Repositories.Contracts
{
    public interface IRegionRepository
    {
        Task<IEnumerable<Region>> GetByNameAsync(string regionName);
        Task<Region> GetByIdAsync(string id);
        Task<IEnumerable<Region>> GetByCountryAsync(string regionName);
    }
}
