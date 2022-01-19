

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
        IDostepDoDanych iDostepDoDanych;
        public FrmZawodnicy()
        {
            InitializeComponent();
            foreach (var k in Zawodnik.Kolumny)
                clbKolumny.Items.Add(k.Nazwa, k.Widocznosc);

        }

        private void btnWczytaj_Click(object sender, EventArgs e)
        {
            if (cbRodzajPracy.SelectedItem.ToString() == "Plik lokalny")
                iDostepDoDanych = new ManagerZawodnikow(txtSciezka.Text, RodzajImportu.Lokalne);
            else if (cbRodzajPracy.SelectedItem.ToString() == "Plik zdalny (tylko do odczytu)")
                iDostepDoDanych = new ManagerZawodnikow();
            else if (cbRodzajPracy.SelectedItem.ToString() == "Baza danych")
                iDostepDoDanych = new ZawodnicyRepository();
            else
                throw new Exception("Nieznany tryb importu");

                Odswiez();
        }

        public void Odswiez(string kolumna = null) // ponownie pobiera zawodnikow z pliku 
        {
            List<string> kolumny = new List<string>();

            foreach (var k in clbKolumny.CheckedItems)
                kolumny.Add(k.ToString());

            Zawodnik.KolumnyZWidoku = kolumny.ToArray();

            Zawodnik[] zawodnicy = null;
            try
            {
                if(kolumna == null)
                    zawodnicy = iDostepDoDanych.WygenerujZawodnikow();
                else
                    zawodnicy = iDostepDoDanych.WygenerujZawodnikow(kolumna);
            }
            catch (NiepoprawnaSciezkaException ex)
            {
                MessageBox.Show(ex.Message, "Błąd aplikacji", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ZleSformatowaneDaneException ex)
            {
                MessageBox.Show(ex.Message, "Błąd aplikacji", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
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
            FrmSzczegoly fs = new FrmSzczegoly(iDostepDoDanych, this, TrybOkienka.Nowy);
            fs.Show(this);
        }

        private void btnEdytuj_Click(object sender, EventArgs e)
        {
            Zawodnik s = (Zawodnik)lbDane.SelectedItem;
            FrmSzczegoly fs = new FrmSzczegoly(iDostepDoDanych, this, TrybOkienka.Edycja, s);
            fs.Show(this);
        }

        private void btnUsun_Click(object sender, EventArgs e)
        {
            Zawodnik s = (Zawodnik)lbDane.SelectedItem;
            iDostepDoDanych.Usun(s.Id_zawodnika);
            Odswiez();
        }

        private void btnOpcje_Click(object sender, EventArgs e)
        {
            FrmOpcje fo = new FrmOpcje(this);
            fo.Show();
        }
    }
}
