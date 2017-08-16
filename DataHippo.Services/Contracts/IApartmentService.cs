using System.Collections.Generic;
using System.Threading.Tasks;
using DataHippo.Services.Entities;

namespace DataHippo.Services.Contracts
{
    public interface IApartmentService
    {
        Task<IEnumerable<Apartment>> GetAllAsync(string fields);
        Task<Apartment> GetByIdAsync(string id);
        Task<Apartment> CreateAsync(Apartment entity);
    }
}
