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
    /// Interaction logic for employeelogin.xaml
    /// </summary>
    public partial class employeelogin : Window
    {
        public employeelogin()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Hide();
        }
        private void button2_Click(object sender, RoutedEventArgs e)
        {

        }
        private void button2_Click_1(object sender, RoutedEventArgs e)
        {
for(int i=0;i<Containers.Employee_list.Count;i++)
            {
                if(Containers.Employee_list[i].getId()== login.Text && Containers.Employee_list[i].Getpassword() == pass.Text)
                {
                    MessageBox.Show("Login Successfuly.");
                    if(Containers.Employee_list[i].GetDepartment()=="HR")
                    {
                            Options optionform = new Options();
                                 optionform.Show();
                    }
                    else if(Containers.Employee_list[i].GetDepartment()=="Accounting")
                    {
                        AccountingOptionForm af = new AccountingOptionForm();
                        af.Show();
                    }
                    this.Close();
                    break;
                }
            }
            MessageBox.Show("Wrong E-mail or Password!");

        }

        private void button1_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Show();
            this.Close();
        }
    }
    }

