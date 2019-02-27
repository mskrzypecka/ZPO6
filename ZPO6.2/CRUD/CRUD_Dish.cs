using System;
using System.Collections.Generic;
using System.Data;
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

        public int Create(Potrawa model)
        {
            int isVege = model.JestWege ? 1 : 0;
            return sql.ExecuteNonQuery($"INSERT INTO DANIE (ID, NAZWA, CENA, MOZLIWEZAMOWIENIA, JESTWEGE)"
                + $"VALUES ({model.ID}, '{model.Nazwa}', '{model.Cena}', {model.MozliweZamowienia}, {isVege})");
        }

        public Potrawa Read(long id)
        {
            IDataReader reader = sql.ExecuteQuery($"SELECT * FROM DANIE WHERE ID = {id}");

            if (reader.Read())
            {
                return new Potrawa
                {
                    ID = reader.GetInt64(0),
                    Nazwa = reader.GetString(1).Trim(),
                    Cena = reader.GetDecimal(2),
                    MozliweZamowienia = reader.GetInt32(3),
                    JestWege = reader.GetBoolean(4)
                };
            }
            return new Potrawa();
        }

        public int Update(Potrawa model)
        {
            int isVege = model.JestWege ? 1 : 0;
            return sql.ExecuteNonQuery($"UPDATE DANIE SET NAZWA='{model.Nazwa}', CENA={model.Cena}, MOZLIWEZAMOWIENIA={model.MozliweZamowienia}, JESTWEGE={isVege} WHERE ID={model.ID}");
        }

        public int Delete(Potrawa model)
            => sql.ExecuteNonQuery($"DELETE FROM DANIE WHERE ID={model.ID}");

        public List<Potrawa> GetAll()
        {
            List<Potrawa> result = new List<Potrawa>();

            using (IDataReader reader = sql.ExecuteQuery("SELECT * FROM DANIE"))
                while (reader.Read())
                {
                    var potrawa = new Potrawa
                    {
                        ID = reader.GetInt64(0),
                        Nazwa = reader.GetString(1).Trim(),
                        Cena = reader.GetDecimal(2),
                        MozliweZamowienia = reader.GetInt32(3),
                        JestWege = reader.GetBoolean(4)
                    };
                    result.Add(potrawa);
                }
            return result;
        }
    }
}
