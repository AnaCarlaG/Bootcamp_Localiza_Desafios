using System; 
using System.Globalization;

public class CalculaSalario {

	public static void Main(string[] args)
    { 
     
            double salario, reajuste, novoSalario,percentual;
            salario = Convert.ToDouble(Console.ReadLine().Replace(",","."));

            if( salario < 0.00){
                Console.WriteLine("Novo salario: 0.00");
                Console.WriteLine("Reajuste ganho: 0.00");
                Console.WriteLine("Em percentual: 0 %");        
            }
            else if (salario >= 0.00 && salario <= 400.00)
            {
                reajuste = salario * 0.15;
                novoSalario = salario + reajuste;

            percentual = 15;

            Console.WriteLine("Novo salario: {0:0.00}", novoSalario);
            Console.WriteLine("Reajuste ganho: {0:0.00}", reajuste);
            Console.WriteLine("Em percentual: {0} %", percentual);
            }
            else if (salario > 400.00 && salario <= 800.00)
            {
                reajuste = salario * 0.12;
                novoSalario = salario + reajuste;

            percentual = 12;

            Console.WriteLine("Novo salario: {0:0.00}", novoSalario);
            Console.WriteLine("Reajuste ganho: {0:0.00}", reajuste);
            Console.WriteLine("Em percentual: {0} %", percentual);
            }
            else if (salario > 800.00 && salario <= 1200.00)
            {
                reajuste = salario * 0.10;
                novoSalario = salario + reajuste;

             percentual = 10;

            Console.WriteLine("Novo salario: {0:0.00}", novoSalario);
            Console.WriteLine("Reajuste ganho: {0:0.00}", reajuste);
            Console.WriteLine("Em percentual: {0} %", percentual);
            }
            else if (salario > 1200.00 && salario <= 2000.00)
            {
                reajuste = salario * 0.07;
                novoSalario = salario + reajuste;

            percentual = 7;

            Console.WriteLine("Novo salario: {0:0.00}", novoSalario);
            Console.WriteLine("Reajuste ganho: {0:0.00}", reajuste);
            Console.WriteLine("Em percentual: {0} %", percentual);
            }
            else
            {
                reajuste = salario * 0.04;
                novoSalario = salario + reajuste;

            percentual = 4;

            Console.WriteLine("Novo salario: {0:0.00}", novoSalario);
            Console.WriteLine("Reajuste ganho: {0:0.00}", reajuste);
            Console.WriteLine("Em percentual: {0} %", percentual);
            }
        }
}