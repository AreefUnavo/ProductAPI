using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ProductAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetProducts()
        {
            return Ok(new[]
            {
            new {
                Id=1,
                Name="Laptop",
                Price=75000
            },
            new {
                Id=2,
                Name="Mobile",
                Price=25000
            }
        });
        }
    }
}

