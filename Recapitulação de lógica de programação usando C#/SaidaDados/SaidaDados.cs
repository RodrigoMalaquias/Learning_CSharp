﻿using System;
using System.Globalization;

namespace SaidaDados
{
    class Program
    {
        static void Main(string[] args)
        {
            string produto1 = "Computador";
            string produto2 = "Mesa de Escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("Produtos:");
            Console.WriteLine($"{produto1}, cujo preço é $ {preco1:F2}");
            Console.WriteLine("{0}, cujo preço é $ {1:F2}\n",produto2,preco2);
            
            Console.WriteLine("Registro: "+idade+" anos de idade, código "+codigo+" e gênero: "+genero+"\n");

            Console.WriteLine($"Medida com oito casas decimais: {medida:F8}");
            Console.WriteLine("Arredondando (três casas decimais): {0:F3}",medida);
            Console.WriteLine("Separador decimal invariant culture: "+medida.ToString("F3",CultureInfo.InvariantCulture));
        }
    }
}
