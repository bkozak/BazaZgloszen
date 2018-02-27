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
    class Zgloszenia
    {
        public string ZgloszenieID { get; set; }
        public string Tytul { get; set; }
        public string Opis { get; set; }
        public string DataOtworzenia { get; set; }
        public string DataZamkniecia { get; set; }
        public string Komentarz { get; set; }
        public string Uzytkownikid { get; set; }

        //public void PobierzDane()
        //{
        //    using (var conn = new SqlConnection(ConfigurationManager
        //        .ConnectionStrings["ZgloszeniaAppka.Properties.Settings.BazaZgloszenConnectionString"]
        //        .ConnectionString))
        //    {
        //        _sql = "SELECT *  FROM Zgloszenia WHERE (DataZamkniecia IS NULL or DataZamkniecia = '')";
        //        conn.Open();
        //        this.PobranaLista = new List<Zgloszenia>();
        //        using (var command = new SqlCommand(_sql, conn))
        //        {
        //            using (var reader = command.ExecuteReader())
        //            {
        //                while (reader.Read())
        //                {
        //                    var zgloszonko = new Zgloszenia();
        //                    zgloszonko.Tytul = reader[1].ToString();
        //                    PobranaLista.Add(zgloszonko);
        //                }
        //            }
                    
        //        }

        //        conn.Close();
        //    }


        //}
    }
}
