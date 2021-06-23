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
        public frmRezervasyonEkrani()
        {
            InitializeComponent();
        }

        private void btnUcakBiletiAra_Click(object sender, EventArgs e)
        {
            //Ucus arananUcus = new Ucus();
            //arananUcus.kalkisYeri = cbNereden.Text.ToString();
            //arananUcus.inisYeri = cbNereye.Text.ToString();
            //arananUcus.seferTarih = dtpGidisTarihi.Value;
            //arananUcus.havayoluAdi = cbHavaYollari.Text;

            DataTable dt = servis.ucusListe();
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
            MessageBox.Show(secilenUcus.id + " " + secilenUcus.havayoluAdi + " " + secilenUcus.kalkisYeri + " " + secilenUcus.inisYeri + " " + secilenUcus.seferTarih);
        }
    }
}
