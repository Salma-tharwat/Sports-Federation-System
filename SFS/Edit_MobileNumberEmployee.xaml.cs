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
    /// Interaction logic for Edit_MobileNumberEmployee.xaml
    /// </summary>
    public partial class Edit_MobileNumberEmployee : Window
    {
        public Edit_MobileNumberEmployee()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, TextChangedEventArgs e)
        {
           
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Edit_Employee ee = new Edit_Employee();
            ee.Show();
            this.Hide();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            bool mobilee = false;
            for (int i = 0; i < Containers.Employee_list.Count(); i++)
            {
                if (Containers.Employee_list[i].getmobile() == textBox1.Text)
                    mobilee = true;
            }

            if (textBox1.Text == "" || mobile.Text == "")
            {
                MessageBox.Show("Please fill the required information !");
            }
            else if (mobilee == true)
            {
                MessageBox.Show("Mobile number is already registered !");
            }
            else if (textBox1.Text == mobile.Text)
            {
                MessageBox.Show("Please enter a diffrent Mobile Number!");
                textBox1.Clear();
                mobile.Clear();
            }
            else
            {
                for (int i = 0; i < Containers.Employee_list.Count; i++)
                {
                    if (Containers.Employee_list[i].getId().ToString() == Enter_ID_Employee.employeeeid)
                    {
                        Containers.Employee_list[i].setmobile(mobile.Text);
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
        private void button3_Click(object sender, RoutedEventArgs e)
        {
            adminoptions o = new adminoptions();
            o.Show();
            this.Close();
        }
        
    }
}
