using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;
using MicroServices;

namespace bsm208donemprojesigrup5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            Kullanici girisKullanici = new Kullanici();
            KullaniciServices ms = new KullaniciServices();

            girisKullanici.kullaniciAdi = tbKullaniciAd.Text;
            girisKullanici.sifre = tbSifre.Text;

            bool durum = ms.girisKontrol(girisKullanici);

            if (durum)
            {
                MessageBox.Show("Hoşgeldiniz");
            }
            else
            {
                MessageBox.Show("Hatalı Giriş Denemesi");
            }
        }
    }
}
