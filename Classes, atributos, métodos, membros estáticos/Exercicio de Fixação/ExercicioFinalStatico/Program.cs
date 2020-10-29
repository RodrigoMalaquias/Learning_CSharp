using System;
using System.Globalization;

namespace ExercicioFinalStatico
{
    class Program
    {
        static void Main(string[] args)
        {
            double CotacaoDolar, PagamentoDolar;
            Console.Write("Qual é a cotação do dólar: ");
            CotacaoDolar = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("Quantos dólares você vai comprar: ");
            PagamentoDolar = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            double resultado = ConversorDeMoeda.ConversorMoeda(CotacaoDolar, PagamentoDolar);

            Console.Write("Valor a ser pago em reais: " + resultado.ToString("F2",CultureInfo.InvariantCulture);

        }
    }
}
