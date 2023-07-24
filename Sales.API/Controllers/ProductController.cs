
using Sales.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using Sales.Domain.Products;
using Sales.Service.Request;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly ProductService _service;
        private readonly ILogger<ProductController> _logger;

        public ProductController(ILogger<ProductController> logger
            , ProductService service)
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
        public async Task<IActionResult> Add([FromBody] AddProductRequest request)
        {
            var response = await _service.AddNewAsync(request);
            return Ok(response);
        }

    }
}