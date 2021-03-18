using System;

public class Multiplos {
	public static void Main(string[] args) {
		int multiplo2 = 0;
		int multiplo3 = 0;
		int multiplo4 = 0;
		int multiplo5 = 0;

		int tamnhoLista = int.Parse(Console.ReadLine());
		string[] listaNumero = Console.ReadLine().Split(' ');
		int[] listaConvertida = new int[tamnhoLista];

		for (int i = 0; i < listaNumero.Length; i++) {
			var inteiro = int.Parse(listaNumero[i]);
			listaConvertida[i] = inteiro;
		}

		for (int i = 0; i < tamnhoLista; i++) {
			if (listaConvertida[i] % 2 == 0) {
				multiplo2++;
			}
		}
		for (int i = 0; i < tamnhoLista; i++) {
			if (listaConvertida[i] % 3 == 0) {
				multiplo3++;
			}
		}
		for (int i = 0; i < tamnhoLista; i++) {
			if (listaConvertida[i] % 4 == 0) {
				multiplo4++;
			}
		}
		for (int i = 0; i < tamnhoLista; i++) {
			if (listaConvertida[i] % 5 == 0) {
				multiplo5++;
			}
		}
		Console.WriteLine("{0} Multiplo(s) de 2", multiplo2);
		Console.WriteLine("{0} Multiplo(s) de 3", multiplo3);
		Console.WriteLine("{0} Multiplo(s) de 4", multiplo4);
		Console.WriteLine("{0} Multiplo(s) de 5", multiplo5);
	}
}