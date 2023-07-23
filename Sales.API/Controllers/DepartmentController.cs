
using Sales.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using Sales.Domain.Departments;

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
      
    }
}