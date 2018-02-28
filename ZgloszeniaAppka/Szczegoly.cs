using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZgloszeniaAppka
{
    public partial class Szczegoly : Form
    {
        private int _id;
        public Szczegoly()
        {
            InitializeComponent();
        }

        internal void PobranID(int ZlecenieID)
        {
            _id = ZlecenieID;
            Wypelnienie();
        }

        private void Wypelnienie()
        {
            foreach (var element in PobranieDanych.Lista)
            {
                if (element.ZgloszenieID == _id.ToString())
                {
                    tytul_tb.Text = element.Tytul;
                    opis_tb.Text = element.Opis;
                    datautworzenia_tb.Text = element.DataOtworzenia;
                    datazamkniecia_tb.Text = element.DataZamkniecia;
                    uzytkownik_tb.Text = element.Uzytkownikid;
                }
            }
        }

        private void zapisz_btn_Click(object sender, EventArgs e)
        {
            var pobierz = new PobranieDanych();
            pobierz.UpdateObiektu(_id, tytul_tb.Text, opis_tb.Text);
            Close();

        }
    }
}
