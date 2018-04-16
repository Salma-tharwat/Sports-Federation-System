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
    /// Interaction logic for AGE.xaml
    /// </summary>
    public partial class AGE : Window
    {
        public AGE()
        {
            InitializeComponent();
        }

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }

        private void age1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            List<Player> l = Containers.Player_list;
              for (int i = 0; i < l.Count; i++)
              {
                  for (int j = i + 1; j < l.Count; j++)
                  {
                      if( l[i].ageCalculator() > l[i].ageCalculator())
                      {
                          Player temp = l[i];
                          l[i] = l[j];
                         l[j] = temp;
                      }
                  }
              }
              List<Player> juniors = new List<Player>();
              List<Player> seniors = new List<Player>();
              for(int i=0;i<l.Count;i++)
              {
                  if(l[i].ageCalculator()>=18)
                  {
                      seniors.Add(l[i]);
                  }
                  else
                  {
                      juniors.Add(l[i]);
                  }
              }
            textBox.Text = Containers.Player_list.Count.ToString();
            Player omar = new Player("omar","1111111111","mmmmmm","2222","aasdasd",12,12,"33123","33333");
            Containers.Player_list.Add(omar);

            List<int> tage = new List<int>();
            List<string> tname = new List<string>();
            for (int i = 0; i < l.Count; i++)
            {
                tage.Add(l[i].ageCalculator());
                tname.Add(l[i].getName());
            }
            listBox.ItemsSource = tname;
            listBox1.ItemsSource = tage;

        }

        private void ages_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void dataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void dataGrid_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }

        private void listView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}

   
