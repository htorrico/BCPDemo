
using Sales.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using Sales.Domain.Roles;
using Sales.Service.Request;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TargetController : ControllerBase
    {
        private readonly TargetService _service;
        private readonly ILogger<TargetController> _logger;

        public TargetController(ILogger<TargetController> logger
            , TargetService service)
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
        public async Task<IActionResult> Add([FromBody] AddTargetRequest request)
        {
            var response = await _service.AddNewAsync(request);
            return Ok(response);
        }

    }
}