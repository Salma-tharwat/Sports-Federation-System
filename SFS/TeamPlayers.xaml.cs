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
    /// Interaction logic for TeamPlayers.xaml
    /// </summary>
    public partial class TeamPlayers : Window
    {
        public TeamPlayers()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {

            if (textBox.Text == "")
            {
                MessageBox.Show("Please fill the required information");
            }
            else
            {
                List<string> tname = new List<string>();

                for (int i = 0; i < Containers.Player_list.Count; i++)
                {
                    if (Containers.Player_list[i].get_teamname() == textBox.Text)
                    {
                        tname.Add(Containers.Player_list[i].getName());

                    }

                }
                listBox.ItemsSource = tname;

            }
          

        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {

           
            List<string> tname = new List<string>();
           
            for (int i = 0; i < Containers.Player_list.Count; i++)
            {
               
               
                    tname.Add(Containers.Player_list[i].getName());
                   

            }
            listBox.ItemsSource = tname;
            
        }
    }
    }
    
