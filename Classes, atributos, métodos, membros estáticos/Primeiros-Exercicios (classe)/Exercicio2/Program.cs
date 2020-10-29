using System;
using System.Globalization;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario A, B;
            A = new Funcionario();
            B = new Funcionario();

            Console.WriteLine("Dados do primeiro funcionário:");
            Console.Write("Nome: ");
            A.nome = Console.ReadLine();
            Console.Write("Salário: ");
            A.salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do segundo funcionário:");
            Console.Write("Nome: ");
            B.nome = Console.ReadLine();
            Console.Write("Salário: ");
            B.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double SalarioMedio;

            SalarioMedio = (A.salario + B.salario) / 2.0;

            Console.WriteLine("Salário médio = "+SalarioMedio.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}
