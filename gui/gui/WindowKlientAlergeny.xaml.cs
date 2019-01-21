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
    /// Logika interakcji dla klasy WindowKlientAlergeny.xaml
    /// </summary>
    partial class WindowKlientAlergeny : Window
    {
        Dieta dieta;
        Zamowienie zamowienie;

        public WindowKlientAlergeny(Zamowienie zamowienie)
        {
            InitializeComponent();
            this.zamowienie = zamowienie;
            dieta = zamowienie.WybranaDieta;
        }

        private void Button_Wstecz(object sender, RoutedEventArgs e)
        {
            this.Close();
            WindowKlientZamowienie okno = new WindowKlientZamowienie(zamowienie);
            okno.ShowDialog();
        }

        private void Button_Dalej(object sender, RoutedEventArgs e)
        {
            this.Close();
            WindowSzczegolyZamowienia okno = new WindowSzczegolyZamowienia(zamowienie);
            okno.ShowDialog();
        }

        private void RadioButton_Brak(object sender, RoutedEventArgs e)
        {
            dieta.Alergeny.Clear();
        }

        private void CheckButton_Alergen(object sender, RoutedEventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            string nazwa = checkBox.Content.ToString().ToLower();
            SAlergen sa = MenuDieta.ListaWszystkichAlergenów.Where(a => a.Nazwa.ToString() == nazwa).First();
            if (checkBox.IsEnabled)
                if(!zamowienie.WybranaDieta.Alergeny.Contains(sa))
                    zamowienie.WybranaDieta.Alergeny.Add(sa);
            else
                zamowienie.WybranaDieta.Alergeny.Remove(sa);
        }
    }
}
