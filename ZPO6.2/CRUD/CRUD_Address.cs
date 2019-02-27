using System;
using System.Collections.Generic;
using System.Data;
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

        public int Create(AdresZamieszkania model)
            => sql.ExecuteNonQuery($"INSERT INTO ADRES (ID, Miasto, Ulica, Numer, KodPocztowy)"
                + $"VALUES ({model.ID}, '{model.Miasto}', '{model.Ulica}', '{model.Numer}', '{model.KodPocztowy}')";

        public AdresZamieszkania Read(long id)
        {
            IDataReader reader = sql.ExecuteQuery($"SELECT * FROM ADRESZAMIESZKANIA WHERE ID = {id}");

            if (reader.Read())
            {
                return new AdresZamieszkania
                {
                    ID = reader.GetInt64(0),
                    Miasto = reader.GetString(1).Trim(),
                    Ulica = reader.GetString(2),
                    Numer = reader.GetInt32(3),
                    KodPocztowy = reader.GetString(4)
                };
            }

            return new AdresZamieszkania();
        }

        public int Update(AdresZamieszkania model)
            => sql.ExecuteNonQuery($"UPDATE ADRESZAMIESZKANIA SET MIASTO='{model.Miasto}', ULICA='{model.Ulica}', NUMER='{model.Numer}', KODPOCZTOWY='{model.KodPocztowy}' WHERE ID={model.ID}");

        public int Delete(AdresZamieszkania model)
            => sql.ExecuteNonQuery($"DELETE FROM ADRESZAMIESZKANIA WHERE ID={model.ID}");

        public List<AdresZamieszkania> GetAll()
        {
            List<AdresZamieszkania> result = new List<AdresZamieszkania>();

            using (IDataReader reader = sql.ExecuteQuery("SELECT * FROM ADRESZAMIESZKANIA"))
                while (reader.Read())
                {
                    var AdresZamieszkania = new AdresZamieszkania
                    {
                        ID = reader.GetInt64(0),
                        Miasto = reader.GetString(1).Trim(),
                        Ulica = reader.GetString(2),
                        Numer = reader.GetInt32(3),
                        KodPocztowy = reader.GetString(4)
                    };
                }
            return result;
        }
    }
}
