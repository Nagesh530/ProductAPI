using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace ProductWebAPI.DTOs
{
    public class HealthResult
    {
        public HealthStatus Status { get; }
        public string Description { get; }

        public HealthResult(HealthStatus status, string description)
        {
            Status = status;
            Description = description;
        }
    }
}
