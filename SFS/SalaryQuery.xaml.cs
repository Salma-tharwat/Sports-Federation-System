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
    /// Interaction logic for SalaryQuery.xaml
    /// </summary>
    public partial class SalaryQuery : Window
    {
        public SalaryQuery()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            List<Employee> filtered = new List<Employee>();
            for(int i=0; i<Containers.Employee_list.Count();i++)
            {
                   if(comboBox.Text== "Less Than or Equal")
                          {
                             if(Containers.Employee_list[i].getSalary()<=int.Parse(SalaryComparasionValue.Text))
                                 {
                        filtered.Add(Containers.Employee_list[i]);
                                  }
                          }
                   else if(comboBox.Text== "Greater Than or equal")
                {
                    if (Containers.Employee_list[i].getSalary() >= int.Parse(SalaryComparasionValue.Text))
                    {
                        filtered.Add(Containers.Employee_list[i]);
                    }
                }
                   else if(comboBox.Text== "Greater than")
                {
                    if (Containers.Employee_list[i].getSalary() > int.Parse(SalaryComparasionValue.Text))
                    {
                        filtered.Add(Containers.Employee_list[i]);
                    }
                }
                   else if(comboBox.Text== "Less than")
                {
                    if (Containers.Employee_list[i].getSalary() < int.Parse(SalaryComparasionValue.Text))
                    {
                        filtered.Add(Containers.Employee_list[i]);
                    }
                }
                   else if(comboBox.Text== "Equal")
                {
                    if (Containers.Employee_list[i].getSalary() == int.Parse(SalaryComparasionValue.Text))
                    {
                        filtered.Add(Containers.Employee_list[i]);
                    }
                }

            }
            
            SalaryQueryDataGrid sd = new SalaryQueryDataGrid();
            sd.Show();
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
