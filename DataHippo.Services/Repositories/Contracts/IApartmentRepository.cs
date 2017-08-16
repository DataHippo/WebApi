using System.Collections.Generic;
using System.Threading.Tasks;
using DataHippo.Services.Entities;

namespace DataHippo.Services.Repositories.Contracts
{
    public interface IApartmentRepository
    {
        Task<IEnumerable<Apartment>> GetAllAsync(string fieldsProjection);
        Task<Apartment> GetByIdAsync(string id);
        Task<Apartment> CreateAsync(Apartment entity);
    }
}
