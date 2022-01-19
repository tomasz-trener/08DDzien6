

using P04AplikacjaZawodnicy.Core;
using P04AplikacjaZawodnicy.Core.Errors;
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
    public partial class FrmZawodnicy : Form
    {
        ManagerZawodnikow mz;
        public FrmZawodnicy()
        {
            InitializeComponent();
            foreach (var k in Zawodnik.Kolumny)
                clbKolumny.Items.Add(k.Nazwa, k.Widocznosc);

        }

        private void btnWczytaj_Click(object sender, EventArgs e)
        {
            if (chLoklnie.Checked)
                mz = new ManagerZawodnikow(txtSciezka.Text, RodzajImportu.Lokalne);
            else
                mz = new ManagerZawodnikow();

            Odswiez();
        }

        public void Odswiez() // ponownie pobiera zawodnikow z pliku 
        {
            List<string> kolumny = new List<string>();

            foreach (var k in clbKolumny.CheckedItems)
                kolumny.Add(k.ToString());

            Zawodnik.KolumnyZWidoku = kolumny.ToArray();

            Zawodnik[] zawodnicy = null;
            try
            {
                zawodnicy = mz.WygenerujZawodnikow();
            }
            catch (NiepoprawnaSciezkaException ex)
            {
                MessageBox.Show(ex.Message, "Błąd aplikacji", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ZleSformatowaneDaneException ex)
            {
                MessageBox.Show(ex.Message, "Błąd aplikacji", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Bład wczytywania danych", "Błąd aplikacji", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (zawodnicy != null)
            {
                lbDane.DisplayMember = "WidoczneKolumny";
                lbDane.DataSource = zawodnicy;// rzutowanie niejawne
            }


        }

        private void btnUstawSciezke_Click(object sender, EventArgs e)
        {
            ofdOtwiwarciePliku.Title = "Wskaz ścieżke do pliku";
            ofdOtwiwarciePliku.InitialDirectory = @"c:\dane";
            ofdOtwiwarciePliku.Filter = "TXT files|*.txt";

            if (ofdOtwiwarciePliku.ShowDialog() == DialogResult.OK)
            {
                string sciezka = ofdOtwiwarciePliku.FileName;
                txtSciezka.Text = sciezka;
            }
        }

        private void btnNowy_Click(object sender, EventArgs e)
        {
            FrmSzczegoly fs = new FrmSzczegoly(mz,this,TrybOkienka.Nowy);  
            fs.Show(this);
        }

        private void btnEdytuj_Click(object sender, EventArgs e)
        {
            Zawodnik s = (Zawodnik)lbDane.SelectedItem;
            FrmSzczegoly fs = new FrmSzczegoly(mz, this, TrybOkienka.Edycja,s);
            fs.Show(this);
        }

        private void btnUsun_Click(object sender, EventArgs e)
        {
            Zawodnik s = (Zawodnik)lbDane.SelectedItem;
            mz.Usun(s.Id_zawodnika);
            Odswiez();
        }
    }
}
