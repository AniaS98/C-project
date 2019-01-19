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
    public partial class WindowKlientAlergeny : Window
    {
        Dieta dieta = new Dieta();
        ObservableCollection<SAlergen> lista;

        public WindowKlientAlergeny()
        {
            InitializeComponent();
            lista = new ObservableCollection<SAlergen>();
            dieta = (Dieta)Dieta.OdczytajXML("dieta2.xml"); //tu właściwa ścieżka!
            lista = new ObservableCollection<SAlergen>(dieta.ERodzajAlergenu);

        }
    }
}
