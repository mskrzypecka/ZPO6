using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZPO6._2
{
    public interface IDishService
    {
        void CreateDish();
        void ChangeDishName();
        void ChangeDishPrice();
        void DeleteDish();
        void SelectAllDishes();
    }
}
