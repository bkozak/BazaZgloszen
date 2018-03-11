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
        public int UzytkownikID { get; set; }
        public string UzytkownikImie { get; set; }

        public virtual Uzytkownicy Uzytkownicy { get; set; } 
    }
}
