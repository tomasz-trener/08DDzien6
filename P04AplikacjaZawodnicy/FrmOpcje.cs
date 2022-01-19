using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P04AplikacjaZawodnicy
{
    public partial class FrmOpcje : Form
    {
        FrmZawodnicy frmZawodnicy;
        public FrmOpcje(FrmZawodnicy frmZawodnicy)
        {
            InitializeComponent();

            this.frmZawodnicy = frmZawodnicy;
        }

        private void btnAkceptuj_Click(object sender, EventArgs e)
        {
            frmZawodnicy.Odswiez(cbKolumna.Text);
        }
    }
}
