using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZgloszeniaAppka
{
    class PobranieDanych
    {
        private string _sql;
        public static List<Zgloszenia> Lista;

        public void PobieranieWszystkiego()
        {
            using (var conn = new SqlConnection(ConfigurationManager
                .ConnectionStrings["ZgloszeniaAppka.Properties.Settings.BazaZgloszenConnectionString"]
                .ConnectionString))
            {
                _sql = "SELECT *  FROM Zgloszenia";
                conn.Open();
                PobranieDanych.Lista = new List<Zgloszenia>();
                using (var command = new SqlCommand(_sql, conn))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var zgloszonko = new Zgloszenia
                            {
                                ZgloszenieID = reader[0].ToString(),
                                Tytul = reader[1].ToString(),
                                Opis = reader[2].ToString(),
                                DataOtworzenia = reader[3].ToString(),
                                DataZamkniecia = reader[4].ToString(),
                                Komentarz = reader[5].ToString(),
                                Uzytkownikid = reader[6].ToString()
                            };
                            Lista.Add(zgloszonko);
                        }
                    }

                }

                conn.Close();
            }
        }

        public void UpdateObiektu(int _id, string _tytul, string _opis)
        {
            using (var conn = new SqlConnection(ConfigurationManager
                .ConnectionStrings["ZgloszeniaAppka.Properties.Settings.BazaZgloszenConnectionString"]
                .ConnectionString))
            {
                _sql = "UPDATE Zgloszenia SET Tytul=@tytul, Opis=@opis, Komentarz=@komentarz WHERE ZgloszenieID=@zlecenieid";


                conn.Open();
                PobranieDanych.Lista = new List<Zgloszenia>();
                using (var command = new SqlCommand(_sql, conn))
                {
                    command.Parameters.AddWithValue("@Tytul", _tytul);
                    command.Parameters.AddWithValue("@Opis", _opis);
                    command.Parameters.AddWithValue("@Opis", _opis);
                    command.ExecuteNonQuery();


                    //using (var reader = command.ExecuteReader())
                    //{
                    //    while (reader.Read())
                    //    {
                    //        var zgloszonko = new Zgloszenia
                    //        {
                    //            ZgloszenieID = reader[0].ToString(),
                    //            Tytul = reader[1].ToString(),
                    //            Opis = reader[2].ToString(),
                    //            DataOtworzenia = reader[3].ToString(),
                    //            DataZamkniecia = reader[4].ToString(),
                    //            Komentarz = reader[5].ToString(),
                    //            Uzytkownikid = reader[6].ToString()
                    //        };
                    //        Lista.Add(zgloszonko);
                    //    }
                    //}

                }

                conn.Close();
            }
        }
    }
}
