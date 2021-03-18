using System; 

public class Bazinga {

	public static void Main(string[] args) { 

            int qtdTeste = int.Parse(Console.ReadLine());
            string jogadaSheldon, jogadaRaj;
            for (int i = 1; i <= qtdTeste; i++) //insira a variavel correta
            {
                string[] valores = Console.ReadLine().Split(' ');
                jogadaSheldon = valores[0].ToUpper();
                jogadaRaj = valores[1].ToUpper();
                if((jogadaSheldon == "TESOURA" && jogadaRaj == "PAPEL") || ( jogadaSheldon == "PAPEL" && jogadaRaj == "PEDRA") //complete a solução
                    || (jogadaSheldon == "PEDRA" && jogadaRaj == "LAGARTO") || ( jogadaSheldon == "LAGARTO" && jogadaRaj == "SPOCK")
                    || (jogadaSheldon == "SPOCK" && jogadaRaj == "TESOURA") || ( jogadaSheldon == "TESOURA" && jogadaRaj == "LAGARTO")
                    || ( jogadaSheldon == "PAPEL" && jogadaRaj == "SPOCK") || (jogadaSheldon == "LAGARTO" && jogadaRaj == "PAPEL")
				    || ( jogadaSheldon == "SPOCK" && jogadaRaj == "PEDRA") || ( jogadaSheldon == "PEDRA" && jogadaRaj == "TESOURA"))
                    Console.WriteLine("Caso #{0}: Bazinga!", i);                
                else if 
					((jogadaRaj == "TESOURA" && jogadaSheldon == "PAPEL") || ( jogadaRaj == "PAPEL" && jogadaSheldon == "PEDRA") //complete a solução
                    || (jogadaRaj == "PEDRA" && jogadaSheldon == "LAGARTO") || ( jogadaRaj == "LAGARTO" && jogadaSheldon == "SPOCK")
                    || (jogadaRaj == "SPOCK" && jogadaSheldon == "TESOURA") || ( jogadaRaj == "TESOURA" && jogadaSheldon == "LAGARTO")
                    || ( jogadaRaj == "PAPEL" && jogadaSheldon == "SPOCK") || (jogadaRaj == "LAGARTO" && jogadaSheldon == "PAPEL")
				    || ( jogadaRaj == "SPOCK" && jogadaSheldon == "PEDRA") || ( jogadaRaj == "PEDRA" && jogadaSheldon == "TESOURA"))   //complete a solucao
                    Console.WriteLine("Caso #{0}: Raj trapaceou!", i);
                else
					Console.WriteLine("Caso #{0}: De novo!", i);                
     		}

    }

}