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
    /// Interaction logic for Enter_ID_Employee.xaml
    /// </summary>
    public partial class Enter_ID_Employee : Window
    {
        public static string employeeeid;
        public Enter_ID_Employee()
        {
            InitializeComponent();
        }

        private void delete_Click(object sender, RoutedEventArgs e)
        {
            employeeeid = id.Text;

            bool find = false;
            for (int i = 0; i < Containers.Employee_list.Count; i++)
            {
                if (Containers.Employee_list[i].getId() == id.Text)
                {
                    Containers.Employee_list.Remove(Containers.Employee_list[i]);
                    
                    find = true;
                }
            }
            if (find == false)
            {
                MessageBox.Show("Wrong ID");
            }
            else
            {

                if (File.Exists("Employees.xml"))
                {
                    File.Delete("Employees.xml");
                }

                for (int i = 0; i < Containers.Employee_list.Count; i++)
                {
                    Containers.write_Employee(Containers.Employee_list[i]);

                }

                MessageBox.Show("Employee Successfuly Deleted");
            }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            adminoptions ed = new adminoptions();
            ed.Show();
            this.Close();

        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            employeeeid = id.Text;
            Edit_Employee eee = new SFS.Edit_Employee();
            eee.Show();
            this.Close();

        }

        private void id_Copy_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void button4_Click(object sender, RoutedEventArgs e)
        {
            adminoptions o = new adminoptions();
            o.Show();
            this.Close();
        }
    }
}
