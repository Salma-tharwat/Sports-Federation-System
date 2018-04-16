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
    /// Interaction logic for Loginas.xaml
    /// </summary>
    public partial class Loginas : Window
    {
        public Loginas()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mn = new MainWindow();
            mn.Show();
            this.Close();

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            employeelogin o = new employeelogin();
            o.Show();
            this.Close();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            employeelogin ep = new employeelogin();
                ep.Show();

            AccountingOptionForm op = new AccountingOptionForm();
            op.Show();
            this.Close();
        }
    }
}
