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
    public partial class frmYoneticiPaneliEkrani : Form
    {
        UcusServices servisU = new UcusServices();
        RezervasyonServices servisR = new RezervasyonServices();
        BildirimServices servisB = new BildirimServices();

        Kullanici sistemKullanici = new Kullanici();
        DataTable tabloU = new DataTable();
        DataTable tabloR = new DataTable();
        public frmYoneticiPaneliEkrani(Kullanici k = null)
        {
            InitializeComponent();
            sistemKullanici = k;
        }

        private void frmYoneticiPaneliEkrani_Load(object sender, EventArgs e)
        {
            if (sistemKullanici != null)
            {
                tabloU.Columns.Add("Uçuş ID", typeof(int));
                tabloU.Columns.Add("Kalkış Yeri", typeof(string));
                tabloU.Columns.Add("İniş Yeri", typeof(string));
                tabloU.Columns.Add("Havayolu Adı", typeof(string));
                tabloU.Columns.Add("Sefer Tarihi", typeof(DateTime));
                List<Ucus> ucuslar = servisU.ucusListeYonetici();
                for (int i = 0; i < ucuslar.Count; i++)
                {
                    tabloU.Rows.Add(ucuslar[i].id,
                                   ucuslar[i].kalkisYeri,
                                   ucuslar[i].inisYeri,
                                   ucuslar[i].havayoluAdi,
                                   ucuslar[i].seferTarih);
                }
                dgvYoneticiUcuslar.DataSource = tabloU;

                tabloR.Columns.Add("Rezervasyon ID", typeof(int));
                tabloR.Columns.Add("Kullanıcı ID", typeof(int));
                tabloR.Columns.Add("Adı Soyadı", typeof(string));
                tabloR.Columns.Add("Uçuş ID", typeof(int));
                tabloR.Columns.Add("Acenta Adı", typeof(string));
                tabloR.Columns.Add("Koltuk No", typeof(int));
                tabloR.Columns.Add("Bilet Fiyatı", typeof(decimal));
                tabloR.Columns.Add("Rezervasyon Tarihi", typeof(DateTime));
                List<Rezervasyon> rezervasyonlar = servisR.yoneticiRezervasyonListe();
                for (int i = 0; i < rezervasyonlar.Count; i++)
                {
                    tabloR.Rows.Add(rezervasyonlar[i].id,
                                    rezervasyonlar[i].kullanici.id, 
                                    rezervasyonlar[i].kullanici.kullaniciAdiSoyadi, 
                                    rezervasyonlar[i].ucus.id,
                                    rezervasyonlar[i].acentaAdi,
                                    rezervasyonlar[i].koltukNo,
                                    rezervasyonlar[i].biletFiyat,
                                    rezervasyonlar[i].olusturmaTarih);
                }
                dgvYoneticiRezervasyonlar.DataSource = tabloR;
            }
        }

        private void dgvYoneticiUcuslar_MouseClick(object sender, MouseEventArgs e)
        {
            tbSecilenUcusID.Text = dgvYoneticiUcuslar.SelectedRows[0].Cells["Uçuş ID"].Value.ToString();
        }

        private void btnBildirimiGonder_Click(object sender, EventArgs e)
        {
            Bildirim bildirim = new Bildirim();
            Ucus ucus = new Ucus();
            ucus.id = Convert.ToInt32(tbSecilenUcusID.Text);
            bildirim.ucus = ucus;
            bildirim.bildirimIcerigi = tbBildirimİcerigi.Text;
            bildirim.durum = true;
            if (servisB.bildirimEkle(bildirim))
            {
                MessageBox.Show("Bildirim Eklenmiştir.");
            }
            else
            {
                MessageBox.Show("Bildirim Eklenilirken Bir Hata Oluştu.");
            }
        }
    }
}
