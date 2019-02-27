using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZPO6._2.CRUD;
using ZPO6._2.Modele;

namespace ZPO6._2
{
    class AddressService : IAddressService
    {
        CRUD_Address adres;

        public AddressService(string connection)
        {
            adres = new CRUD_Address(connection);
        }

        public void ChangeAdress(AdresZamieszkania model)
            => adres.Update(model);

        public void ChangeCity(AdresZamieszkania model, string miasto)
        {
            model.Miasto = miasto;
            adres.Update(model);
        }

        public AdresZamieszkania CreateAddress(AdresZamieszkania model)
        {
            model.ID = this.adres.GetAll().Count() > 0
                        ? this.adres.GetAll().Max(x => x.ID) + 1
                        : 1;

            adres.Create(model);
            return model;
        }

        public void DeleteAdress(AdresZamieszkania model)
            => adres.Delete(model);

        public AdresZamieszkania CreateAddress(string city, string street, int number, string postalCode)
        {
            AdresZamieszkania newAdres = new AdresZamieszkania();
            newAdres.Miasto = city;
            newAdres.Ulica = street;
            newAdres.Numer = number;
            newAdres.KodPocztowy = postalCode;
            newAdres.ID = this.adres.GetAll().Count() > 0
                        ? this.adres.GetAll().Max(x => x.ID) + 1
                        : 1;

            adres.Create(newAdres);

            return newAdres;
        }

        public List<AdresZamieszkania> SelectAllAdresses()
            => adres.GetAll();
    }
}
