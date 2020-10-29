using ExercicioPropostoComposicao.Entities;
using ExercicioPropostoComposicao.Entities.Enums;
using System;
using System.Globalization;

namespace ExercicioPropostoComposicao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Enter order data: ");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Client client = new Client(nome, email, birthDate);
            Order order = new Order(DateTime.Now, status, client);

            Console.Write("How many items to this order? ");
            int qtdItems = int.Parse(Console.ReadLine());

            for(int i = 1; i <= qtdItems; i++)
            {
                Console.WriteLine("Enter #"+i+" item data: ");
                Console.Write("Product Name: ");
                string productName = Console.ReadLine();
                Console.Write("Product Price: ");
                double productPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Product product = new Product(productName, productPrice);

                Console.Write("Quantity: ");
                int productQuantity = int.Parse(Console.ReadLine());

                OrderItem orderItem = new OrderItem(productQuantity, productPrice, product);
                order.addItem(orderItem);
            }

            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY:");
            Console.WriteLine(order);

            
        }
    }
}
