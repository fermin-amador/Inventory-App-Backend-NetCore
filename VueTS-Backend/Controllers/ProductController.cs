using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Services.Customers;
using Services.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VueTS_Backend.Controllers
{
    [ApiController]
    public class ProductController: ControllerBase
    {
        private readonly ILogger<ProductController> _logger;
        private readonly IProductService _productService;

        public ProductController(ILogger<ProductController> logger, IProductService productService)
        {
            _logger = logger;
            _productService = productService;
        }

        [HttpGet("/api/product")]
        public ActionResult GetProduct()
        {
            _logger.LogInformation("Getting all products HEY HEY ALGO LLEGO AQUI");
            var products = _productService.GetAllProducts();
            return Ok(products);
        }
    }
}
