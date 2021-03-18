using System; 

public class CalculoCrescimentoPopulacional {

    public static void Main(string[] args)
        {

            int t = Convert.ToInt32(Console.ReadLine());
            int pa, pb;
            double cpa, cpb, g1, g2;
            int anos;

            for (int i = 0; i < t; i++)
            {
                anos = 0;
                string[] valores = Console.ReadLine().Split(' ');
                pa = int.Parse(valores[0]);
                pb = int.Parse(valores[1]);
         
                g1 = double.Parse(valores[2]);
                g2 = double.Parse(valores[3]);

                while (cpa <= cpb)
                {
                    cpa = Math.Floor(cpa * ((g1 / 100) + 1.0));
                    cpb = Math.Floor(cpb * ((g2 / 100) + 1.0));

                    anos++;
                    //complete o while

                    if (anos > 100)
                    {
                        Console.WriteLine("Mais de 1 seculo.");
                        break;
                    }
                }

                if (anos <= 100)
                {
                    Console.WriteLine("{0:0} anos.", anos);
                }
            }
        }
    }