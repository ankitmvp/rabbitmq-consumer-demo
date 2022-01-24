using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using RabbitMQ.Client.Core.DependencyInjection.Services;

public class Worker : BackgroundService
{
    readonly IQueueService _queueService;

    public Worker(IQueueService queueService)
    {
        _queueService = queueService;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        _queueService.StartConsuming();
    }
}