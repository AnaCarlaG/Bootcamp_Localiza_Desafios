using System; 

public class OrdenacaoInvertida {

	public static void Main(string[] args) { 

            string numeros = Console.ReadLine();

            Console.WriteLine("{0}\n",InverteOrdenacaoString(numeros));
    }
    	public static string InverteOrdenacaoString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
		}
}