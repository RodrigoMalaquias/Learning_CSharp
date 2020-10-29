using System;
using System.Numerics;

namespace ExercicioDeFixacaoVetores
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] vect = new Student[10];

            int n = int.Parse(Console.ReadLine());
            int cont = 1;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Rent #"+cont+":");
                cont++;
                Console.Write("Name: "); 
                string Name = Console.ReadLine();
                Console.Write("Email: ");
                string Email = Console.ReadLine();
                Console.Write("Room: ");
                int Room = int.Parse(Console.ReadLine());
                vect[Room] = new Student { name = Name, email = Email , room = Room};
            }

            Console.WriteLine("Busy Rooms: ");
            for(int i = 0; i<10; i++)
            {
                if(vect[i] != null)
                    Console.WriteLine(i+": "+vect[i].name+", "+vect[i].email);

            }
        }
    }
}
