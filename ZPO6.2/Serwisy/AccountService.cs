using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZPO6._2.CRUD;
using ZPO6._2.Modele;

namespace ZPO6._2
{
    class AccountService : IAccountService
    {
        CRUD_User user;
        CRUD_Address adres;

        public AccountService(string connection)
        {
            user = new CRUD_User(connection);
            adres = new CRUD_Address(connection);
        }

        public void ChangeAdress(AdresZamieszkania model) => adres.Update(model);

        public void ChangePassword(Uzytkownik user, string password)
        {
            user.Haslo = password;
            this.user.Update(user);
        }

        public Uzytkownik CreateUser(string login, string password, string firstname, string lastname, string email, string phone, AdresZamieszkania address)
        {
            long id = this.user.GetAll().Count() > 0 
                        ? this.user.GetAll().Max(x => x.ID) + 1 
                        : 1;

            var customer = new Uzytkownik
            {
                ID = id,
                Login = login,
                Haslo = password,
                Imie = firstname,
                Nazwisko = lastname,
                Email = email,
                NrTelefonu = phone,
                Adres = address,
                DataRejestracji = DateTime.Now
            };
            this.user.Create(customer);

            return customer;
        }

        public void DeleteUser(Uzytkownik user) => this.user.Delete(user);

        public List<Uzytkownik> SelectAllUsers() => user.GetAll();
    }
}
