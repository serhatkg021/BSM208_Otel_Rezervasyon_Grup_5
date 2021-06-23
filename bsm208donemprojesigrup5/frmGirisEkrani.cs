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
    public partial class frmGirisEkrani : Form
    {
        KullaniciServices servis = new KullaniciServices();
        public frmGirisEkrani()
        {
            InitializeComponent();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            Kullanici girisKullanici = new Kullanici();
            

            girisKullanici.kullaniciAdi = tbKullaniciAd.Text;
            girisKullanici.sifre = tbSifre.Text;

            Kullanici donenKullanici = new Kullanici(); 
            donenKullanici =  servis.girisKontrol(girisKullanici);

            if (donenKullanici != null)
            {
                MessageBox.Show("Hoşgeldiniz");
                frmRezervasyonEkrani frmR = new frmRezervasyonEkrani();
                frmR.Show();
                
            }
            else
            {
                MessageBox.Show("Hatalı Giriş Denemesi");
            }
        }      
        private void tbSifre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnGirisYap_Click(this, new EventArgs());
            }
        }
    }
}
