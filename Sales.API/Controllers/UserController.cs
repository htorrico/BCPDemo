
using Sales.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using Sales.Domain.Users;
using Sales.Service.Request;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly UserService _service;
        private readonly ILogger<UserController> _logger;

        public UserController(ILogger<UserController> logger
            , UserService service)
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
        [HttpPost("AddCustomer")]
        public async Task<IActionResult> AddCustomer([FromBody] AddCustomerRequest request)
        {
            var response = await _service.AddNewCustomerAsync(request);
            return Ok(response);
        }
        [HttpPost("AddSeller")]
        public async Task<IActionResult> AddSeller([FromBody] AddSellerRequest request)
        {
            var response = await _service.AddNewSellerAsync(request);
            return Ok(response);
        }
        [HttpPost("AddManager")]
        public async Task<IActionResult> AddManager([FromBody] AddManagerRequest request)
        {
            var response = await _service.AddNewManagerAsync(request);
            return Ok(response);
        }

    }
}