// See https://aka.ms/new-console-template for more information
using Microsoft.Extensions.Logging;


internal class Program
{
    static void Main(string[] args)
    {
        using ILoggerFactory factory = LoggerFactory.Create(builder => builder.AddConsole());
        ILogger logger = factory.CreateLogger<Program>();

        logger.LogInformation("starting Program.");

    }
}


