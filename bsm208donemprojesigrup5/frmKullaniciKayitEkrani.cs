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
    public partial class frmKullaniciKayitEkrani : Form
    {
        KullaniciServices servis = new KullaniciServices();
        public frmKullaniciKayitEkrani()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Kullanici kaydetKullanici = new Kullanici();


            kaydetKullanici.kullaniciAdiSoyadi = tbAdSoyad.Text;
            kaydetKullanici.dogumTarih = dtmDogumTarihi.Value;
            kaydetKullanici.kullaniciAdi = tbKullaniciAdi.Text;
            kaydetKullanici.sifre = tbSifre.Text;
            kaydetKullanici.hesapTur = 2;
            
            if (servis.kullaniciAdiKontrol(tbKullaniciAdi.Text))
            {
                if (tbSifre.Text == tbSifreTekrar.Text)
                {
                    if (servis.kullaniciEkle(kaydetKullanici))
                    {
                        MessageBox.Show("Kayıt Olundu.");
                    }
                    else
                    {
                        MessageBox.Show("Kayıt Oluşturulurken Bir Sorun Oluştu.");
                    }
                }
                else
                {
                    MessageBox.Show("Şifreler Birbiriyle Uyuşmuyor.");
                }
            }
            else
            {
                MessageBox.Show("Bu Kullanıcı Adı Daha Önce Alınmıştır."); 
            }

            
        }
    }
}
