using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZPO6._2
{
    public class SqlConnection
    {
        string connection;

        public SqlConnection(string connection)
        {
            this.connection = connection;
        }

        public IDataReader ExecuteQuery(string query)
        {
            IDataReader reader;

            using (var db = new System.Data.SqlClient.SqlConnection(connection))
            {
                db.Open();
                var command = db.CreateCommand();
                command.CommandText = query;
                reader = command.ExecuteReader();
            }
            return reader;
        }

        public int ExecuteNonQuery(string query)
        {
            int result;

            using (var db = new System.Data.SqlClient.SqlConnection(connection))
            {
                db.Open();
                var command = db.CreateCommand();
                command.CommandText = query;
                result = command.ExecuteNonQuery();
            }
            return result;
        }
    }
}
