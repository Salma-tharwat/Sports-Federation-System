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
    /// Interaction logic for adminoptions.xaml
    /// </summary>
    public partial class adminoptions : Window
    {
        public adminoptions()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Enter_ID_Employee ed = new Enter_ID_Employee();
            ed.Show();
            this.Close();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            Enter_ID_Employee ed = new Enter_ID_Employee();
            ed.Show();
            this.Close();

        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            Loginas lgn = new Loginas();
            lgn.Show();
            this.Close();
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            mainqueryform m = new mainqueryform();
            m.Show();
            this.Close();
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            displayOptions dp = new displayOptions();
            dp.Show();
            this.Close();
        }

        private void button5_Click_1(object sender, RoutedEventArgs e)
        {
            searchoptions dp = new searchoptions();
            dp.Show();
            this.Close();
           
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
           Add_Options a = new Add_Options();
            a.Show();
            this.Close();

        }

        private void button8_Click(object sender, RoutedEventArgs e)
        {
            adminlogin.admin = false;
            MainWindow sh = new MainWindow();
            sh.Show();
            this.Close();
        }
    }
}
