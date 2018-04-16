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
    /// Interaction logic for QueryChampionShips_RESULTS_.xaml
    /// </summary>
    public partial class QueryChampionShips_RESULTS_ : Window
    {
        public QueryChampionShips_RESULTS_()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if(Max_res.IsChecked==true)
            {
                Championships max = new Championships();
                int maxx_res = 0;
                for(int i=0;i<Containers.championship_list.Count();i++)
                {
                    if(Containers.championship_list[i].Getresults()>=maxx_res)
                    {
                        maxx_res = Containers.championship_list[i].Getresults();
                        max = Containers.championship_list[i];
                    }
                }
                MessageBox.Show(max.getName() + ' ' + max.GetPlace());
            }
            if (Min_Res.IsChecked == true)
            {
                Championships min = new Championships();
                int minn_res = 1000000;
                for (int i = 0; i < Containers.championship_list.Count(); i++)
                {
                    if (Containers.championship_list[i].Getresults() <= minn_res)
                    {
                        minn_res = Containers.championship_list[i].Getresults();
                        min = Containers.championship_list[i];
                    }
                }
                MessageBox.Show(min.getName() + ' ' + min.GetPlace());
            }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            mainqueryform mq = new mainqueryform();
            mq.Show();
            this.Close();
        }
    }
}
