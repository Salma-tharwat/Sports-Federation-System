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
    /// Interaction logic for Add_Expense.xaml
    /// </summary>
    public partial class Add_Expense : Window
    {
        public Add_Expense()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            AccountingOptionForm ac = new AccountingOptionForm();
            ac.Show();
            this.Close();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Expense ex = new Expense(int.Parse(textBox.Text), expense_month.Text, textBlock.Text);
            ex.write_expense();
            MessageBox.Show("Expense Successfully Added !");
        }
    }
}
