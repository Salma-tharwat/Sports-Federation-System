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
    /// Interaction logic for Edit_Avaliable.xaml
    /// </summary>
    public partial class Edit_Avaliable : Window
    {
        public Edit_Avaliable()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
           string avail ="";
            if (yes.IsChecked == true)
                avail = "Available";
            if ((yes.IsChecked == true) && (no.IsChecked == true))
                MessageBox.Show("Please fill the required information !");

            else
            {
                for (int i = 0; i < Containers.Employee_list.Count; i++)
                {
                    if (Containers.Employee_list[i].getId().ToString() == Enter_ID_Employee.employeeeid)
                    {
                        Containers.Employee_list[i].setStatus(avail);
                    }

                }
                if (File.Exists("Employees.xml"))
                {
                    File.Delete("Employees.xml");
                }

                for (int i = 0; i < Containers.Employee_list.Count; i++)
                {
                    Containers.write_Employee(Containers.Employee_list[i]);

                }
                MessageBox.Show("Changes Done");
                this.Hide();
            }





        }

        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {
            Edit_Employee oo = new Edit_Employee();
            oo.Show();
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            adminoptions o = new adminoptions();
            o.Show();
            this.Close();
        }
    }
}
