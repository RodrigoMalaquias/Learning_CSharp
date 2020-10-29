using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExercicioDeFixacaoLista
{
    class Program
    {
        static void Main(string[] args)
        {
      
            Console.Write("How many employees will be registred? ");
            int n = int.Parse(Console.ReadLine());
            List<Employee> list = new List<Employee>();

            for (int i = 1; i<=n; i++)
            {
                Console.WriteLine("Employee #" + i + ":");
                Console.Write("Id: ");
                int Id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string Name = Console.ReadLine();
                Console.Write("Salary: ");
                double Salary = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                list.Add(new Employee(Id, Name, Salary));
                Console.WriteLine();
            }

            Console.Write("Enter the employee id that will have salary increase : ");
            int IdRequested = int.Parse(Console.ReadLine());
            Employee emp = list.Find(x => x.Id == IdRequested);
            if (emp != null)
            {
                Console.Write("Enter the percentage: ");
                double Percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.increaseSalary(Percentage);
            }
            else
            {
                Console.WriteLine("This id does not exist!");
            }
            Console.WriteLine();

            Console.WriteLine("Updated list of employees:");
            foreach (Employee obj in list)
            {
                Console.WriteLine(obj);
            }
}
    }
}
