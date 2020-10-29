using System;
using System.Globalization;

namespace Exercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aln = new Aluno();
            Console.Write("Nome do aluno: ");
            aln.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno: ");
            aln.NotaPrimeiro = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            aln.NotaSegundo = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            aln.NotaTerceiro = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            aln.aprovacao();
        }
    }
}
