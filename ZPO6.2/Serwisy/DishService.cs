using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZPO6._2.CRUD;
using ZPO6._2.Modele;

namespace ZPO6._2
{
    class DishService : IDishService
    {
        CRUD_Dish dish;

        public DishService(string connection)
        {
            dish = new CRUD_Dish(connection);
        }

        public void ChangeDishName(Potrawa model, string name)
        {
            model.Nazwa = name;
            dish.Update(model);
        }

        public void ChangeDishPrice(Potrawa model, decimal price)
        {
            model.Cena = price;
            dish.Update(model);
        }

        public void CreateDish(Potrawa model)
            => dish.Create(model);

        public void DeleteDish(Potrawa model)
            => dish.Delete(model);

        public List<Potrawa> SelectAllDishes()
            => dish.GetAll();

        public Potrawa CreateDish(string name, int price, int possible, bool isVege)
        {
            Potrawa model = new Potrawa();
            model.Nazwa = name;
            model.Cena = price;
            model.MozliweZamowienia = possible;
            model.JestWege = isVege;
            model.ID = this.dish.GetAll().Count() > 0
                        ? this.dish.GetAll().Max(x => x.ID) + 1
                        : 1;

            dish.Create(model);
            return model;
        }
    }
}
