using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using ProductWebAPI.Repositories;

namespace ProductWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HealthCheckController : ControllerBase
    {
        private readonly ICacheHealthChecker _cacheHealthChecker;

        public HealthCheckController(ICacheHealthChecker healthCheckService)
        {
            _cacheHealthChecker = healthCheckService;
        }

        [AllowAnonymous]
        [HttpGet("health")]
        public async Task<IActionResult> HealthCheck()
        {
            var healthCheckResult = await _cacheHealthChecker.CheckHealthAsync();

            var response = new
            {
                Status = healthCheckResult.Status.ToString(),
            };

            if ( healthCheckResult.Status == HealthStatus.Healthy)
            {
                return Ok(response);
            }
            else
            {
                return StatusCode(500, response);
            }
        }


        private HealthStatus DetermineOverallStatus(params HealthStatus[] statuses)
        {
            // Determine overall status based on individual component statuses
            return statuses.Any(s => s == HealthStatus.Unhealthy) ? HealthStatus.Unhealthy : HealthStatus.Healthy;
        }
    }
}
