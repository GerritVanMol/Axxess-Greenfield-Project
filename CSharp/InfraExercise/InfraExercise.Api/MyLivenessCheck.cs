using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace InfraExercise.Api;

public class MyLivenessCheck : IHealthCheck
{
    public Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context,
        CancellationToken cancellationToken = default)
    {
        return Task.FromResult(HealthCheckResult.Healthy("alive"));
    }
}