using ExposedOpening;


internal class Program
{
    static void Main(string[] args)
    {
        var app = new ExposeOpeningCalculator();

        var area = app.GetValues(30);
        var result = app.CalcPoint(1.5, area);

        Console.WriteLine(result);
    }
}


