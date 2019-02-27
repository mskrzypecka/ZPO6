using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZPO6._2.Modele
{
    public class Uzytkownik : IModel
    {
        public string Login { get; set; }
        public long ID { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Haslo { get; set; }
        public string Email { get; set; }
        public DateTime DataRejestracji { get; set; }
        public string NrTelefonu { get; set; }
        public Adres Adres { get; set; }
    }
}
