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
    /// Logika interakcji dla klasy WindowBlad.xaml
    /// </summary>
    public partial class WindowBlad : Window
    {
        public WindowBlad()
        {
            InitializeComponent();
        }

        private void powrot(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void zaloguj_ponownie(object sender, RoutedEventArgs e)
        {
            this.Close();
            WindowLogin okno = new WindowLogin();
            okno.ShowDialog();
        }
    }
}
