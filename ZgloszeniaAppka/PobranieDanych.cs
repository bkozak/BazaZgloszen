using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZgloszeniaAppka
{
    class PobranieDanych
    {
        private string _sql;
        public static List<Zgloszenia> Lista;
        public static List<Uzytkownicy> listaUzytkownikow;
        private readonly CultureInfo _pl = new CultureInfo("pl-PL");

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
                                UzytkownikID = (int)reader[6],
                                UzytkownikImie = WyszukajUsera((int)reader[6]),
                                Uzytkownicy = listaUzytkownikow[listaUzytkownikow.FindIndex(c => c.UzytkownikID == (int)reader[6])]
                                
                            };
                            Lista.Add(zgloszonko);
                        }
                    }
                }
                conn.Close();
            }
        }

        public string WyszukajUsera(int id)
        {
            var ind = listaUzytkownikow.FindIndex(u => u.UzytkownikID == id);
            return listaUzytkownikow[ind].Imie + " " + listaUzytkownikow[ind].Nazwisko;
        }

        public void PobieranieWszystkiegoUzytkownicy()
        {
            using (var conn = new SqlConnection(ConfigurationManager
                .ConnectionStrings["ZgloszeniaAppka.Properties.Settings.BazaZgloszenConnectionString"]
                .ConnectionString))
            {
                _sql = "SELECT *  FROM Uzytkownicy";
                conn.Open();
                PobranieDanych.listaUzytkownikow = new List<Uzytkownicy>();
                using (var command = new SqlCommand(_sql, conn))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var uzytkownik = new Uzytkownicy
                            {
                                UzytkownikID = (int)reader[0],
                                Imie = reader[1].ToString(),
                                Nazwisko = reader[2].ToString(),
                                Firma = reader[3].ToString(),
                                ImieNazwisko = reader[1].ToString() + " " + reader[2].ToString()
                            };

                            listaUzytkownikow.Add(uzytkownik);
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
                _sql = "UPDATE Zgloszenia SET Tytul=@tytul, Opis=@opis WHERE ZgloszenieID=@zlecenieid";

                conn.Open();
                PobranieDanych.Lista = new List<Zgloszenia>();
                using (var command = new SqlCommand(_sql, conn))
                {
                    command.Parameters.AddWithValue("@zlecenieid", _id);
                    command.Parameters.AddWithValue("@tytul", _tytul);
                    command.Parameters.AddWithValue("@opis", _opis);
                    //command.Parameters.AddWithValue("@komentarz", "");
                    command.ExecuteNonQuery();
                }

                conn.Close();
            }
        }

        public void ZamknijZlecenie(int _id)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ZgloszeniaAppka.Properties.Settings.BazaZgloszenConnectionString"].ConnectionString))
            {
                _sql = "UPDATE Zgloszenia SET DataZamkniecia=@dataZ WHERE ZgloszenieID=@id";
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(_sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", _id);
                    cmd.Parameters.AddWithValue("@dataZ", DateTime.Now.ToString("g", _pl));
                    cmd.ExecuteNonQuery();
                }
                conn.Close();


                var index = PobranieDanych.Lista.FindIndex(c => c.ZgloszenieID == _id.ToString());
                PobranieDanych.Lista[index].DataZamkniecia = DateTime.Now.ToString("g", _pl);

            }
        }

        public void UsunZlecenie(int _id)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ZgloszeniaAppka.Properties.Settings.BazaZgloszenConnectionString"].ConnectionString))
            {
                _sql = "DELETE Zgloszenia WHERE ZgloszenieID=@id";
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(_sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", _id);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
                var itemToRemove = PobranieDanych.Lista.Single(r => r.ZgloszenieID == _id.ToString());
                PobranieDanych.Lista.Remove(itemToRemove);
            }
        }
    }
}
