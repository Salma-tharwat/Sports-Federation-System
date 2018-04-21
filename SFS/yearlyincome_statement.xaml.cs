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
    /// Interaction logic for yearlyincome_statement.xaml
    /// </summary>
    public partial class yearlyincome_statement : Window
    {
        int total_income = Bsponsor.best_sponsor;
        public yearlyincome_statement()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            List<string> months = new List<string>();
            List<int> monthly_expense = new List<int>();
            months.Add("January");
            months.Add("February");
            months.Add("March");
            months.Add("April");
            months.Add("May");
            months.Add("June");
            months.Add("July");
            months.Add("August");
            months.Add("September");
            months.Add("October");
            months.Add("November");
            months.Add("December");
            int total_expense = 0;
            for(int i=0;i<12;i++)
            {
                int sum = 0;
                for(int j=0;j<Expense.expense_list.Count();j++)
                {
                    if (Expense.expense_list[j].get_expense_month() == months[i])
                    {
                        sum += Expense.expense_list[j].get_value();
                    }
                    monthly_expense.Add(sum);
                    total_expense += sum;
                    sum = 0;
                }
            }
            listBox.ItemsSource = months;
            listBox1.ItemsSource = monthly_expense;
            textBox1.Text = total_expense.ToString();
            textBox.Text = total_income.ToString();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            AccountingOptionForm ao = new AccountingOptionForm();
            ao.Show();
            this.Close();
        }
    }
}
