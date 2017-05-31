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

namespace test
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class login : Window
    {
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        string ConnectionString = @"Data Source=C:\Users\Owner\Documents\Visual Studio 2015\Projects\test\psbo.db;Version=3;";

        private void login1_Click(object sender, RoutedEventArgs e)
        {
            SQLiteConnection sqliteCon = new SQLiteConnection(ConnectionString);
            try
            {
                sqliteCon.Open();
                string Query = "SELECT [id_admin],[username],[password] FROM [akun] where username ='" + this.username.Text + "' and password='" + this.password.Password + "' ";
                SQLiteCommand createCommand = new SQLiteCommand(Query, sqliteCon);

                createCommand.ExecuteNonQuery();
                SQLiteDataReader dr = createCommand.ExecuteReader();

                int count = 0;
                while (dr.Read())
                {
                    count++;
                }
                if (count == 1)
                { 
                    mainadmin tampil = new mainadmin();
                    tampil.Show();
                    this.Close();
                }
                if (count < 1)
                {
                    MessageBox.Show("Username and password is not correct");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
