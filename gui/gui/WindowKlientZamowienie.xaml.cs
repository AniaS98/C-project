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
    /// Logika interakcji dla klasy WindowKlientZamowienie.xaml
    /// </summary>
    public partial class WindowKlientZamowienie : Window
    {
        public WindowKlientZamowienie()
        {
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
            WindowKlientAlergeny okno = new WindowKlientAlergeny();
            okno.ShowDialog();
        }
    }
}
