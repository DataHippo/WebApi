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
using Microsoft.Extensions.Configuration;


namespace DataHippo.Services.Implementation
{   
    public class TestService : ITestService
    {

        private readonly ITestRepository _testRepository;
        private readonly IConfiguration _configuration;

        public TestService(ITestRepository testRepository, IConfiguration configuration)
        {
            _testRepository = testRepository;
            _configuration = configuration;
        }

        public async Task<PagedResult<Test>> GetAllAsync(int page, int pageSize, string filter, string fields)
        {

            var apiUrl = _configuration["ApiConfiguration:Url"];
            var apiVersion = _configuration["ApiConfiguration:Version"];

            var fieldsProjection = BuidlFieldsProjection(fields);

            var totalElements = await _testRepository.CountAsync();
            var resutls =  await _testRepository.GetAllAsync(page, pageSize, filter, fieldsProjection);

            var mod = totalElements % pageSize;
            var totalPagesCount = (totalElements / pageSize) + (mod == 0 ? 0 : 1);

            var nextPage = page < totalPagesCount ? $"{apiUrl}/{apiVersion}/values/?page={page + 1}&pageSize={pageSize}" : string.Empty;
            var previousPage = page > 1 ? $"{apiUrl}/{apiVersion}/values/?page={page - 1}&pageSize={pageSize}" : string.Empty;

            return new PagedResult<Test>
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

        public Task<Test> GetByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        public async Task<Test> CreateAsync(Test entity)
        {         
            if (entity == null)
            {
                throw new TestCustomException(ErrorMessages.TestException);
            }
            return await _testRepository.CreateAsync(entity);
        }

        private string BuidlFieldsProjection(string fields)
        {
            var result = new StringBuilder();

            result.Append("{");

            if (!string.IsNullOrWhiteSpace(fields))
            {
                if (fields.Contains(","))
                {
                    List<string> fieldsProjectionValues = fields.Split(',').ToList();

                    foreach (var fieldValue in fieldsProjectionValues)
                    {
                        result.AppendFormat("{0}:1,", fieldValue);
                    }
                }
                else
                {
                    result.AppendFormat("{0}:1", fields);
                }
            }
            result.Append("}");

            return result.ToString();
        }
    }
}
