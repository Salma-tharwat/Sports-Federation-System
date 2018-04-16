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
    /// Interaction logic for Search_Championship.xaml
    /// </summary>
    public partial class Search_Championship : Window
    {
        public Search_Championship()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            List<Championships> filtered = new List<Championships>();
            if (textBox.Text=="")
            {
                MessageBox.Show("Please fill the required information");
            }
            for ( int i=0 ;i <Containers.championship_list.Count;i++)
            {
                if (Containers.championship_list[i].GetPlace()==textBox.Text)
                {
                    filtered.Add(Containers.championship_list[i]);
                }
               
            }
        }
    }
}
