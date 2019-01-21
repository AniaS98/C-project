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
    partial class WindowListaPracownikow : Window
    {
        public Zespol zespol= new Zespol("Pudelko");
        public ObservableCollection <Pracownik> lista;
        
        public WindowListaPracownikow()
        {
            InitializeComponent();
            lista = new ObservableCollection<Pracownik>();
            listbox_zespol.ItemsSource = lista;
        }

       public  void Dodaj(object sender, RoutedEventArgs e)
        {
            Pracownik p = new Pracownik("","","",Plcie.K);
            WindowDodajPracownika okno = new WindowDodajPracownika(p);
            okno.ShowDialog();
            zespol.DodajPracownika(p);
            lista.Add(p);
        }

        public void Dalej(object sender, RoutedEventArgs e)
        {
            WindowTerminarz okno = new WindowTerminarz();
            okno.ShowDialog();
        }

        public void Lista(object sender, SelectionChangedEventArgs e)
        {
            

        }



    }
}

