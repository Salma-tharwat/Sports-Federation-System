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

namespace SFS
{
    /// <summary>
    /// Interaction logic for SalaryQuery.xaml
    /// </summary>
    public partial class SalaryQuery : Window
    {
        public static float value = 0;
        public static string query = "";

        public SalaryQuery()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            value = float.Parse(SalaryComparasionValue.Text);
            query = comboBox.Text;
            SalaryQueryDataGrid sd = new SalaryQueryDataGrid();
            sd.Show();
            this.Close();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            mainqueryform mq = new mainqueryform();
            mq.Show();
            this.Close();
        }
    }
}
