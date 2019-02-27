using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZPO6._2.Modele;

namespace ZPO6._2.CRUD
{
    public class CRUD_Order : CRUD_DbConnection
    {
        public CRUD_Order(string connection) : base(connection)
        {
        }

        public int Create(Zamowienie model)
        {
            throw new NotImplementedException();
        }

        public int Delete(Zamowienie model)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Zamowienie> GetAll()
        {
            throw new NotImplementedException();
        }

        public int Read(long id)
        {
            throw new NotImplementedException();
        }

        public int Update(Zamowienie model)
        {
            throw new NotImplementedException();
        }
    }
}
