using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZgloszeniaAppka
{
    public partial class Form1 : Form
    {
        private CultureInfo pl = new CultureInfo("pl-PL");
        string _sql;
        int _id = 0;
        SqlDataAdapter _adapt;
        DataTable _dt;
        public Form1()
        {
            InitializeComponent();
            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bazaZgloszenDataSet.Zgloszenia' table. You can move, or remove it, as needed.
            //zgloszeniaTableAdapter.Fill(this.bazaZgloszenDataSet.Zgloszenia);     
            var pobierz = new PobranieDanych();
            pobierz.PobieranieWszystkiegoUzytkownicy();
            pobierz.PobieranieWszystkiego();
            dataGridView1.DataSource = PobranieDanych.Lista;
            UstawienieDataGrida();

            //BindingSource bs = new BindingSource();
            //bs.DataSource = typeof(Zgloszenia);
            //dataGridView1.DataSource = bs;
            //dataGridView1.AutoGenerateColumns = true;


        }

        private void UstawienieDataGrida()
        {
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[8].Visible = false;
        }

        private void znajdz_tb_TextChanged(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ZgloszeniaAppka.Properties.Settings.BazaZgloszenConnectionString"].ConnectionString))
            {
                _sql = "select * from Zgloszenia where Tytul like '" + znajdz_tb.Text + "%'";
                conn.Open();

                _adapt = new SqlDataAdapter(_sql, conn);
                _dt = new DataTable();
                _adapt.Fill(_dt);
                dataGridView1.DataSource = _dt;

                conn.Close();

            }            
        }

        private void nowe_btn_Click(object sender, EventArgs e)
        {
            Nowe nowezgl = new Nowe();
            nowezgl.Closed += nowezgl_Closed;
            nowezgl.ShowDialog(this);
        }

        //private void DisplayData()
        //{
        //    using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ZgloszeniaAppka.Properties.Settings.BazaZgloszenConnectionString"].ConnectionString))
        //    {
        //        conn.Open();
        //        DataTable dt = new DataTable();
        //        _adapt = new SqlDataAdapter("SELECT ZgloszenieID, Tytul, Opis, Komentarz, UzytkownikID  FROM Zgloszenia", conn);
        //        _adapt.Fill(dt);
        //        dataGridView1.DataSource = dt;
        //        conn.Close();
        //    }
        //}

        void nowezgl_Closed(object sender, EventArgs e) => Aktualne();

        void szczegoly_Closed(object sender, EventArgs e) => Aktualne();

        private void refresh_btn_Click(object sender, EventArgs e)
        {
            //this.zgloszeniaTableAdapter.Fill(this.bazaZgloszenDataSet.Zgloszenia);
            
        }

        public void PerformRefresh()
        {
            var data = DateTime.Now.ToLongTimeString();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
                _id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        private void usun_btn_Click(object sender, EventArgs e)
        {
            if (_id!=0)
            {
                var itemDoSprawdzenia = PobranieDanych.Lista.Single(r => r.ZgloszenieID == _id.ToString());

                if (string.IsNullOrEmpty(itemDoSprawdzenia.DataZamkniecia))
                {
                    var result = MessageBox.Show("Zlecenie nie jest zamknięte. Czy w dalszym ciągu chcesz usunąć zlecenie ?", "Usuwanie zlecenia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        var operacja = new PobranieDanych();
                        operacja.UsunZlecenie(_id);

                        MessageBox.Show("Rekord usunięty");

                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = PobranieDanych.Lista;
                    }
                }
                else
                {
                    var operacja = new PobranieDanych();
                    operacja.UsunZlecenie(_id);

                    MessageBox.Show("Rekord usunięty");

                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = PobranieDanych.Lista;
                }
                
            }
            else
            {
                MessageBox.Show("Zaznacz element do usunięcia");
            }
        }

        private void zamknij_btn_Click(object sender, EventArgs e)
        {
            if (_id != 0)
            {
                var zamknij = new PobranieDanych();
                zamknij.ZamknijZlecenie(_id);
                dataGridView1.Refresh();
            }
            else
            {
                MessageBox.Show("Zaznacz element do zamknięcia");
            }
        }

        private void Aktualne()
        {
            var listaAktualne = new List<Zgloszenia>();
            
            dataGridView1.Columns[4].Visible = false;
            foreach (var item in PobranieDanych.Lista)
            {
                var zgloszenia = new Zgloszenia();
                if (string.IsNullOrEmpty(item.DataZamkniecia))
                {
                    zgloszenia.ZgloszenieID = item.ZgloszenieID;
                    zgloszenia.Tytul = item.Tytul;
                    zgloszenia.Opis = item.Opis;
                    zgloszenia.DataOtworzenia = item.DataOtworzenia;
                    zgloszenia.Komentarz = item.Komentarz;
                    zgloszenia.UzytkownikID = item.UzytkownikID;
                    zgloszenia.UzytkownikImie = item.Uzytkownicy.ImieNazwisko;
                    listaAktualne.Add(zgloszenia);
                }
            }
            dataGridView1.DataSource = listaAktualne;
        }

        private void zamkniete_btn_Click(object sender, EventArgs e)
        {
            var listaAktualne = new List<Zgloszenia>();

            this.dataGridView1.Columns[4].Visible = true;
            foreach (var item in PobranieDanych.Lista)
            {
                var zgloszenia = new Zgloszenia();
                if (!string.IsNullOrEmpty(item.DataZamkniecia))
                {
                    zgloszenia.ZgloszenieID = item.ZgloszenieID;
                    zgloszenia.Tytul = item.Tytul;
                    zgloszenia.Opis = item.Opis;
                    zgloszenia.DataOtworzenia = item.DataOtworzenia;
                    zgloszenia.DataZamkniecia = item.DataZamkniecia;
                    zgloszenia.Komentarz = item.Komentarz;
                    zgloszenia.UzytkownikID = item.UzytkownikID;
                    zgloszenia.UzytkownikImie = item.Uzytkownicy.ImieNazwisko;
                    listaAktualne.Add(zgloszenia);
                }
            }
            dataGridView1.DataSource = listaAktualne;
        }

        private void aktualne_btn_Click(object sender, EventArgs e)
        {
           var listaAktualne = new List<Zgloszenia>();
           
            this.dataGridView1.Columns[4].Visible = false;
            foreach (var item in PobranieDanych.Lista)
            {
                var zgloszenia = new Zgloszenia();
                if (string.IsNullOrEmpty(item.DataZamkniecia))
                {
                    zgloszenia.ZgloszenieID = item.ZgloszenieID;
                    zgloszenia.Tytul = item.Tytul;
                    zgloszenia.Opis = item.Opis;
                    zgloszenia.DataOtworzenia = item.DataOtworzenia;
                    zgloszenia.Komentarz = item.Komentarz;
                    zgloszenia.UzytkownikID = item.UzytkownikID;
                    zgloszenia.UzytkownikImie = item.Uzytkownicy.ImieNazwisko;

                    listaAktualne.Add(zgloszenia);
                }
            }
            
            dataGridView1.DataSource = listaAktualne;
        }

        private void wszystkie_btn_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Columns[4].Visible = true;
            dataGridView1.DataSource = PobranieDanych.Lista;
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            _id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());

            var szczegoly = new Szczegoly();
            
            szczegoly.PobranID(_id);
            szczegoly.Closed += szczegoly_Closed;
            szczegoly.ShowDialog(this);
            
        }
        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)

        {

            MessageBox.Show(e.ToString());

        }
    }
}
