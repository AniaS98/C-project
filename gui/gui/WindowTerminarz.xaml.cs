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
    /// Logika interakcji dla klasy WindowTerminarz.xaml
    /// </summary>
    public partial class WindowTerminarz : Window
    {
      

        public WindowTerminarz()
        {
            InitializeComponent();
            //lista = new ObservableCollection<>();
            //listbox_terminarz.ItemsSource = lista;
        }

        private void Powrot(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
