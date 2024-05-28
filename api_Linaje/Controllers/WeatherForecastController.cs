using Microsoft.AspNetCore.Mvc;


namespace api_Linaje.Controllers;


[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<WeatherForecastController> _logger;

    public WeatherForecastController(ILogger<WeatherForecastController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<WeatherForecast> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        {
            Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        })
        .ToArray();
    }

    class Program
{
    static void Main(string[] args)
    {
        double numero1 = 10;
        double numero2 = 5;

        // Crear una lista de OperacionMatematica
        List<OperacionMatematica> operaciones = new List<OperacionMatematica>();
        operaciones.Add(new Suma());
        operaciones.Add(new Resta());

        // Recorrer la lista y llamar al método calcular en cada objeto
        foreach (var operacion in operaciones)
        {
            double resultado = operacion.Calcular(numero1, numero2);
            Console.WriteLine($"El resultado de la operación es: {resultado}");
        }
    }
}

}
