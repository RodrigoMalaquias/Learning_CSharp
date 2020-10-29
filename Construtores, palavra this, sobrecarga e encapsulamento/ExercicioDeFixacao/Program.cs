using System;
using System.Globalization;

namespace ExercicioDeFixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            ClienteBancario cliente;

            Console.Write("Entre o número da conta: ");
            int numeroConta = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Entre o número do titular: ");
            string titular = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)? ");
            char resposta = Console.ReadLine()[0];
            
            if (resposta == 's')
            {
                Console.Write("Entre o valor de depósito inicial: ");
                double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                cliente = new ClienteBancario(numeroConta, titular, deposito);
                Console.WriteLine();
            }
            else
            {
                cliente = new ClienteBancario(numeroConta, titular);
            }

            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(cliente);
            Console.WriteLine();

            Console.Write("Entre um valor para depósito: ");
            cliente.Deposito(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(cliente);
            Console.WriteLine();

            Console.Write("Entre um valor para saque: ");
            cliente.Saque(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(cliente);
        }
    }
}
