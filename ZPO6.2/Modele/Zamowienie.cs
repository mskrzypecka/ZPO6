using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZPO6._2.Modele
{
    class Zamowienie
    {
        public long OrderID { get; set; }
        public string Nazwa { get; set; }
        public DateTime DataZamowienia { get; set; }
        public Uzytkownik Klient { get; set; }
        public Danie Danie { get; set; }
    }
}
