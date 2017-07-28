using System.Threading.Tasks;
using DataHippo.Services;
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
        public async Task<IActionResult> Get(string filter = "", string fields = "")
        {

            var elemetns = await _testService.GetAllAsync(filter, fields);
            return Ok(elemetns);      
        }

        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Test element)
        {
            var result = await _testService.CreateAsync(element);
            return Created("/values/1", result);
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

