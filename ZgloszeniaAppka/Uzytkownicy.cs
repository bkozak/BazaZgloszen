using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZgloszeniaAppka
{
    class Uzytkownicy
    {
        public Uzytkownicy()
        {
            this.Zgloszenia = new HashSet<Zgloszenia>();
        }
        public int UzytkownikID { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Firma { get; set; }
        public string ImieNazwisko { get; set; }

        public virtual ICollection<Zgloszenia> Zgloszenia { get; set; }
    }
}
