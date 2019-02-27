using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZPO6._2.Modele;

namespace ZPO6._2.CRUD
{
    public class CRUD_User : CRUD_DbConnection
    {
        public CRUD_User(string connection) : base(connection)
        {
        }

        public int Create(Uzytkownik model)
        {
            throw new NotImplementedException();
        }

        public int Delete(Uzytkownik model)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Uzytkownik> GetAll()
        {
            throw new NotImplementedException();
        }

        public int Read(long id)
        {
            throw new NotImplementedException();
        }

        public int Update(Uzytkownik model)
        {
            throw new NotImplementedException();
        }
    }
}
