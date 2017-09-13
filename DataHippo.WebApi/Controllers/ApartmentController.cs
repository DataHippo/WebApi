using System;
using System.Threading.Tasks;
using DataHippo.Services;
using DataHippo.Services.Contracts;
using DataHippo.Services.Entities;
using Microsoft.AspNetCore.Mvc;

namespace DataHippo.WebApi.Controllers
{
    [ApiVersion("0.1")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class ApartmentController : BaseController
    {
        private readonly IApartmentService _apartmentService;
 
        public ApartmentController(IApartmentService apartmentService)
        {
            _apartmentService = apartmentService;
        }

        [HttpGet]
        public async Task<IActionResult> Get(int page = 1, int pageSize = 10, string fields = "")
        {

            var elemetns = await _apartmentService.GetAllAsync(page, pageSize, fields).ConfigureAwait(false);
            return Ok(elemetns);      
        }

        //[HttpGet("{id}")]
        //public string Get(string id)
        //{
        //    throw new NotImplementedException();
        //}

        //// POST api/values
        //[HttpPost]
        //public async Task<IActionResult> Post([FromBody] Test element)
        //{
        //    var result = await _testService.CreateAsync(element);
        //    return Created("/values/1", result);
        //}


        //// PUT api/values/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody]string value)
        //{
        //}
    }
}

