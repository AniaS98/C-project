using Projekt;
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

namespace gui
{
    /// <summary>
    /// Logika interakcji dla klasy WindowPodsumowanieZamowienia.xaml
    /// </summary>
    public partial class WindowPodsumowanieZamowienia: Window
    {
        Zamowienie zamowienie;

        public WindowPodsumowanieZamowienia(Zamowienie zamowienie)
        {
            this.zamowienie = zamowienie;
            InitializeComponent();
            Imie.Text = zamowienie.Osoba.imie;
            Nazwisko.Text = zamowienie.Osoba.nazwisko;
            Adres.Text = zamowienie.Adres.ToString();
            LiczbaDni.Text = (zamowienie.DataKoncaZamowienia - zamowienie.DataRozpoczeciaZamowienia).TotalDays.ToString();
            string alergeny = "";
            if (zamowienie.WybranaDieta.Alergeny.Any())
                foreach (var a in zamowienie.WybranaDieta.Alergeny)
                    alergeny += a.Nazwa + ", ";
            else
                alergeny = "brak";
            Dieta.Text = zamowienie.WybranaDieta.Typ.ToString();
            Alergeny.Text = alergeny;
            Cena.Text = zamowienie.WybranaDieta.Cena.ToString();
        }

        private void Button_Wstecz(object sender, RoutedEventArgs e)
        {
            this.Close();
            WindowSzczegolyZamowienia okno = new WindowSzczegolyZamowienia(zamowienie);
            okno.Show();
        }

        private void Button_Dalej(object sender, RoutedEventArgs e)
        {
            this.Close();
            WindowKlientKoniec okno = new WindowKlientKoniec(zamowienie.NumerZamowienia);
            okno.Show();
        }
    }
}
