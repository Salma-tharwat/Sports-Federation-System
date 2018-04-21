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
    /// Interaction logic for playersfiltration.xaml
    /// </summary>
    public partial class playersfiltration : Window
    {
        public playersfiltration()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            mainqueryform mq = new mainqueryform();
            mq.Show();
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



            List<string> pname = new List<string>();
            List<int> presult = new List<int>();
            List<string> pgender = new List<string>();
            List<string> page = new List<string>();


            
            for (int i = 0; i < l.Count; i++)
            {
                pname.Add(l[i].getName());
                presult.Add(l[i].get_results());
                pgender.Add(l[i].getGender());
                if (l[i].ageCalculator() >= 18)
                {
                    page.Add("Senior");
                }
                else
                    page.Add("Jusnior");

            }



            listBox.ItemsSource = pname;
            listBox1.ItemsSource = presult;
            listBox3.ItemsSource = pgender;
            listBox2.ItemsSource = page;



        }
    }
}
