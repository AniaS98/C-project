using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
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
    /// Logika interakcji dla klasy WindowKlient.xaml
    /// </summary>
    public partial class WindowKlient : Window
    {

        Osoba osoba;
        Zamowienie zamowienie;

        public WindowKlient()
        {
            zamowienie = new Zamowienie();
            InitializeComponent();
        }

        private void Button_Dalej(object sender, RoutedEventArgs e)
        {
            if (textBox_PESEL.Text == "" || textBox_Imie.Text == "" || textBox_Nazwisko.Text == "")
            {
                MessageBox.Show("Złe dane!!!");
                return;
            }
            Plcie plec;
            if (comboBox_plec.Text == "kobieta")
                plec = Plcie.K;
            else
                plec = Plcie.M;

            osoba = new Klient(textBox_Imie.Text, textBox_Nazwisko.Text, textBox_PESEL.Text, plec);

            this.Close();
            zamowienie.Osoba = osoba;
            WindowKlientZamowienie okno = new WindowKlientZamowienie(zamowienie);
            okno.ShowDialog();
        }

        public WindowKlient(Osoba osoba) 
            : this()
        {
            this.osoba = osoba;
            if (osoba.Pesel != new string('0', 11))
            {
                textBox_PESEL.Text = osoba.Pesel;
                textBox_Imie.Text = osoba.Imie;
                textBox_Nazwisko.Text = osoba.Nazwisko;
                if ((osoba.plec) == Plcie.K)
                    comboBox_plec.Text = "kobieta";
                else
                    comboBox_plec.Text = "mężczyzna";

            }
        }

        private void Button_Wstecz(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
