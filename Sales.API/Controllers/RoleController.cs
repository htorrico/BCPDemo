
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
    public class RoleController : ControllerBase
    {
        private readonly RoleService _service;
        private readonly ILogger<RoleController> _logger;

        public RoleController(ILogger<RoleController> logger
            , RoleService service)
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
        public async Task<IActionResult> Add([FromBody] AddRoleRequest request)
        {
            var response = await _service.AddNewAsync(request);
            return Ok(response);
        }

    }
}