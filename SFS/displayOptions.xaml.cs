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
    /// Interaction logic for displayOptions.xaml
    /// </summary>
    public partial class displayOptions : Window
    {
        public displayOptions()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (comboBox.Text == "Employees")
            {
                Display_Employee dp = new Display_Employee();
                dp.Show();
                this.Close();
            }
            else if (comboBox.Text == "ChampionShip")
            {
                Display_Championshsips dc = new Display_Championshsips();
                dc.Show();
                this.Close();
            }
            else if (comboBox.Text == "Coaches")
            {
                Display_Coaches dc = new Display_Coaches();
                dc.Show();
                this.Close();
            }
            else if (comboBox.Text == "Club")
            {
                Display_Club dcc = new Display_Club();
                dcc.Show();
                this.Close();
            }
            else if (comboBox.Text == "Sponsors")
            {
                Display_Sponsers ds = new Display_Sponsers();
                ds.Show();
                this.Close();
            }
            //players n2sa       
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Options o = new Options();
            o.Show();
            this.Close();
        }
    }
}
