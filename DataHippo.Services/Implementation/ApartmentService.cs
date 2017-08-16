using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataHippo.Resources;
using DataHippo.Services.Contracts;
using DataHippo.Services.Entities;
using DataHippo.Services.Exceptions;
using DataHippo.Services.Repositories.Contracts;

namespace DataHippo.Services.Implementation
{   
    public class ApartmentService : IApartmentService
    {
        private readonly IApartmentRepository _apartmentRepository;

        public ApartmentService(IApartmentRepository apartmentRepository)
        {
            _apartmentRepository = apartmentRepository;
        }

        public async Task<IEnumerable<Apartment>> GetAllAsync(string fields)
        {
            throw new NotImplementedException();
            //var fieldsProjection = BuidlFieldsProjection(fields);
            
            //return await _apartmentRepository.GetAllAsync(fieldsProjection);
        }

        public Task<Apartment> GetByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        public async Task<Apartment> CreateAsync(Apartment entity)
        {
            throw new NotImplementedException();
            //if (entity == null)
            //{
            //    throw new TestCustomException(ErrorMessages.TestException);
            //}
            //return await _testRepository.CreateAsync(entity);
        }
    }
}
