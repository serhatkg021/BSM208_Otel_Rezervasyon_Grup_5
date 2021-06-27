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
    public partial class frmRezervasyonEkrani : Form
    {
        UcusServices servis = new UcusServices();
        Kullanici sistemKullanici = new Kullanici();
        public frmRezervasyonEkrani(Kullanici k = null)
        {
            InitializeComponent();
            sistemKullanici = k;
        }

        private void btnUcakBiletiAra_Click(object sender, EventArgs e)
        {
            Ucus arananUcus = new Ucus();
            arananUcus.kalkisYeri = cbNereden.Text.ToString();
            arananUcus.inisYeri = cbNereye.Text.ToString();
            arananUcus.seferTarih = Convert.ToDateTime(dtpSeferTarihi.Text);        
            arananUcus.havayoluAdi = cbHavaYollari.Text;
            DataTable dt = servis.ucusListe(arananUcus);
            if (dt.Rows.Count < 1)
            {
                MessageBox.Show("Aradığınız kriterlerde uçuş mevcut değildir.");
            }
            dgvUcusListe.DataSource = dt;

        }


        private void dgvUcusListe_DoubleClick(object sender, EventArgs e)
        {
            Ucus secilenUcus = new Ucus();
            secilenUcus.id = Convert.ToInt32(dgvUcusListe.SelectedRows[0].Cells["ucuslarID"].Value);
            secilenUcus.inisYeri = dgvUcusListe.SelectedRows[0].Cells["inisYeri"].Value.ToString();
            secilenUcus.kalkisYeri = dgvUcusListe.SelectedRows[0].Cells["kalkisYeri"].Value.ToString();
            secilenUcus.havayoluAdi = dgvUcusListe.SelectedRows[0].Cells["havayoluAdi"].Value.ToString();
            secilenUcus.seferTarih = Convert.ToDateTime(dgvUcusListe.SelectedRows[0].Cells["seferTarihi"].Value);
            int biletFiyat = Convert.ToInt32(dgvUcusListe.SelectedRows[0].Cells["biletFiyat"].Value);
            string acentaAdi = dgvUcusListe.SelectedRows[0].Cells["acentaAdi"].Value.ToString();


            frmKoltuklar frmK;
            if (sistemKullanici == null)
            {
               frmK = new frmKoltuklar(null,secilenUcus);
            }
            else
            {
               frmK = new frmKoltuklar(sistemKullanici, secilenUcus, biletFiyat, acentaAdi);
            }
            frmK.Show();
        }

        private void frmRezervasyonEkrani_Load(object sender, EventArgs e)
        {
            if (sistemKullanici == null)
            {
                btnKullaniciRezervasyonlar.Enabled = false;
            }
            else
            {
                btnGirisYap.Enabled = false;
            }
        }

        public bool sayfaDurumu { get; set; }
        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            frmGirisEkrani frmG = new frmGirisEkrani();
            frmG.Show();
            this.Close();
            sayfaDurumu = true;
        }

        private void btnKullaniciRezervasyonlar_Click(object sender, EventArgs e)
        {
            frmKullaniciRezervasyonlariEkrani frmKRE = new frmKullaniciRezervasyonlariEkrani(sistemKullanici);
            frmKRE.Show();
        }
    }
}
