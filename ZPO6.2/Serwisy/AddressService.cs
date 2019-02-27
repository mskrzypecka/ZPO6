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

        public void CreateAddress(AdresZamieszkania model)
            => adres.Create(model);

        public void DeleteAdress(AdresZamieszkania model)
            => adres.Delete(model);

        public List<AdresZamieszkania> SelectAllAdresses()
            => adres.GetAll();
    }
}
