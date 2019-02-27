using System;
using System.Collections.Generic;
using System.Data;
using ZPO6._2.Modele;

namespace ZPO6._2.CRUD
{
    public class CRUD_User : CRUD_DbConnection
    {
        public CRUD_User(string connection) : base(connection)
        {
        }

        public int Create(Uzytkownik model)
            => sql.ExecuteNonQuery($"INSERT INTO UZYTKOWNIK (Loggin, ID, Imie, Nazwisko, Haslo, Email, DataRejestracji, NrTelefonu, IDAdresu)"
                + $"VALUES('{model.Loggin}', {model.ID}, '{model.Imie}', '{model.Nazwisko}', "
                + $"'{model.Haslo}', '{model.Email}', '{DateTime.Now}', '{model.NrTelefonu}', {model.Adres.ID})");
        
        public Uzytkownik Read(long id)
        {
            IDataReader reader = sql.ExecuteQuery($"SELECT * FROM UZYTKOWNIK WHERE ID = {id}");

            if (reader.Read())
            {
                return new Uzytkownik
                {
                    Loggin = reader.GetString(0).Trim(),
                    ID = reader.GetInt64(1),
                    Imie = reader.GetString(2).Trim(),
                    Nazwisko = reader.GetString(3).Trim(),
                    Haslo = reader.GetString(4).Trim(),
                    Email = reader.GetString(5).Trim(),
                    DataRejestracji = reader.GetString(6),
                    NrTelefonu = reader.GetString(7).Trim(),
                    Adres = new CRUD_Address(connection).Read(reader.GetInt64(8))
                };
            }
            return new Uzytkownik();
        }

        public int Update(Uzytkownik model)
            => sql.ExecuteNonQuery($"UPDATE UZYTKOWNIK SET Loggin='{model.Loggin}', IMIE='{model.Imie}', NAZWISKO='{model.Nazwisko}', HASLO='{model.Haslo}', "
                + $"EMAIL='{model.Email}', DATAREJESTRACJI='{model.DataRejestracji}', NRTELEFONU='{model.NrTelefonu}', ADRESID={model.Adres.ID} WHERE ID={model.ID}");

        public int Delete(Uzytkownik model)
            => sql.ExecuteNonQuery($"DELETE FROM UZYTKOWNIK WHERE ID={model.ID}");

        public List<Uzytkownik> GetAll()
        {
            List<Uzytkownik> result = new List<Uzytkownik>();

            using (IDataReader reader = sql.ExecuteQuery("SELECT * FROM UZYTKOWNIK"))
                while (reader.Read())
                {
                    var uzytkownk = new Uzytkownik
                    {
                        Loggin = reader.GetString(0).Trim(),
                        ID = reader.GetInt64(1),
                        Imie = reader.GetString(2).Trim(),
                        Nazwisko = reader.GetString(3).Trim(),
                        Haslo = reader.GetString(4).Trim(),
                        Email = reader.GetString(5).Trim(),
                        DataRejestracji = reader.GetString(6),
                        NrTelefonu = reader.GetString(7).Trim()
                    };
                    
                    uzytkownk.Adres = new CRUD_Address(connection).Read(reader.GetInt64(8));
                    result.Add(uzytkownk);
                }

            return result;
        }
    }
}
