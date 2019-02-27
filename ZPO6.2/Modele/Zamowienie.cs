using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZPO6._2.Modele
{
    public class Zamowienie : IModel
    {
        public long ID { get; set; }
        public string Nazwa { get; set; }
        public string DataZamowienia { get; set; }
        public Uzytkownik Klient { get; set; }
        public Potrawa Danie { get; set; }
    }
}
