using System;
using System.Collections.Generic;
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
    /// Logika interakcji dla klasy WindowTerminarz.xaml
    /// </summary>
    public partial class WindowTerminarz : Window
    {

        public WindowTerminarz(Pracownik wybrany)
        {
            List<string> tymczasowy = new List<string>();
            DateTime data1 = new DateTime(2019, 1, 1);
            InitializeComponent();
            Dane_pracownika.Text = wybrany.Imie+" "+ wybrany.Nazwisko;
            int n = (DateTime.Now - data1).Days;
            for(int i=n;i<(n+30);i++)
            {
                tymczasowy.Add( wybrany.kalendarz[i].ToString() );

            }
            listbox_terminarz.ItemsSource = tymczasowy;

        }

        private void Powrot(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Imie_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
