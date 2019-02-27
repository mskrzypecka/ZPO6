using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZPO6._2.Modele;

namespace ZPO6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = ZPO6; Integrated Security = True";

            AddressService adressService = new AddressService(connectionString);
            AccountService accountService = new AccountService(connectionString);
            DishService dishService = new DishService(connectionString);
            OrderService orderService = new OrderService(connectionString);

            AdresZamieszkania address = adressService.CreateAddress("Wroclaw", "Sezamkowa", 22, "12-234");
            Uzytkownik user = accountService.CreateUser("Malgosiek", "haslo", "Malgorzata", "Skrzypecka", "malgorzata.skrzypecka@gmail.com", "000111222", address);

            Potrawa pancakes = dishService.CreateDish("Nalesniki", 8, 10, true);
            Zamowienie order1 = orderService.CreateOrder("Zamowienie nalesnikow 1", user, pancakes);
            dishService.ChangeDishPrice(pancakes, 15);
            Zamowienie order2 = orderService.CreateOrder("Zamowienie nalesnikow 2", user, pancakes);
            Potrawa pizza = dishService.CreateDish("Pizza", 22, 10, true);
            Zamowienie order3 = orderService.CreateOrder("Zamowienie pizzy 1", user, pizza);

            var orders = orderService.SelectAllOrderes();

            foreach (var order in orders)
            {
                Console.WriteLine($"{order.DataZamowienia}: {order.Nazwa}: {order.Danie.Nazwa}: {order.Danie.Cena.ToString("0.##")}zl");
            }

            Console.ReadKey();
        }
    }
}
