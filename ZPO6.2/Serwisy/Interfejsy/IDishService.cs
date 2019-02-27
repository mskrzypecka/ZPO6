﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZPO6._2.Modele;

namespace ZPO6._2
{
    public interface IDishService
    {
        void CreateDish(Potrawa model);
        void ChangeDishName(Potrawa model, string name);
        void ChangeDishPrice(Potrawa model, decimal price);
        void DeleteDish(Potrawa model);
        List<Potrawa> SelectAllDishes();
    }
}
