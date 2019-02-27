using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZPO6._2.Modele;

namespace ZPO6._2.CRUD
{
    public class CRUD_Address : CRUD_DbConnection
    {
        public CRUD_Address(string connection) : base(connection)
        {
        }

        public int Create(Adres model)
        {
            throw new NotImplementedException();
        }

        public int Delete(Adres model)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Adres> GetAll()
        {
            throw new NotImplementedException();
        }

        public int Read(long id)
        {
            throw new NotImplementedException();
        }

        public int Update(Adres model)
        {
            throw new NotImplementedException();
        }
    }
}
