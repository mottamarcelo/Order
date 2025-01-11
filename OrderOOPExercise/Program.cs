using Course.Entities;
using Course.Entities.Enums;
using System;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Runtime.Intrinsics.Arm;

namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth Date: ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());

            Client client = new Client(name, email, birthDate);

            Order order = new Order(DateTime.Now, status, client);  

            for (int i = 1; i <= n; i++)
            {
                Product prod = new Product();
                OrderItem item = new OrderItem();
                Console.WriteLine("Enter #" + i + " item data:");
                Console.Write("Product name: ");
                prod.Name = Console.ReadLine();
                Console.Write("Product price: ");
                prod.Price = double.Parse(Console.ReadLine());
                item.Price = prod.Price;
                Console.Write("Quantity: ");
                item.Quantity = int.Parse(Console.ReadLine());
                item.Product = prod;

                order.AddItem(item);

            }
            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY:");
            Console.WriteLine(order);
        }
    }
}