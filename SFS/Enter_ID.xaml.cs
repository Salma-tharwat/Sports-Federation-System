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
    /// Interaction logic for Enter_ID.xaml
    /// </summary>
   
    public partial class Enter_ID : Window
    {
        public static string playerid;
        public Enter_ID()
        {
            InitializeComponent();
        }

        private void delete_Click(object sender, RoutedEventArgs e)
        {
           
            bool find = false;
            for (int i = 0; i < Containers.Player_list.Count; i++)
            {
                if (Containers.Player_list[i].getId() == id.Text)
                {
                    Containers.Player_list.Remove(Containers.Player_list[i]);
                    find = true;
                }
            }
            if (find == false)
            {
                MessageBox.Show("Wrong ID");
            }
            else
            {
                if (File.Exists("Players.xml"))
                {
                    File.Delete("Players.xml");
                }

                for (int i = 0; i < Containers.Player_list.Count; i++)
                {
                    Containers.write_Player(Containers.Player_list[i]);

                }
                
                MessageBox.Show("Successfuly Deleted");
            }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            adminoptions oo = new adminoptions();
            oo.Show();
            this.Close();
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
              playerid=id.Text;
        Edit_Player p=new Edit_Player();
            p.Show();
        }
        private void button4_Click(object sender, RoutedEventArgs e)
        {
            adminoptions o = new adminoptions();
            o.Show();
            this.Close();
        }
    }
}
