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
    /// Interaction logic for AccountingOptionForm.xaml
    /// </summary>
    public partial class AccountingOptionForm : Window
    {
        public AccountingOptionForm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            Loginas lg = new Loginas();
            lg.Show();
            this.Close();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Add_Expense adde = new Add_Expense();
            adde.Show();
            this.Close();

        }
    }
}
