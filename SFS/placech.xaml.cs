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
    /// Interaction logic for placech.xaml
    /// </summary>
    public partial class placech : Window
    {
        public placech()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            
            List<Championships> l = Containers.championship_list;
            List<string> ttype = new List<string>();
            List<string> tplace = new List<string>();

            for (int i = 0; i < Containers.championship_list.Count; i++)
            {
                if (l[i].GetPlace() == textBox.Text)
                {
                    ttype.Add(l[i].Gettype());
                    tplace.Add(l[i].GetPlace());

                }
            }

            listBox.ItemsSource = ttype;
            listBox1.ItemsSource = tplace;

        }
        
           
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            mainqueryform mq = new mainqueryform();
            mq.Show();
            this.Close();

        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
    }

