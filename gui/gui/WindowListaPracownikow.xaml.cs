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
using System.Media;
using System.IO;
using System.Xml.Serialization;

namespace gui
{
    /// <summary>
    /// Logika interakcji dla klasy WindowListaPracownikow.xaml
    /// </summary>
    partial class WindowListaPracownikow : Window
    {
        public Zespol zespol = Zespol.OdczytajJSON("zespol.json");
        //public Zespol zespol= new Zespol("Pudelko");
        public Pracownik p1 = new Pracownik("Jan", "Kot", "11111111111", Plcie.M);
        public ObservableCollection <Pracownik> lista;
        //zespol.DodajPracownika(p1);

        public WindowListaPracownikow()
        {
            InitializeComponent();
            //lista = new ObservableCollection<Pracownik>();
            listbox_zespol.ItemsSource = zespol.pracownicy;
        }

       public  void Dodaj(object sender, RoutedEventArgs e)
        {
            Pracownik p = new Pracownik("","","",Plcie.K);
            WindowDodajPracownika okno = new WindowDodajPracownika(p);
            okno.ShowDialog();
            p.PrzeliczenieKalendarza();
            zespol.DodajPracownika(p);
            lista.Add(p);

            zespol.ZapiszJSON("zespol.json");
        }

        public void Dalej(object sender, RoutedEventArgs e)
        {
            this.Close();
            try
            {
                WindowTerminarz okno = new WindowTerminarz(zespol.pracownicy[listbox_zespol.SelectedIndex]);
                okno.ShowDialog();
            }
            catch(ArgumentOutOfRangeException)
            {
                SystemSounds.Exclamation.Play();
                MessageBox.Show("Nie wybrano żadnego pracownika.");
            }
        }

        public void Lista(object sender, SelectionChangedEventArgs e)
        {
            listbox_zespol.SelectionMode = SelectionMode.Single;
        }




    }
}

