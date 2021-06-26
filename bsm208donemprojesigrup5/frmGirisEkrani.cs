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
        BildirimServices servisB = new BildirimServices();

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
                MessageBox.Show("Hoşgeldiniz "+donenKullanici.kullaniciAdiSoyadi);
                if (donenKullanici.hesapTur == 1)
                {
                    frmYoneticiPaneliEkrani frmYP = new frmYoneticiPaneliEkrani(donenKullanici);
                    frmYP.Show();
                }
                else if (donenKullanici.hesapTur == 2)
                {
                    List<Bildirim> bildirimler = servisB.bildirimKullaniciKontrol(donenKullanici);
                    for (int i = 0; i < bildirimler.Count; i++)
                    {
                        MessageBox.Show("ID'si: " + bildirimler[i].ucus.id + " olan uçuşunuza '" + bildirimler[i].bildirimIcerigi + "' bildirimi eklenmiştir.");
                    }
                    frmRezervasyonEkrani frmR = new frmRezervasyonEkrani(donenKullanici);
                    frmR.Show();                    
                }
                this.Hide();
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

        private void btnKaydol_Click(object sender, EventArgs e)
        {
            frmKullaniciKayitEkrani frmKKE = new frmKullaniciKayitEkrani();
            frmKKE.Show();
        }
    }
}
