using System;

public class ConsumoMedio
{

    public static void Main(string[] args)
    {

        var distanciaPercorrida = Convert.ToInt32(Console.ReadLine());
        var combustivelGasto = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("{0:0.000} km/l", distanciaPercorrida / combustivelGasto);
    }
}