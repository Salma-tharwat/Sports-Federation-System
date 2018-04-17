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
    /// Interaction logic for ChampionshipTeamsDatagrid.xaml
    /// </summary>
    public partial class ChampionshipTeamsDatagrid : Window
    {
        public ChampionshipTeamsDatagrid()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            TeamChampionShipsQuery ts = new TeamChampionShipsQuery();
            ts.Show();
            this.Close();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            List<string> filtered_name = new List<string>();
            List<string> filtered_age = new List<string>();

            for (int i = 0; i < Containers.championship_list.Count(); i++)
            {
                if (Containers.championship_list[i].getName() == TeamChampionShipsQuery.name && Containers.championship_list[i].GetPlace() == TeamChampionShipsQuery.place)
                {
                    for(int j=0;j<Containers.championship_list[i].teamList.Count();j++)
                    {
                        filtered_name.Add(Containers.championship_list[i].teamList[j].getTeam());
                        filtered_age.Add(Containers.championship_list[i].teamList[j].getage());
                    }
                    
                }

            }
            listBox.ItemsSource = filtered_name;
            listBox1.ItemsSource = filtered_age;
        }
    }
}
