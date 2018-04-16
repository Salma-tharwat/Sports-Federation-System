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
    /// Interaction logic for TeamChampionShipsQuery.xaml
    /// </summary>
    public partial class TeamChampionShipsQuery : Window
    {
        public TeamChampionShipsQuery()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            List<Team> filtered = new List<Team>();
            for(int i=0;i<Containers.championship_list.Count();i++)
            {
                if(Containers.championship_list[i].getName()==textBox.Text  && Containers.championship_list[i].GetPlace()==textBox1.Text)
                {
                    filtered = Containers.championship_list[i].teamList;
                }
               
            }
            ChampionshipTeamsDatagrid cd = new ChampionshipTeamsDatagrid();
            cd.Show();
            this.Close();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            mainqueryform mq = new mainqueryform();
            mq.Show();
            this.Close();
        }
    }
}
