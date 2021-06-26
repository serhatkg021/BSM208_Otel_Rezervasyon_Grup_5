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
        Kullanici sistemKullanici = new Kullanici();
        Ucus secilenUcus = new Ucus();

        public frmKoltuklar(Kullanici k = null,Ucus u = null)
        {
            InitializeComponent();
            sistemKullanici = k;
            secilenUcus = u;
        }

        private void frmKoltuklar_Load(object sender, EventArgs e)
        {
            if (sistemKullanici == null)
            {
                btnKoltuk1.BackColor = Color.Red;
                btnRezervasyonuTamamla.Enabled = false;
                cbİstenenKoltuguSecin.Enabled = false;
            }
        }
    }
}
