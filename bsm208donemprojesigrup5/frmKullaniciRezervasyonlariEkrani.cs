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
    public partial class frmKullaniciRezervasyonlariEkrani : Form
    {
        RezervasyonServices servis = new RezervasyonServices();
        Kullanici sistemKullanici = new Kullanici();
        DataTable tablo = new DataTable();
        public frmKullaniciRezervasyonlariEkrani(Kullanici k = null)
        {
            InitializeComponent();
            sistemKullanici = k;
        }
        private void frmKullaniciRezervasyonlariEkrani_Load(object sender, EventArgs e)
        {
            if (sistemKullanici != null)
            {
                tablo.Columns.Add("Uçuş ID", typeof(int));
                tablo.Columns.Add("Acenta Adı", typeof(string));
                tablo.Columns.Add("Kalkış Yeri", typeof(string));
                tablo.Columns.Add("İniş Yeri", typeof(string));
                tablo.Columns.Add("Havayolu Adı", typeof(string));
                tablo.Columns.Add("Sefer Tarihi", typeof(DateTime));
                tablo.Columns.Add("Koltuk No", typeof(int));
                tablo.Columns.Add("Bilet Fiyatı", typeof(decimal));
                tablo.Columns.Add("Rezervasyon Tarihi", typeof(DateTime));
                List<Rezervasyon> rezervasyonlar = servis.kullaniciRezervasyonListe(sistemKullanici);
                for (int i = 0; i < rezervasyonlar.Count; i++)
                {
                    tablo.Rows.Add(rezervasyonlar[i].ucus.id, 
                                   rezervasyonlar[i].acentaAdi,
                                   rezervasyonlar[i].ucus.kalkisYeri, 
                                   rezervasyonlar[i].ucus.inisYeri,
                                   rezervasyonlar[i].ucus.havayoluAdi,
                                   rezervasyonlar[i].ucus.seferTarih,
                                   rezervasyonlar[i].koltukNo,
                                   rezervasyonlar[i].biletFiyat,
                                   rezervasyonlar[i].olusturmaTarih);
                }
                dgvKullaniciRezervasyonlar.DataSource = tablo; 
            }
        }
    }
}
