using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZPO6._2.Modele
{
    class Danie
    {
        public long ID { get; set; }
        public string Nazwa { get; set; }
        public decimal Cena { get; set; }
        public int MozliweZamowienia { get; set; }
        public bool JestWege { get; set; }
    }
}
