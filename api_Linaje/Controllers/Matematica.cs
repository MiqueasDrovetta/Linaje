using Microsoft.AspNetCore.Mvc;
using entities_library.OperacionMatematica;
using entities_library.Resta;
using entities_library.Suma;

namespace api_Linaje.Controllers;

[ApiController]
[Route("[controller]")]
public class Matematica : ControllerBase
{
    private readonly ILogger<Matematica> _logger;

    public OperacionMatematica(ILogger<OperacionMatematica> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "Matematica")]
    public IEnumerable<Matematica> Get()
    {
        list<OperacionMatematica> oms = new list<OperacionMatematica>
        oms.add(new Suma());
        oms.add(new Resta());
        foreach(OperacionMatematica om in oms)
        {
            om.resultado = om.Calcular(1,3);
        }
        return oms;
    }
    
    [HttpGet]
    public IEnumerable<double> Get(double a, double b)
    {
        List<double> resultados = new List<double>();

        // Recorre la lista de operaciones matemáticas y llama al método Calcular en cada una
        foreach (var operacion in operacionesMatematicas)
        {
            double resultado = operacion.Calcular(a, b);
            resultados.Add(resultado);
        }

        return resultados;
    }
   
}