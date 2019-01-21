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
    /// Logika interakcji dla klasy WindowSzczegolyZamowienia.xaml
    /// </summary>
    public partial class WindowSzczegolyZamowienia : Window
    {
        Zamowienie zamowienie;

        public WindowSzczegolyZamowienia(Zamowienie zamowienie)
        { 
            this.zamowienie = zamowienie;
            InitializeComponent();
        }

        private void Button_Wstecz(object sender, RoutedEventArgs e)
        {
            this.Close();
            WindowKlientAlergeny okno = new WindowKlientAlergeny(zamowienie);
            okno.Show();
        }

        private void Button_Dalej(object sender, RoutedEventArgs e)
        {
            this.Close();
            if(DataRozpoczecia.SelectedDate != null)
                zamowienie.DataRozpoczeciaZamowienia = (DateTime)DataRozpoczecia.SelectedDate;
            if (DataZakonczenia.SelectedDate != null)
                zamowienie.DataKoncaZamowienia= (DateTime)DataZakonczenia.SelectedDate;
            zamowienie.Adres = new Adres(Ulica.Text, NrDomu.Text, Convert.ToInt32(NrMieszkania.Text), KodPocztowy.Text, Miasto.Text);
            WindowPodsumowanieZamowienia okno = new WindowPodsumowanieZamowienia(zamowienie);
            okno.ShowDialog();
        }
    }
}
