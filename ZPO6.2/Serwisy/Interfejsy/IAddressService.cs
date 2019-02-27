using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZPO6._2.Modele;

namespace ZPO6._2
{
    public interface IAddressService
    {
        void ChangeAdress(AdresZamieszkania model);
        void ChangeCity(AdresZamieszkania model, string miasto);
        AdresZamieszkania CreateAddress(AdresZamieszkania model);
        void DeleteAdress(AdresZamieszkania model);
        List<AdresZamieszkania> SelectAllAdresses();
        AdresZamieszkania CreateAddress(string city, string street, int number, string postalCode);
    }
}
