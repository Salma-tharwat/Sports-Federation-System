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
using System.Xml;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Drawing;
using System.Data;
namespace SFS
{
    /// <summary>
    /// Interaction logic for Edit_PlayerMobileNumber.xaml
    /// </summary>
    public partial class Edit_PlayerMobileNumber : Window
    {
        public Edit_PlayerMobileNumber()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Edit_Player ep = new Edit_Player();
            ep.Show();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            bool mobiles = false;
            for (int i = 0; i < Containers.Player_list.Count(); i++)
            {
                if (Containers.Player_list[i].getmobile() == mobilee.Text)
                    mobiles = true;
            }
           
            if (textBox1.Text == "" || mobilee.Text == "")
            {
                MessageBox.Show("Please fill the required information !");
            }
           else if (mobiles == true)
            {
                MessageBox.Show("Mobile number is already registered !");
            }
            else if (textBox1.Text == mobilee.Text)
            {
                MessageBox.Show("Please enter a diffrent Mobile Number!");
                textBox1.Clear();
                mobilee.Clear();
            }
            else
            {
                for (int i = 0; i < Containers.Player_list.Count; i++)
                {
                    if (Containers.Player_list[i].getId().ToString() == Enter_ID.playerid)
                    {
                        Containers.Player_list[i].setmobile(mobilee.Text);
                    }

                }
                if (File.Exists("Players.xml"))
                {
                    File.Delete("Players.xml");
                }

                for (int i = 0; i < Containers.Player_list.Count; i++)
                {
                    Containers.write_Player(Containers.Player_list[i]);

                }
                MessageBox.Show("Changes Done");
                this.Hide();
            }

        }

        private void textBox1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void button3_Click(object sender, RoutedEventArgs e)
        {
            adminoptions o = new adminoptions();
            o.Show();
            this.Close();
        }
    }
}
