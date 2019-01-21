using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Projekt;

namespace gui
{
    /// <summary>
    /// Logika interakcji dla klasy WindowDodajPracownika.xaml
    /// </summary>
  public partial class WindowDodajPracownika : Window
    {
        Osoba osoba;

        public WindowDodajPracownika()
        {
            InitializeComponent();
        }

        private void anuluj(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        public WindowDodajPracownika(Osoba osoba) : this()
        {
            this.osoba = osoba;
            if (osoba.Pesel != "00000000000")
            {
                textbox_pesel.Text = osoba.Pesel;
                textbox_imie.Text = osoba.Imie;
                textbox_nazwisko.Text =osoba.Nazwisko;
                if ((osoba.plec) == Plcie.K)
                    combobox_plec.Text = "kobieta";
                else
                    combobox_plec.Text = "mężczyna";
            }
        }

        private void dodaj(object sender, RoutedEventArgs e)
        {
            if (textbox_pesel.Text == "" || textbox_imie.Text == "" || textbox_nazwisko.Text == "")
            {
                MessageBox.Show("Złe dane!!!");
                return;
            }
            osoba.pesel = textbox_pesel.Text;
            osoba.imie = textbox_imie.Text;
            osoba.nazwisko = textbox_nazwisko.Text;
            if (combobox_plec.Text == "kobieta")
                this.osoba.plec = Plcie.K;
            else
                this.osoba.plec = Plcie.M;
            this.Close();
        }
    }
}
