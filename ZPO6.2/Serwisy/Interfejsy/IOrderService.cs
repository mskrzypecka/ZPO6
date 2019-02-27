using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZPO6._2
{
    public interface IOrderService
    {
        void CreateOrder();
        void ChangeOrder();
        void DeleteOrder();
        void SelectAllOrders();
    }
}
