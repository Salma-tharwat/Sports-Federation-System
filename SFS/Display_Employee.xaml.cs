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
    /// Interaction logic for Display_Employee.xaml
    /// </summary>
    public partial class Display_Employee : Window
    {
        public Display_Employee()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if (textBox.Text == "")
            {
                MessageBox.Show("Please fill the required information");
            }
            List<int> working_year = new List<int>();
            List<string> employment_date = new List<string>();
            List<string> Status = new List<string>();
            List<string> department = new List<string>();
            for (int i = 0; i < Containers.Employee_list.Count; i++)
            {
                if (Containers.Employee_list[i].getId() == textBox.Text)
                {
                    working_year.Add(Containers.Employee_list[i].getWorking_Year());
                    employment_date.Add(Containers.Employee_list[i].getEmployment_date());
                    Status.Add(Containers.Employee_list[i].GetStatus());
                    department.Add(Containers.Employee_list[i].GetDepartment());
                }
                listBox.ItemsSource = working_year;
                listBox1.ItemsSource = employment_date;
                listBox2.ItemsSource = Status;
                listBox3.ItemsSource = department;
            }
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {

            if (textBox.Text == "")
            {
                List<int> working_year = new List<int>();
                List<string> employment_date = new List<string>();
                List<string> Status = new List<string>();
                List<string> department = new List<string>();
                for (int i = 0; i < Containers.Employee_list.Count; i++)
                {

                    working_year.Add(Containers.Employee_list[i].getWorking_Year());
                    employment_date.Add(Containers.Employee_list[i].getEmployment_date());
                    Status.Add(Containers.Employee_list[i].GetStatus());
                    department.Add(Containers.Employee_list[i].GetDepartment());
                }
                listBox.ItemsSource = working_year;
                listBox1.ItemsSource = employment_date;
                listBox2.ItemsSource = Status;
                listBox3.ItemsSource = department;
            }
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            displayOptions m = new displayOptions();
            m.Show();
            this.Close();
        
    }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            adminoptions o = new adminoptions();
            o.Show();
            this.Close();
        }
    }
}
