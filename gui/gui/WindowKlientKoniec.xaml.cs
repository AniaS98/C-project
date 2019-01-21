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
    /// Logika interakcji dla klasy WindowKlientKoniec.xaml
    /// </summary>
    public partial class WindowKlientKoniec : Window
    {
        public WindowKlientKoniec(string nrZamowienia)
        {
            InitializeComponent();
            NrZamowienia.Text = nrZamowienia;
        }

        private void Button_Potwierdz(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
