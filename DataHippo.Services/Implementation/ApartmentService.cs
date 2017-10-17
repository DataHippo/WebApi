using System;
using System.Threading.Tasks;
using DataHippo.Services.Contracts;
using DataHippo.Services.Entities;
using DataHippo.Services.Exceptions;
using DataHippo.Services.Helpers;
using DataHippo.Services.Repositories.Contracts;
using Microsoft.Extensions.Configuration;

namespace DataHippo.Services.Implementation
{   
    public class ApartmentService : IApartmentService
    {
        private readonly IApartmentRepository _apartmentRepository;
        private readonly IConfiguration _configuration;

        private const string EntityName = "apartment";

        public ApartmentService(IApartmentRepository apartmentRepository, IConfiguration configuration)
        {
            _apartmentRepository = apartmentRepository;
            _configuration = configuration;
        }

        public async Task<PagedResult<Apartment>> GetAllAsync(int page, int pageSize, string fields)
        {
            var maximumPageSize = int.Parse(_configuration["ApiConfiguration:PagingMaxPageSize"]);
            if (pageSize > maximumPageSize)
            {
                throw new PaginationParameterException(string.Format(Resources.ErrorMessages.MaximumPageSizeParameterException, maximumPageSize));
            }

            var totalElements = await GetTotalElements();
            var resutls = await _apartmentRepository.GetAllAsync(page, pageSize, fields).ConfigureAwait(false);

            return new PagedResult<Apartment>
            {
                Data = resutls,
                Paging = PagingHelper.GetPagingValues(_configuration, totalElements, page, pageSize, EntityName)
            };
        }

        public Task<Apartment> GetByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        public async Task<Apartment> CreateAsync(Apartment entity)
        {
            throw new NotImplementedException(); 
        }

        private async Task<long> GetTotalElements()
        {
            var totalElements = await _apartmentRepository.CountAsync().ConfigureAwait(false);
            return totalElements;
        }
        
    }
}
