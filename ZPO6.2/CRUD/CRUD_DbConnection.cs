using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZPO6._2.Modele;

namespace ZPO6._2.CRUD
{
    public class CRUD_DbConnection
    {
        protected SqlConnector sql;
        protected string connection;

        public CRUD_DbConnection(string connection)
        {
            this.connection = connection;
            sql = new SqlConnector(connection);
        }
    }
}
