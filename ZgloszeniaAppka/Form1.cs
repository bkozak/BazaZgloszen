using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZgloszeniaAppka
{
    public partial class Form1 : Form
    {
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
            pobierz.PobieranieWszystkiego();
            dataGridView1.DataSource = PobranieDanych.Lista;
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

        private void DisplayData()
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ZgloszeniaAppka.Properties.Settings.BazaZgloszenConnectionString"].ConnectionString))
            {
                conn.Open();
                DataTable dt = new DataTable();
                _adapt = new SqlDataAdapter("SELECT ZgloszenieID, Tytul, Opis, Komentarz, UzytkownikID  FROM Zgloszenia", conn);
                _adapt.Fill(dt);
                dataGridView1.DataSource = dt;
                conn.Close();
            }
        }

        void nowezgl_Closed(object sender, EventArgs e) => Aktualne();

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
                    MessageBox.Show("Rekord usunięty");
                    this.zgloszeniaTableAdapter.Fill(this.bazaZgloszenDataSet.Zgloszenia);

                }
            }
            else
            {
                MessageBox.Show("Zaznacz element do usunięcia");
            }
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void zamknij_btn_Click(object sender, EventArgs e)
        {

            if (_id != 0)
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ZgloszeniaAppka.Properties.Settings.BazaZgloszenConnectionString"].ConnectionString))
                {
                    _sql = "UPDATE Zgloszenia SET DataZamkniecia=@dataZ WHERE ZgloszenieID=@id";
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(_sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", _id);
                        cmd.Parameters.AddWithValue("@dataZ", DateTime.Now);
                        cmd.ExecuteNonQuery();
                    }
                    conn.Close();
                    Aktualne();
                }
            }
            else
            {
                MessageBox.Show("Zaznacz element do zamknięcia");
            }
        }

        private void Aktualne()
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
                    zgloszenia.Uzytkownikid = item.Uzytkownikid;
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
                    zgloszenia.Komentarz = item.Komentarz;
                    zgloszenia.Uzytkownikid = item.Uzytkownikid;
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
                    zgloszenia.Uzytkownikid = item.Uzytkownikid;
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
            szczegoly.Show();
        
        }
    }
}
