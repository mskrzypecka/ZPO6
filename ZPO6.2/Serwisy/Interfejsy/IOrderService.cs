using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZPO6._2.Modele;

namespace ZPO6._2
{
    public interface IOrderService
    {
        void CreateOrder(Zamowienie model);
        void ChangeOrderName(Zamowienie model, string name);
        void DeleteOrder(Zamowienie model);
        List<Zamowienie> SelectAllOrderes();
    }
}
