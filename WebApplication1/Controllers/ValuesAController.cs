using Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesAController : ControllerBase
    {
        private readonly IProductService _productService;
        public ValuesAController(IProductService productService)
        {
            _productService = productService;
        }

        public async Task<IActionResult> GetAll()
        {
            return Ok(await _productService.GetAllProducts());
        }
    }
}
