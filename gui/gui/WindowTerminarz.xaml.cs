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
            List<DateTime> tymczasowy = new List<DateTime>();
            //DateTime data1 = new DateTime(2018, 12, 31);
            DateTime data1 = new DateTime();
            data1 = DateTime.Now.AddDays(-1);
            InitializeComponent();
            Dane_pracownika.Text = wybrany.Imie+" "+ wybrany.Nazwisko;
            for(int i=0;i<30;i++)
            {
                data1 = data1.AddDays(1);
                tymczasowy.Add(data1);
            }
            listbox_terminarz.ItemsSource = tymczasowy;


            //listbox_zamowienia.ItemsSource = wybrany.terminarz[listbox_terminarz.SelectedIndex];

        }



        private void Powrot(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Imie_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        public void Lista(object sender, SelectionChangedEventArgs e)
        {
            listbox_terminarz.SelectionMode = SelectionMode.Single;
        }

        
    }
}
