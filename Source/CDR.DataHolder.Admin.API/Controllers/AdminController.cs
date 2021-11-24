using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CDR.DataHolder.Admin.API.Controllers
{
    [ApiController]
    [Route("cds-au")]
    public class AdminController : ControllerBase
    {
        private readonly ILogger<AdminController> _logger;

        public AdminController(ILogger<AdminController> logger)
        {
            _logger = logger;
        }

        [HttpGet("v1/admin/metrics")]
        [ApiVersion("1")]
        [HttpGet]
        public async Task GetMetrics()
        {
            _logger.LogInformation($"Request received to {nameof(AdminController)}.{nameof(GetMetrics)}");
            var json = await System.IO.File.ReadAllTextAsync("Data/allResponse.json");

            // Return the raw JSON response.
            Response.ContentType = "application/json";
            await Response.BodyWriter.WriteAsync(System.Text.UTF8Encoding.UTF8.GetBytes(json));
        }

        [HttpGet("v1/admin/metrics")]
        [ApiVersion("2")]
        [HttpGet]
        public async Task GetMetricsV2()
        {
            _logger.LogInformation($"Request received to {nameof(AdminController)}.{nameof(GetMetricsV2)}");
            var json = await System.IO.File.ReadAllTextAsync("Data/allResponse.json");

            // Return the raw JSON response.
            Response.ContentType = "application/json";
            await Response.BodyWriter.WriteAsync(System.Text.UTF8Encoding.UTF8.GetBytes(json));
        }
    }
}
