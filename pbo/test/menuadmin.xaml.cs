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
using System.Data.SQLite;
using System.Data;

namespace test
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class menuadmin : Window
    {
        public menuadmin()
        {
            InitializeComponent();
        }

        private void mini_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void quit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void logout_Click(object sender, RoutedEventArgs e)
        {
            login tampil = new login();
            tampil.Show();
            this.Close();
        }

        private void tambah_Click(object sender, RoutedEventArgs e)
        {
            tambahpegawai tampil = new tambahpegawai();
            tampil.Show();
        }


        string ConnectionString = @"Data Source=C:\Users\Owner\Documents\Visual Studio 2015\Projects\PSBO-Sayang\pbo\psbo.db;Version=3;";

        private void lihat_Click(object sender, RoutedEventArgs e)
        {
            SQLiteConnection sqliteCon = new SQLiteConnection(ConnectionString);
            try
            {
                sqliteCon.Open();
                SQLiteCommand createCommand = new SQLiteCommand(sqliteCon);
                createCommand.CommandText = "SELECT * FROM [daftarpegawai]";

                createCommand.ExecuteNonQuery();
                System.Data.DataSet dst = new System.Data.DataSet();
                System.Data.DataTable dt = new System.Data.DataTable();
                SQLiteDataAdapter dr = new SQLiteDataAdapter(createCommand);
                dr.Fill(dt);
                dataGrid.ItemsSource = dt.AsDataView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
