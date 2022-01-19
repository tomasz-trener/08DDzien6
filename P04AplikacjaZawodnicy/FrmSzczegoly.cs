
using P04AplikacjaZawodnicy.Core;
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

    public enum TrybOkienka 
    { 
        Nowy,
        Edycja
    }


    public partial class FrmSzczegoly : Form
    {
        IDostepDoDanych iDostepDoDanych;
        FrmZawodnicy frmZawodnicy;
        TrybOkienka trybOkienka;
        Zawodnik zawodnik;

        public FrmSzczegoly(IDostepDoDanych mz, FrmZawodnicy frmZawodnicy, TrybOkienka trybOkienka)
        {
            InitializeComponent();
            this.iDostepDoDanych = mz;
            this.frmZawodnicy = frmZawodnicy;
            this.trybOkienka = trybOkienka;
           
        }
        public FrmSzczegoly(IDostepDoDanych mz, FrmZawodnicy frmZawodnicy, TrybOkienka trybOkienka, Zawodnik zawodnik): this(mz,frmZawodnicy,trybOkienka)
        {
            this.zawodnik = zawodnik;

            txtImie.Text = zawodnik.Imie;
            txtNazwisko.Text = zawodnik.Nazwisko;
            txtKraj.Text = zawodnik.Kraj;
            dtpDataUrodzenia.Value = zawodnik.DataUrodzenia;
            numWaga.Value = zawodnik.Waga;
            nunWzrost.Value = zawodnik.Wzrost;
        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {
            Zawodnik z;  
          
            if (trybOkienka == TrybOkienka.Nowy)
            {
                z = new Zawodnik();
                zczytajTextobxy(z);
                iDostepDoDanych.Dodaj(z);
            }  
            else if (trybOkienka == TrybOkienka.Edycja)
            {
                z = zawodnik;
                zczytajTextobxy(z);
                iDostepDoDanych.Edytuj(z);
            }
               
            else
                throw new Exception("nieznany tryb okiekna");
           
            frmZawodnicy.Odswiez();
        }


        private void zczytajTextobxy(Zawodnik z)
        {
            z.Imie = txtImie.Text;
            z.Nazwisko = txtNazwisko.Text;
            z.Kraj = txtKraj.Text;
            z.DataUrodzenia = dtpDataUrodzenia.Value;
            z.Waga = Convert.ToInt32(numWaga.Value);
            z.Wzrost = Convert.ToInt32(nunWzrost.Value);
        }

        private void FrmSzczegoly_Load(object sender, EventArgs e)
        {
            this.CenterToParent();
            this.Left += 400;
            
        }
    }
}
