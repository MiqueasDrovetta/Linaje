using System;
namespace Resta;
public class Resta : OperacionMatematica
{
    public override double Calcular(double a, double b)
    {
        return a - b;
    }
}
