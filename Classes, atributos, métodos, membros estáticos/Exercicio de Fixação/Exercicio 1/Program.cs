using System;
using System.Globalization;

namespace Exercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo x = new Retangulo();

            Console.WriteLine("Entre a largura e altura do retângulo: ");
            x.altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Área: "+x.Area().ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("Perímetro: "+x.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Diagonal: "+x.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
        
        }
    }
}
