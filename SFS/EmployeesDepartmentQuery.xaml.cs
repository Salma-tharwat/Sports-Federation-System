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
    /// Interaction logic for EmployeesDepartmentQuery.xaml
    /// </summary>
    public partial class EmployeesDepartmentQuery : Window
    {
        public EmployeesDepartmentQuery()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
             List<Employee> filter = new List<Employee>();

            for(int i=0;i<Containers.Employee_list.Count();i++)
            {
                if(Containers.Employee_list[i].GetDepartment()==textBox.Text)
                {
                    filter.Add(Containers.Employee_list[i]);
                }
            }
            EmployeesDepartmentDataG edg = new EmployeesDepartmentDataG();
            edg.Show();
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
