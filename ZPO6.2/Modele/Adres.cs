using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZPO6._2.Modele
{
    public class Adres : IModel
    {
        public long ID { get; set; }
        public string Miasto { get; set; }
        public string Ulica { get; set; }
        public int Numer { get; set; }
        public string KodPocztowy { get; set; }
    }
}
