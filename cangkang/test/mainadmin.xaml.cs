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

namespace test
{
    /// <summary>
    /// Interaction logic for mainadmin.xaml
    /// </summary>
    public partial class mainadmin : Window
    {
        public mainadmin()
        {
            InitializeComponent();
        }

        private void logout_Copy_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            login tampil = new login();
            tampil.Show();
        }

        private void mini_Click(object sender, RoutedEventArgs e)
        {
              this.WindowState = WindowState.Minimized;
        }

        private void quit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void pegawai_Click(object sender, RoutedEventArgs e)
        {
            pegawai tampil = new pegawai();
            tampil.Show();
            this.Close();
        }

        private void home_Click(object sender, RoutedEventArgs e)
        {
            mainadmin tampil = new mainadmin();
            tampil.Show();
            this.Close();
        }
        private void logout_Click(object sender, RoutedEventArgs e)
        {
            login tampil = new login();
            tampil.Show();
            this.Close();
        }

    }
    
}
