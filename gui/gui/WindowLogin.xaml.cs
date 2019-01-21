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
    /// Logika interakcji dla klasy WindowLogin.xaml
    /// </summary>
    public partial class WindowLogin : Window
    {
        public string login="admin";
        public string haslo="admin";


        public WindowLogin()
        {
            InitializeComponent();
        }

        public  void Zaloguj(object sender, RoutedEventArgs e)
        {
            if ((login == textbox_login.Text) && haslo == passwordbox_haslo.Password)
            {
                    this.Close();
                    WindowListaPracownikow okno = new WindowListaPracownikow();
                    okno.ShowDialog();
            }
            else
            {
                this.Close();
                WindowBlad okno = new WindowBlad();
                okno.ShowDialog();
            }
        }

        private void Powrot(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
