﻿using System;
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
using test.repository;
using test.model;
using static System.Object;
using static System.Windows.Forms.TabControl;

namespace test
{
    /// <summary>
    /// Interaction logic for lihatakun.xaml
    /// </summary>
     
    
    public partial class lihatakun : Window
    {
        private Akun lakun = new Akun();
        private IAkunRepository lakurep = new AkunRepository();
        public lihatakun()
        {
            InitializeComponent();
        }

        private void ladit_click(object sender, RoutedEventArgs e)
        {
            editpegawai dipeg = new editpegawai();
            dipeg.Show();
        }

        void DataGrid_LoadingRow(object sender, DataGridRowEventArgs e)
        {
            e.Row.Header = (e.Row.GetIndex() + 1).ToString();

        }
    }
}
