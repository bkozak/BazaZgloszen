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

namespace ZgloszeniaAppka
{
    public partial class Nowe : Form
    {        
        public Nowe()
        {
            InitializeComponent();
        }

        private void ok_btn_Click(object sender, EventArgs e)
        {
            const string sql = "INSERT INTO Zgloszenia ([Tytul], [Opis], [DataOtworzenia]) VALUES (@Tytul, @Opis, @DataOtworzenia)";
            using (var conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ZgloszeniaAppka.Properties.Settings.BazaZgloszenConnectionString"].ConnectionString))
            {
                conn.Open();

                using (var cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Tytul", tytul_btn.Text);
                    cmd.Parameters.AddWithValue("@Opis", opis_btn.Text);
                    cmd.Parameters.AddWithValue("@DataOtworzenia", DateTime.Now);
                    cmd.ExecuteNonQuery();
                    //MessageBox.Show("Rekord dodany");
                }

                conn.Close();

                Close();
            }
        }
    }
}
