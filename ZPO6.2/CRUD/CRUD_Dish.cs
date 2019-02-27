using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZPO6._2.Modele;

namespace ZPO6._2.CRUD
{
    public class CRUD_Dish : CRUD_DbConnection
    {
        public CRUD_Dish(string connection) : base(connection)
        {
        }

        public int Create(Danie model)
        {
            throw new NotImplementedException();
        }

        public int Delete(Danie model)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Danie> GetAll()
        {
            throw new NotImplementedException();
        }

        public int Read(long id)
        {
            throw new NotImplementedException();
        }

        public int Update(Danie model)
        {
            throw new NotImplementedException();
        }
    }
}
