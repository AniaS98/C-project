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


namespace gui
{
    /// <summary>
    /// Logika interakcji dla klasy WindowKlient.xaml
    /// </summary>
    public partial class WindowKlient : Window
    {
        public WindowKlient()
        {
            InitializeComponent();
        }

        private void Button_Wstecz(object sender, RoutedEventArgs e)
        {
            MainWindow okno = new MainWindow();
            okno.ShowDialog();
        }

        private void Button_Dalej(object sender, RoutedEventArgs e)
        {
            WindowKlientZamowienie okno = new WindowKlientZamowienie();
            okno.ShowDialog();
        }
    }
}
