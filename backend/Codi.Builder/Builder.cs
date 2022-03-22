namespace Codi.Builder;

public class Builder : BackgroundService
{
    private readonly ILogger<Builder> _logger;

    public Builder(ILogger<Builder> logger)
    {
        _logger = logger;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        await Task.CompletedTask;
    }
}