using System.Threading.Tasks;
using DataHippo.Services.Contracts;
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
        public async Task<IActionResult> Get(int page = 1, int pageSize = 50, string fields = "")
        {
            var elemetns = await _apartmentService.GetAllAsync(page, pageSize, fields).ConfigureAwait(false);
            return Ok(elemetns);      
        }

        //[HttpGet("{id}")]
        //public string Get(string id)
        //{
        //    throw new NotImplementedException();
        //}

    }
}

