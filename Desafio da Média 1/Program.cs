using System; 

public class CalculaMedia {

	public static void Main(string[] args)
    { 
			double A;
            double B;
            double media;
            A = Convert.ToDouble(Console.ReadLine().Replace(",","."));
            B = Convert.ToDouble(Console.ReadLine().Replace(",","."));
            
            double nota1 = Math.Round(A, 1);
            double nota2 = Math.Round(B, 1);
            
            media = (nota1*3.5 + nota2*7.5)/11;
            Console.WriteLine($"MEDIA = {(string.Format("{0:0.00000}",media))}");
    }
}