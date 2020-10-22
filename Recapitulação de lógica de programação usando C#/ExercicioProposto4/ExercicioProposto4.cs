using System;
using System.Globalization;

namespace ExercicioProposto4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercicio 1
            int num;
            num = int.Parse(Console.ReadLine());
            for (int x = 1; x <= num; x++)
            {
                if (x % 2 == 1)
                    Console.WriteLine(x);
            }


            //Exercicio 2
            int numero, valores, dentro = 0, fora = 0;
            numero = int.Parse(Console.ReadLine());

            for (int x = 1; x <= numero; x++)
            {
                valores = int.Parse(Console.ReadLine());
                if (valores >= 10 && valores <= 20)
                {
                    dentro++;
                }
                else
                {
                    fora++;
                }
            }
            Console.WriteLine(dentro + " in");
            Console.WriteLine(fora + " out");


            //Exercicio 3
            int n;

            n = int.Parse(Console.ReadLine());

            for (int x = 0; x < n; x++)
            {
                string[] testes = Console.ReadLine().Split(' ');
                double a = double.Parse(testes[0], CultureInfo.InvariantCulture);
                double b = double.Parse(testes[1], CultureInfo.InvariantCulture);
                double c = double.Parse(testes[2], CultureInfo.InvariantCulture);

                double mediaPonderada = (a * 2.0 + b * 3.0 + c * 5.0) / 10.0;

                Console.WriteLine(mediaPonderada.ToString("F1", CultureInfo.InvariantCulture));
            }

            //Exercicio 4
            int numTeste = int.Parse(Console.ReadLine());

            for (int x = 0; x < numTeste; x++)
            {
                string[] teste = Console.ReadLine().Split(' ');
                double numerador = double.Parse(teste[0]);
                double denomidaor = double.Parse(teste[1]);

                if (denomidaor == 0)
                {
                    Console.WriteLine("divisao impossivel");
                }
                else
                {
                    double divisao = numerador / denomidaor;
                    Console.WriteLine(divisao.ToString("F1", CultureInfo.InvariantCulture));
                }
            }

            //Exercicio 5
            int testeFat = int.Parse(Console.ReadLine());
            int fatorial = 1;

            for (int x = testeFat; x > 1; x--)
            {
                fatorial *= x;
            }

            Console.WriteLine(fatorial);

            //Exercicio 6

            int numDiv = int.Parse(Console.ReadLine());

            for (int x = 1; x <= numDiv; x++)
            {
                if (numDiv % x == 0)
                    Console.WriteLine(x);
            }

            //Exercicio 7
            int z = int.Parse(Console.ReadLine());

            for (int x = 1; x <= z; x++)
            {
                Console.WriteLine(x + " " + Math.Pow(x, 2) + " " + Math.Pow(x, 3));
            }
        }

    }
}