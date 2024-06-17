using ExposedOpening;
using Microsoft.Extensions.Logging;


internal class Program
{
    static void Main(string[] args)
    {
        using ILoggerFactory factory = LoggerFactory.Create(builder => builder.AddConsole());
        ILogger logger = factory.CreateLogger<Program>();

        logger.LogInformation("starting Program.");

        var app = new ExposeOpeningCalculator();

        var area = app.GetValues(30);
        var result = app.CalcPoint(1.5, area);

        Console.WriteLine(result);

    }
}


