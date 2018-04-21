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
    /// Interaction logic for Edit_EmployeePassword.xaml
    /// </summary>
    public partial class Edit_EmployeePassword : Window
    {
        public Edit_EmployeePassword()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Edit_Employee s = new Edit_Employee();
            s.Show();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            bool found = false;
            if (textBox.Text == "" || password.Text == "")
            {
                MessageBox.Show("Please fill the required information !");
            }
            for (int i = 0; i < Containers.Employee_list.Count; i++)
            {
                if (Containers.Employee_list[i].getId().ToString() == Enter_ID_Employee.employeeeid)
                {
                    if (Containers.Employee_list[i].Getpassword() == password.Text)
                        found = true;
                    Containers.Employee_list[i].setpassword(password.Text);
                }

            }
            if (found == false)
            {
                MessageBox.Show("Wrong Password ");
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
                MessageBox.Show("Changes Done");
                this.Hide();
            }

        }
        private void button3_Click(object sender, RoutedEventArgs e)
        {
            adminoptions o = new adminoptions();
            o.Show();
            this.Close();
        }
    }
    
}
