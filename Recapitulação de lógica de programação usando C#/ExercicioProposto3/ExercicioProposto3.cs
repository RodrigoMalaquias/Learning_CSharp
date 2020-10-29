using System;

namespace ExercicioProposto3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //Exercicio 1
            int senha = 2002, insercao ;

            insercao = int.Parse(Console.ReadLine());

            while (insercao != senha)
            {
                Console.WriteLine("Senha Invalida");
                insercao = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Acesso Permitido");
            */
            /*
            //Exercicio 2
            int x, y;
            string[] valores = Console.ReadLine().Split(' ');
            x = int.Parse(valores[0]);
            y = int.Parse(valores[1]);

            while (x != 0 && y != 0)
            {
                if (x>0 && y > 0)
                {
                    Console.WriteLine("Primeiro");                 
                }
                else if (x < 0 && y > 0)
                {
                    Console.WriteLine("Segundo");
                }
                else if (x < 0 && y < 0)
                {
                    Console.WriteLine("Terceiro");
                }
                else
                {
                    Console.WriteLine("Quarto");
                }
                valores = Console.ReadLine().Split(' ');
                x = int.Parse(valores[0]);
                y = int.Parse(valores[1]);
                */

            //Exercicio 3

            int alcool = 0,gasolina =0,diesel = 0,opcao;
            opcao = int.Parse(Console.ReadLine());
            if(opcao > 4 || opcao < 1)
            {
                while (opcao != 4)
                {
                    if(opcao == 1)
                    {
                        alcool++;
                    }
                    else if(opcao == 2)
                    {
                        gasolina++;
                    }
                    else if(opcao == 3)
                    {
                        diesel++;
                    }
                    opcao = int.Parse(Console.ReadLine());
                } 
            }
            Console.WriteLine("Muito Obrigado");
            Console.WriteLine("Alcool: "+alcool);
            Console.WriteLine("Gasolina: "+gasolina);
            Console.WriteLine("Diesel: "+diesel);

            }
        }
    }

