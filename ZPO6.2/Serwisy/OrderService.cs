using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZPO6._2.CRUD;
using ZPO6._2.Modele;

namespace ZPO6._2
{
    class OrderService : IOrderService
    {
        CRUD_Order order;

        public OrderService(string connection)
        {
            order = new CRUD_Order(connection);
        }

        public void ChangeOrderName(Zamowienie model, string name)
        {
            model.Nazwa = name;
            order.Update(model);
        }

        public void CreateOrder(Zamowienie model)
            => order.Create(model);

        public void DeleteOrder(Zamowienie model)
            => order.Delete(model);

        public List<Zamowienie> SelectAllOrderes()
            => order.GetAll();

        public Zamowienie CreateOrder(string name, Uzytkownik user, Potrawa dish)
        {
            Zamowienie newZamowienie = new Zamowienie();
            newZamowienie.Nazwa = name;
            newZamowienie.Klient = user;
            newZamowienie.Danie = dish;
            newZamowienie.DataZamowienia = DateTime.Now.ToString();
            newZamowienie.ID = this.order.GetAll().Count() > 0
                        ? this.order.GetAll().Max(x => x.ID) + 1
                        : 1;

            order.Create(newZamowienie);
            return newZamowienie;
        }
    }
}
