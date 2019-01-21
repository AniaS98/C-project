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
    /// Logika interakcji dla klasy WindowKlientZamowienie.xaml
    /// </summary>
    public partial class WindowKlientZamowienie : Window
    {
        MenuDieta dieta;
        ERodzajeDiet typ;
        Zamowienie zamowienie;

        public WindowKlientZamowienie(Zamowienie zamowienie)
        {
            this.zamowienie = zamowienie;
            dieta = new MenuDieta();
            InitializeComponent();
        }

        private void Button_Wstecz(object sender, RoutedEventArgs e)
        {
            this.Close();
            WindowKlient okno = new WindowKlient();
            okno.ShowDialog();
        }

        private void Button_Dalej(object sender, RoutedEventArgs e)
        {
            this.Close();
            zamowienie.WybranaDieta = dieta.Menu.Where(t => t.Typ == typ).First();
            zamowienie.WybranaDieta.Alergeny = new List<SAlergen>();
            WindowKlientAlergeny okno = new WindowKlientAlergeny(zamowienie);
            okno.ShowDialog();
        }

        private void RadioButton_Podstawowa(object sender, RoutedEventArgs e)
        {
            this.typ = ERodzajeDiet.podstawowa;
        }

        private void RadioButton_Wegetarianska(object sender, RoutedEventArgs e)
        {
            this.typ = ERodzajeDiet.wegetariańska;
        }

        private void RadioButton_Weganska(object sender, RoutedEventArgs e)
        {
            this.typ = ERodzajeDiet.wegańska;
        }

        private void RadioButton_Bezlaktozowa(object sender, RoutedEventArgs e)
        {
            this.typ = ERodzajeDiet.bezlaktozowa;
        }

        private void RadioButton_Bezglutenowa(object sender, RoutedEventArgs e)
        {
            this.typ = ERodzajeDiet.bezglutenowa;
        }
    }
}
