using System;
using System.Collections.Generic;
using System.Data;
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
            => sql.ExecuteNonQuery($"INSERT INTO ZAMOWIENIE (ID, NAZWA, DATAZAMOWIENIA, IDKLIENTA, IDDANIA) "
                + $"VALUES ({model.ID}, '{model.Nazwa}', '{DateTime.Now}', {model.Klient.ID}, {model.Danie.ID})");

        public Zamowienie Read(long id)
        {
            IDataReader reader = sql.ExecuteQuery($"SELECT * FROM ZAMOWIENIE WHERE ID = {id}");

            if (reader.Read())
            {
                return new Zamowienie
                {
                    ID = reader.GetInt64(0),
                    Nazwa = reader.GetString(1).Trim(),
                    DataZamowienia = reader.GetString(2),
                    Klient = new CRUD_User(connection).Read(reader.GetInt64(3)),
                    Danie = new CRUD_Dish(connection).Read(reader.GetInt64(4))
                };
            }

            return new Zamowienie();
        }

        public int Update(Zamowienie model)
            => sql.ExecuteNonQuery($"UPDATE ZAMOWIENIE SET NAZWA='{model.Nazwa}', IDKLIENTA={model.Klient.ID}, IDDANIA={model.Danie.ID} WHERE ID={model.ID}");

        public int Delete(Zamowienie model)
            => sql.ExecuteNonQuery($"DELETE FROM ZAMOWIENIE WHERE ID={model.ID}");

        public List<Zamowienie> GetAll()
        {
            List<Zamowienie> result = new List<Zamowienie>();

            using (IDataReader reader = sql.ExecuteQuery("SELECT * FROM ZAMOWIENIE"))
                while (reader.Read())
                {
                    var zamowienie = new Zamowienie
                    {
                        ID = reader.GetInt64(0),
                        Nazwa = reader.GetString(1).Trim(),
                        DataZamowienia = reader.GetString(2),
                        Klient = new CRUD_User(connection).Read(reader.GetInt64(3)),
                        Danie = new CRUD_Dish(connection).Read(reader.GetInt64(4))
                    };

                    result.Add(zamowienie);
                }
            return result;
        }
    }
}
