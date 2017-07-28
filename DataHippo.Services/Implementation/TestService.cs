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
    public class TestService : ITestService
    {
        private readonly ITestRepository _testRepository;

        public TestService(ITestRepository testRepository)
        {
            _testRepository = testRepository;
        }

        public async Task<IEnumerable<Test>> GetAllAsync(string filter, string fields)
        {
          
            var fieldsProjection = BuidlFieldsProjection(fields);
            
            return await _testRepository.GetAllAsync(filter, fieldsProjection);
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
