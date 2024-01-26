using ProductWebAPI.DTOs;

namespace ProductWebAPI.Repositories
{
    public interface ICacheHealthChecker
    {
        Task<HealthResult> CheckHealthAsync();
    }
}
