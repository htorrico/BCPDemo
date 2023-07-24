
using Sales.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using Sales.Domain.Agencies;
using Sales.Service.Request;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AgencyController : ControllerBase
    {
        private readonly AgencyService _service;
        private readonly ILogger<AgencyController> _logger;

        public AgencyController(ILogger<AgencyController> logger
            , AgencyService service)
        {
            _service = service;
            _logger = logger;
        }

        [HttpGet("Get")]
        public async Task<IActionResult> Get()
        {
            var response = await _service.SearchAsync();
            return Ok(response);
        }
        [HttpPost("Add")]
        public async Task<IActionResult> Add([FromBody] AddAgencyRequest request)
        {
            var response = await _service.AddNewAsync(request);
            return Ok(response);
        }

    }
}