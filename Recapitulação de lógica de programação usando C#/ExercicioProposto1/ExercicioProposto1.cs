using System;
using System.Globalization;
namespace ExercicioProposto1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Exercicio 1
            int num1, num2, soma;

            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());

            soma = num1 + num2;

            Console.WriteLine("SOMA = " + soma);

            //Exercicio 2
            double raio, area, pi = 3.14159;

            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = pi * raio * raio;

            Console.WriteLine("A=" + area.ToString("F4", CultureInfo.InvariantCulture));

            //Exercicio 3 
            int A, B, C, D, dif;

            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());
            C = int.Parse(Console.ReadLine());
            D = int.Parse(Console.ReadLine());

            dif = A * B - C * D;

            Console.WriteLine("DIFERENCA = " + dif);

            //Exercicio 4
            int numero, horas;
            double valorHora, salario;

            numero = int.Parse(Console.ReadLine());
            horas = int.Parse(Console.ReadLine());
            valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            salario = valorHora * horas;

            Console.WriteLine("NUMBER = " + numero);
            Console.WriteLine("SALARY = U$ " + salario.ToString("F2", CultureInfo.InvariantCulture));

            //Exercicio 5
            int cod1, cod2, qte1, qte2;
            double preco1, preco2, total;

            string[] valores = Console.ReadLine().Split(' ');
            cod1 = int.Parse(valores[0]);
            qte1 = int.Parse(valores[1]);
            preco1 = double.Parse(valores[2], CultureInfo.InvariantCulture);

            valores = Console.ReadLine().Split(' ');

            cod2 = int.Parse(valores[0]);
            qte2 = int.Parse(valores[1]);
            preco2 = double.Parse(valores[2], CultureInfo.InvariantCulture);

            total = preco1 * qte1 + preco2 * qte2;

            Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
            
            //Exercicio 6
            double valorA, valorB, valorC, triangulo, circulo, trapezio, quadrado, retangulo;

            string[] valore = Console.ReadLine().Split(' ');

            valorA = double.Parse(valore[0], CultureInfo.InvariantCulture);
            valorB = double.Parse(valore[1], CultureInfo.InvariantCulture);
            valorC = double.Parse(valore[2], CultureInfo.InvariantCulture);


            triangulo = valorA * valorC / 2.0;
            circulo = 3.14159 * valorC * valorC;
            trapezio = (valorA + valorB) / 2.0 * valorC;
            quadrado = valorB * valorB;
            retangulo = valorA * valorB;

            Console.WriteLine("TRIANGULO: " + triangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + circulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + trapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + quadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + retangulo.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
