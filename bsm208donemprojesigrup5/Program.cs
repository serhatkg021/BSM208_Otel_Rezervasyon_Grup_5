using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bsm208donemprojesigrup5
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmRezervasyonEkrani frmR = new frmRezervasyonEkrani();
            Application.Run(frmR);
            if (frmR.sayfaDurumu)
            {
                Application.Run(new frmGirisEkrani());
            }
        }
    }
}
