using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZPO6._2
{
    public class SqlConnector
    {
        string connection;

        public SqlConnector(string connection)
        {
            this.connection = connection;
        }

        public IDataReader ExecuteQuery(string query)
        {
            SqlConnection db = new SqlConnection(connection);
            db.Open();

            SqlCommand command = db.CreateCommand();
            command.CommandText = query;

            return command.ExecuteReader();
        }

        public int ExecuteNonQuery(string query)
        {
            SqlConnection db = new SqlConnection(connection);
            db.Open();

            SqlCommand command = db.CreateCommand();
            command.CommandText = query;

            return command.ExecuteNonQuery();
        }
    }
}
