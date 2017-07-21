using System.Collections.Generic;
using AutoMapper;
using DataHippo.Repositories.Entities;
using DataHippo.Services.Contracts;
using DataHippo.Services.Entities;
using Microsoft.AspNetCore.Mvc;

namespace DataHippo.WebApi.Controllers
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class ValuesController : Controller
    {
        private readonly ITestService _testService;
 
        public ValuesController(ITestService testService)
        {
            _testService = testService;
        }

        [HttpGet]
        public IEnumerable<string> Get()
        {
            var elemetns = _testService.GetAllAsync();
            return new string[] { "value1", "value2" };
        }

        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post(Test element)
        {  
            var result = _testService.CreateAsync(element);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

    }
}
