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
    /// Logika interakcji dla klasy WindowPracownikKoniec.xaml
    /// </summary>
    public partial class WindowPracownikKoniec : Window
    {
        public Zamowienie zamowienia = Zamowienie.OdczytajJSON("przyk-zamowienie");

        public WindowPracownikKoniec(Pracownik wybrany, int indeks)
        {
            InitializeComponent();
            DateTime data1 = new DateTime(2019, 1, 1);
            int dni = (DateTime.Now - data1).Days;
            indeks = indeks + dni;
            data1 = data1.AddDays(indeks);
            texbox_data.Text = data1.ToString();

            List<Zamowienie> lista = new List<Zamowienie>();
            lista.Add(zamowienia);


            //listbox_zamowienia.ItemsSource = wybrany.Terminarz[indeks];
            listbox_zamowienia.ItemsSource = lista;
        }

        private void Powrot(object sender, RoutedEventArgs e)
        {
            this.Close();
            WindowListaPracownikow okno = new WindowListaPracownikow();
            okno.ShowDialog();
        }

        private void listbox_zamowienia_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void texbox_data_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
