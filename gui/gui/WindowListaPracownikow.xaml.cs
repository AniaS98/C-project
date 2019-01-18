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
using System.Collections.ObjectModel;
using Projekt;

namespace gui
{
    /// <summary>
    /// Logika interakcji dla klasy WindowListaPracownikow.xaml
    /// </summary>
    public partial class WindowListaPracownikow : Window
    {
        //Zespol zespol = new Zespol();
        //ObservableCollection <Zespol> lista;

        public WindowListaPracownikow()
        {
            //InitializeComponent();
            //lista = new ObservableCollection<Zespol>();
            //dieta = (Dieta)Dieta.OdczytajXML("dieta2.xml"); //tu właściwa ścieżka!
           
       
        }

        private void Dodaj(object sender, RoutedEventArgs e)
        {
            //Pracownik p = new Pracownik();
            //OsobaWindow okno = new OsobaWindow(cz);
           // okno.ShowDialog();
            //zespol.DodajPracownika(p);
            //lista.Add(p); 
        }

        private void Dalej(object sender, RoutedEventArgs e)
        {
            WindowTerminarz okno = new WindowTerminarz();
            okno.ShowDialog();
        }

        private void Lista(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
