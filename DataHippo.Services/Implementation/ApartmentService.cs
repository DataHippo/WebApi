using System;
using System.Threading.Tasks;
using DataHippo.Services.Contracts;
using DataHippo.Services.Entities;
using DataHippo.Services.Repositories.Contracts;
using Microsoft.Extensions.Configuration;

namespace DataHippo.Services.Implementation
{   
    public class ApartmentService : IApartmentService
    {
        private readonly IApartmentRepository _apartmentRepository;
        private readonly IConfiguration _configuration;

        public ApartmentService(IApartmentRepository apartmentRepository, IConfiguration configuration)
        {
            _apartmentRepository = apartmentRepository;
            _configuration = configuration;
        }

        public async Task<PagedResult<Apartment>> GetAllAsync(int page, int pageSize, string fields)
        {

            var apiUrl = _configuration["ApiConfiguration:Url"];
            var apiVersion = _configuration["ApiConfiguration:Version"];

            var totalElements = await _apartmentRepository.CountAsync().ConfigureAwait(false);
            var resutls = await _apartmentRepository.GetAllAsync(page, pageSize, fields).ConfigureAwait(false);

            var mod = totalElements % pageSize;
            var totalPagesCount = (totalElements / pageSize) + (mod == 0 ? 0 : 1);

            var nextPage = page < totalPagesCount ? $"{apiUrl}/{apiVersion}/values/?page={page + 1}&pageSize={pageSize}" : string.Empty;
            var previousPage = page > 1 ? $"{apiUrl}/{apiVersion}/values/?page={page - 1}&pageSize={pageSize}" : string.Empty;

            return new PagedResult<Apartment>
            {
                Data = resutls,
                Paging = new PageValues
                {
                    Next = nextPage,
                    Previous = previousPage,
                    First = $"{apiUrl}/{apiVersion}/values/?page=1&pageSize={pageSize}",
                    Last = $"{apiUrl}/{apiVersion}/values/?page={totalPagesCount}&pageSize={pageSize}",
                    TotalElements = (int)totalElements,
                    TotalPages = (int)totalPagesCount

                }
            };
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
