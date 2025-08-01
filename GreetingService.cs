using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Serilog;
namespace BetterConsoleApp;


public class GreetingService : IGreetingService
{
    private readonly ILogger<GreetingService> _log;
    private readonly IConfiguration _config;

    public GreetingService(ILogger<GreetingService> log, IConfiguration config)
    {
        _log = log;
        _config = config;
        _log.LogInformation("GreetingService initialized with configuration: {Config}", _config);
    }
    public void Run()
    {
        for (int i = 0; i < _config.GetValue<int>("LoopTimes"); i++)
        {
            _log.LogInformation("Run number {runNumber} ", i);
        }
    }
}

