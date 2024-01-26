using Microsoft.Extensions.Diagnostics.HealthChecks;
using ProductWebAPI.DTOs;

namespace ProductWebAPI.Repositories
{
    public class CacheHealthChecker : ICacheHealthChecker
    {

        private readonly HealthCheckService _healthCheckService;
        public CacheHealthChecker(HealthCheckService healthCheckService)
        {
            _healthCheckService = healthCheckService;
        }

        public async Task<HealthResult> CheckHealthAsync()
        {
            try
            {
                var healthCheckResult = await _healthCheckService.CheckHealthAsync();


                if (healthCheckResult != null)
                {
                    return new HealthResult(HealthStatus.Healthy, "Cache is healthy");
                }
                else
                {
                    return new HealthResult(HealthStatus.Unhealthy, "Cache is unhealthy");
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions if necessary
                return new HealthResult(HealthStatus.Unhealthy, $"Cache check failed: {ex.Message}");
            }
        }
    }
}
