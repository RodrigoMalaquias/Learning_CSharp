using System;
using System.Globalization;

namespace EntradaDados
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com seu nome completo:");
            string nome = Console.ReadLine();
            
            Console.WriteLine("Quantos quartos tem na sua casa?");
            int quarto = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Entre com um preço de um produto:");
            double produto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre seu uúltimo nome, idade e altura (mesma linha):");
            string[] vet = Console.ReadLine().Split(' ');
            string a = vet[0];
            int b = int.Parse(vet[1]);
            double c = double.Parse(vet[2],CultureInfo.InvariantCulture);

            Console.WriteLine("\nSaída de dados:");

            Console.WriteLine(nome);
            Console.WriteLine(quarto);
            Console.WriteLine(produto.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c.ToString("F2",CultureInfo.InvariantCulture));


        }
    }
}
