using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Globalization;

namespace ZgloszeniaAppka
{
    public partial class Nowe : Form
    {        
        private CultureInfo pl = new CultureInfo("pl-PL");
        private int idU;
        public Nowe()
        {
            InitializeComponent();
            var pobranieUserow = new PobranieDanych();
            pobranieUserow.PobieranieWszystkiegoUzytkownicy();

            uzytkownik_lb.DataSource = PobranieDanych.listaUzytkownikow;
            uzytkownik_lb.DisplayMember = "ImieNazwisko";

            cb_usery.DataSource = PobranieDanych.listaUzytkownikow;
            cb_usery.DisplayMember = "ImieNazwisko";

            
            
        }

        private void ok_btn_Click(object sender, EventArgs e)
        {
            const string sql = "INSERT INTO Zgloszenia ([Tytul], [Opis], [DataOtworzenia], [Komentarz], [UzytkownikID]) VALUES (@Tytul, @Opis, @DataOtworzenia, @Komentarz, @UzytkownikID)";
            using (var conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ZgloszeniaAppka.Properties.Settings.BazaZgloszenConnectionString"].ConnectionString))
            {
                conn.Open();

                using (var cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Tytul", tytul_btn.Text);
                    cmd.Parameters.AddWithValue("@Opis", opis_btn.Text);
                    cmd.Parameters.AddWithValue("@DataOtworzenia", DateTime.Now.ToString("g", pl));
                    cmd.Parameters.AddWithValue("@Komentarz", opis_btn.Text);
                    cmd.Parameters.AddWithValue("@UzytkownikID", idU);
                    cmd.ExecuteNonQuery();
                    //MessageBox.Show("Rekord dodany");
                }

                conn.Close();

                Close();
            }
            var pobierz = new PobranieDanych();
            pobierz.PobieranieWszystkiego();
        }

        private void uzytkownik_lb_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string cirItem = ((DataRowView) uzytkownik_lb.SelectedItem)["UzytkownikID"].ToString();
        }

        private void cb_usery_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            //var index = PobranieDanych.listaUzytkownikow.FindIndex(u => u.ImieNazwisko == cb_usery.SelectedItem);
            if (cb_usery.SelectedIndex >= 1)
                idU = PobranieDanych.listaUzytkownikow[cb_usery.SelectedIndex].UzytkownikID;
        }
    }
}
