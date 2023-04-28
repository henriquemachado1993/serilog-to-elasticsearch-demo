using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SerilogElasticDemo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly ILogger<ProductController> _logger;

        public ProductController(ILogger<ProductController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public string GetNameProduct()
        {
            try
            {
                _logger.LogInformation("Info: Starting search");

                //Forcing exception for test
                throw new Exception("Error in looping");

                _logger.LogInformation("Info: Ending search");

                return "Computer";
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error: Something went wrong");               
            }

            return null;
        }
    }
}
