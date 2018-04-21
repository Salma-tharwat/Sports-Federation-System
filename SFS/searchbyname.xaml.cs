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
    /// Interaction logic for searchbyname.xaml
    /// </summary>
    public partial class searchbyname : Window
    {
        public searchbyname()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            mainqueryform ma = new mainqueryform();
            ma.Show();
            this.Close();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            List<Player> l = Containers.Player_list;
            for (int i = 0; i < l.Count; i++)
            {
                for (int j = i + 1; j < l.Count; j++)
                {
                    if (l[i].get_results() > l[j].get_results())
                    {
                        Player tmp = l[i];
                        l[i] = l[j];
                        l[j] = tmp;
                    }
                }
            }



            List<string> xname = new List<string>();
            List<int> xresult = new List<int>();




            for (int i = 0; i < l.Count; i++)
            {
                for (int j = 0; j < l[i].champion.Count; j++)
                {
                    if (l[i].champion[j].getName() == textBox.Text)
                    {
                        xname.Add(l[i].getName());
                        xresult.Add(l[i].get_results());
                        textBox1.Text = l[i].champion[j].Gettype();
                        textBox2.Text = l[i].champion[j].GetPlace();


                    }
                }


                listBox.ItemsSource = xname;
                listBox1.ItemsSource = xresult;



            }
        }
    }
}
    

