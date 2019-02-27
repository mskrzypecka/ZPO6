using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZPO6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ZPO6;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            AddressService adressService = new AddressService(connectionString);
            AccountService accountService = new AccountService(connectionString);
            DishService dishService = new DishService(connectionString);
            OrderService orderService = new OrderService(connectionString);

            var address = adressService.CreateAddress("Wroclaw", "Sezamkowa", 22, "12-234");
            var user = accountService.CreateUser("Malgosiek", "haslo", "Malgorzata", "Skrzypecka", "malgorzata.skrzypecka@gmail.com", "000111222", address);

            var dish = dishService.CreateDish("Nalesniki", 8, 10, true);
            var order = orderService.CreateOrder("Order1", user, dish);

            var dish2 = dishService.Create("Pierogi ruskie", 12, 17, true);

            var add = adressService.GetAll();

            foreach (var a in add)
            {
                Console.WriteLine($"{a.City}, {a.Street} {a.Number}, {a.ZipCode}");
            }

            dish2.Price = 9;
            dishService.Update(dish2);
            dishService.Delete(dish2);

            Console.ReadKey();
        }
    }
}
