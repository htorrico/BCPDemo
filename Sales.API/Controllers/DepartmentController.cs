
using Sales.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using Sales.Domain.Departments;
using Sales.Service.Request;

namespace API.Controllers
{
    [ApiController]
    [Route("departments")]
    public class DepartmentController : ControllerBase
    {
        private readonly DepartmentService _service;
        private readonly ILogger<DepartmentController> _logger;

        public DepartmentController(ILogger<DepartmentController> logger
            , DepartmentService service)
        {
            _service = service;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var departments = await _service.SearchAsync();
            return Ok(departments);
        }
        [HttpPost]
        public async Task<IActionResult> Add([FromBody] AddDepartmentRequest request)
        {
            var department = await _service.AddNewAsync(request);
            return Ok(department);
        }

    }
}