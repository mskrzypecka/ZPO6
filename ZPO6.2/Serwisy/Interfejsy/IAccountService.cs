using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZPO6._2.Modele;

namespace ZPO6._2
{
    public interface IAccountService
    {
        Uzytkownik CreateUser(string Loggin, string password, string firstname, string lastname, string email, string phone, AdresZamieszkania address);
        void ChangePassword(Uzytkownik user, string password);
        void ChangeAdress(AdresZamieszkania model);
        void DeleteUser(Uzytkownik user);
        List<Uzytkownik> SelectAllUsers();
    }
}
