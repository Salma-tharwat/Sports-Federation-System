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

namespace SFS
{
    /// <summary>
    /// Interaction logic for Display_Championshsips.xaml
    /// </summary>
    public partial class Display_Championshsips : Window
    {
        public Display_Championshsips()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            adminoptions m = new adminoptions();
            m.Show();
            this.Close();
    }
        private void button2_Click(object sender, RoutedEventArgs e)
        {
        if (textBox.Text == "")
        {
            List<string> name = new List<string>();
            List<string> place = new List<string>();
            List<string> type = new List<string>();
            List<string> senior = new List<string>();
            List<int> results = new List<int>();
            for (int i = 0; i < Containers.championship_list.Count; i++)
            {
                name.Add(Containers.championship_list[i].getName());
                place.Add(Containers.championship_list[i].GetPlace());
                type.Add(Containers.championship_list[i].Gettype());
                senior.Add(Containers.championship_list[i].getSenior());
                results.Add(Containers.championship_list[i].Getresults());
            }
            listBox.ItemsSource = name;
            listBox1.ItemsSource = type;
            listBox2.ItemsSource = place;
            listBox3.ItemsSource = senior;
            listBox4.ItemsSource = results;

        }
        }

        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void textBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            displayOptions z = new displayOptions();
            z.Show();
            this.Close();

        }
    }
}
