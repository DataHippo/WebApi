using System.Threading.Tasks;
using DataHippo.Services.Entities;

namespace DataHippo.Services.Contracts
{
    public interface IApartmentService
    {
        Task<PagedResult<Apartment>> GetAllAsync(int page, int pageSize, string fields);
        Task<Apartment> GetByIdAsync(string id);
        Task<Apartment> CreateAsync(Apartment entity);
    }
}
