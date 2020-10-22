using System;
using System.Globalization;

namespace ExercicioProposto2
{
    class Program
    {
        static void Main(string[] args)
        {

            //Exercicio 1

            int num = int.Parse(Console.ReadLine());
            if (num >= 0)
            {
                Console.WriteLine("NAO NEGATIVO");
            }
            else
            {
                Console.WriteLine("NEGATIVO");
            }

            //Exercicio 2

            int num1 = int.Parse(Console.ReadLine());

            if (num1 % 2 == 0)
            {
                Console.WriteLine("PAR");
            }
            else
            {
                Console.WriteLine("IMPAR");
            }

            //Exercicio 3

            string[] valores = Console.ReadLine().Split(' ');
            int a, b;
            a = int.Parse(valores[0]);
            b = int.Parse(valores[1]);

            if (a % b == 0 || b % a == 0)
            {
                Console.WriteLine("Sao Multiplos");
            }
            else
            {
                Console.WriteLine("Nao Sao Multiplos");
            }


            //Exercicio 4

            string[] valores = Console.ReadLine().Split(' ');
            int horaInicial = int.Parse(valores[0]);
            int horaFinal = int.Parse(valores[1]);
            int horasJogadas;


            if (horaInicial < horaFinal)
            {
                horasJogadas = horaFinal - horaInicial;
                Console.WriteLine("O JOGO DUROU " + horasJogadas + " HORA(S)");
            }
            else
            {
                horasJogadas = 24 - horaInicial + horaFinal;
                Console.WriteLine("O JOGO DUROU " + horasJogadas + " HORA(S)");
            }


            //Exercicio 5

            string[] valores = Console.ReadLine().Split(' ');
            int codItem = int.Parse(valores[0]);
            int qtdItem = int.Parse(valores[1]);
            double total;

            if (codItem == 1)
            {
                total = qtdItem * 4.00;
            }
            else if (codItem == 2)
            {
                total = qtdItem * 4.50;
            }
            else if (codItem == 3)
            {
                total = qtdItem * 5.00;
            }
            else if (codItem == 4)
            {
                total = qtdItem * 2.00;
            }
            else
            {
                total = qtdItem * 1.50;
            }

            Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));


            //Exercicio 6

            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (valor >= 0 && valor <= 25)
            {
                Console.WriteLine("Intervalo [0,25]");
            }
            else if (valor > 25 && valor <= 50)
            {
                Console.WriteLine("Intervalo (25,50]");
            }
            else if (valor > 50 && valor <= 75)
            {
                Console.WriteLine("Intervalo (50,75]");
            }
            else if (valor > 75 && valor <= 100)
            {
                Console.WriteLine("Intervalo (75,100]");
            }
            else
            {
                Console.WriteLine("Fora de intervalo");
            }


            //Exercicio 7

            string[] valores = Console.ReadLine().Split(' ');
            float x, y;
            x = float.Parse(valores[0], CultureInfo.InvariantCulture);
            y = float.Parse(valores[1], CultureInfo.InvariantCulture);

            if (x > 0 && y > 0)
            {
                Console.WriteLine("Q1");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("Q2");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("Q3");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("Q4");
            }
            else
            {
                Console.WriteLine("Origem");
            }


            //Exercicio 8

            double salario, imposto;

            salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (salario <= 2000.00)
            {
                imposto = 0.00;
            }
            else if (salario <= 3000.00)
            {
                imposto = (salario - 2000.0) * 0.08;
            }
            else if (salario <= 4500.00)
            {
                imposto = (salario - 3000.0) * 0.18 + 1000.0 * 0.08;
            }
            else
            {
                imposto = (salario - 4500.0) * 0.28 + 1500.0 * 0.18 + 1000.0 * 0.08;
            }

            if (imposto == 0)
                Console.WriteLine("Isento");
            else
                Console.WriteLine("R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture));
        }

    }
}
