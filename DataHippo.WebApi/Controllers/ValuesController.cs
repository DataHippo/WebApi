using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DataHippo.Services.Contracts;
using DataHippo.Services.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;

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
            //var elemetns = _testService.GetAllAsync();
            return new string[] { "value1", "value2" };
        }

        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public async Task<IActionResult> Post([FromBody]Test element)
        {
            if (element == null)
            {
                return BadRequest();
            }

            try
            {
                var result = await _testService.CreateAsync(element);
                return Created("/values/1", result);
            }
            catch (Exception e)
            {
                //TODO: Gestión de errores
                throw;
            }
         
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

