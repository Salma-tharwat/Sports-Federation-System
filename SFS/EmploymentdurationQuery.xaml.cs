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
    /// Interaction logic for EmploymentdurationQuery.xaml
    /// </summary>
    public partial class EmploymentdurationQuery : Window
    {
        public EmploymentdurationQuery()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            List<Employee> filtered = new List<Employee>();
            for(int i=0;i<Containers.Employee_list.Count();i++)
            {
                int x = Containers.Employee_list[i].Working_year_calc();
                if (x.ToString()==textBox.Text)
                {
                    filtered.Add(Containers.Employee_list[i]);
                }
            }
            EmployeeEmploymentDateDG dd = new EmployeeEmploymentDateDG();
            dd.Show();
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
