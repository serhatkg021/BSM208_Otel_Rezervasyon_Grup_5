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
    public partial class frmKoltuklar : Form
    {
        RezervasyonServices servis = new RezervasyonServices();
        KoltukServices servisK = new KoltukServices();
        Kullanici sistemKullanici = new Kullanici();
        Ucus secilenUcus = new Ucus();
        int biletFiyati;
        string acentaAdi;

        public frmKoltuklar(Kullanici k = null, Ucus u = null, int bf = 0, string aa = null)
        {
            InitializeComponent();
            sistemKullanici = k;
            secilenUcus = u;
            biletFiyati = bf;
            acentaAdi = aa;
        }

        private void frmKoltuklar_Load(object sender = null, EventArgs e = null)
        {
            if (sistemKullanici == null)
            {
                btnRezervasyonuTamamla.Enabled = false;
                cbİstenenKoltuguSecin.Enabled = false;
            }
            List<Koltuk> koltukDurumlar = servisK.koltukKontrol(secilenUcus);
            int bosKS = 0, doluKS = 0;

            for (int i = 1; i <= koltukDurumlar.Count; i++)
            {
                Button btn = this.Controls.Find("btnKoltuk" + i, true).FirstOrDefault() as Button;
                if (koltukDurumlar[i - 1].koltukDurumu)
                {
                    btn.BackColor = Color.Red;
                    doluKS++;
                }
                else
                {
                    btn.BackColor = Color.Green;
                    bosKS++;
                    cbİstenenKoltuguSecin.Items.Add(koltukDurumlar[i - 1].koltukNo);
                }
            }
            tbBosKoltukSayisi.Text = bosKS.ToString();
            tbDoluKoltukSayisi.Text = doluKS.ToString();
        }

        private void btnRezervasyonuTamamla_Click(object sender, EventArgs e)
        {
            Rezervasyon rz = new Rezervasyon();
            rz.ucus = secilenUcus;
            rz.kullanici = sistemKullanici;
            rz.acentaAdi = acentaAdi;
            rz.biletFiyat = biletFiyati;
            rz.koltukNo = Convert.ToInt32(cbİstenenKoltuguSecin.Text);
            rz.durum = true;
            bool sonuc = servis.kullaniciRezervasyonEkle(rz);
            if (sonuc)
            {
                MessageBox.Show("Rezervasyonunuz Tamamlanmıştır.");
                cbİstenenKoltuguSecin.Items.Clear();
                frmKoltuklar_Load();
            }
            else
            {
                MessageBox.Show("Rezervasyonunuz Tamamlanamamıştır.");
            }
        }
    }
}
