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
    /// Interaction logic for Add_Employee.xaml
    /// </summary>
    public partial class Add_Employee : Window
    {
        public Add_Employee()
        {
            InitializeComponent();
        }

        private void ADD_Click(object sender, RoutedEventArgs e)
        {
            bool mobile = false;
            if (Name.Text == "" || number.Text == "" || Salary.Text == "" || Emplyedate.Text == "" || Date.Text == "" || Department.Text == "")
            {
                MessageBox.Show("Please fill the required information !");
            }
            else if ((Male.IsChecked == true) && (Female.IsChecked == true))
                MessageBox.Show("Please fill the required information !");
            else if ((Yes.IsChecked == true) && (No.IsChecked == true))
                MessageBox.Show("Please fill the required information !");
            else if (mobile == true)
            {
                MessageBox.Show("Mobile number is already registered !");
            }
            else
            {
                string dep = "";
                if (Department.Text == "HR")
                {
                    if (adminlogin.admin == true)
                    {
                        dep = "HR";
                    }
                }
                else if (Department.Text == "Coach")
                {
                    dep = "Coach";
                }
                else if (Department.Text == "Accounting")
                {
                    dep = "Accounting";
                }
                string gender = "";
                string med;
                string avail;
                int y = int.Parse(Emplyedate.Text.Substring(6));
                int x = 0;
                int sal = int.Parse(Salary.Text);

                string working_years = "0";
                
               
                // string ID =  Name.Text.ElementAt(0)+ Name.Text.ElementAt(1) +Date.Text.ElementAt(6) + Date.Text.ElementAt(7);
                string temp = Date.Text;
                string temp2 = Name.Text;
                string id = temp2[0].ToString() + temp2[1].ToString() + temp[6].ToString() + temp[7].ToString();
                //  MessageBox.Show(id);

                for (int i = 0; i < Containers.Employee_list.Count(); i++)
                {
                    if (Containers.Employee_list[i].getmobile() == number.Text)
                        mobile = true;
                }

                if (Male.IsChecked == true)
                    gender = "Male";
                else gender = "Female";

                if (Yes.IsChecked == true)
                    med = "YES";
                else
                    med = "NO";

                if (Yes3.IsChecked == true)
                    avail = "Yes";
                else avail = "No";
                if (dep != "")
                {

                    if (!File.Exists("Employees.xml"))
                    {
                        XmlTextWriter document = new XmlTextWriter("Employees.xml", Encoding.UTF8);

                        document.Formatting = Formatting.Indented;
                        document.WriteStartDocument();
                        document.WriteStartElement("Employees");
                        document.WriteStartElement("Employee");
                        document.WriteStartElement("Employee_Name");
                        document.WriteString(Name.Text);
                        document.WriteEndElement();

                        document.WriteStartElement("Employment_ID");
                        document.WriteString(id);
                        document.WriteEndElement();

                        document.WriteStartElement("Mobile_Number");
                        document.WriteString(number.Text);
                        document.WriteEndElement();

                        document.WriteStartElement("Gender");
                        document.WriteString(gender);
                        document.WriteEndElement();

                        document.WriteStartElement("Medical_Form");
                        document.WriteString(med);
                        document.WriteEndElement();

                        document.WriteStartElement("Salary");
                        document.WriteString(Salary.Text);
                        document.WriteEndElement();

                        document.WriteStartElement("Bonus");
                        document.WriteString(x.ToString());
                        document.WriteEndElement();

                        document.WriteStartElement("Employement_Date");
                        document.WriteString(Emplyedate.Text);
                        document.WriteEndElement();

                        document.WriteStartElement("Working_Years");
                        document.WriteString(working_years);
                        document.WriteEndElement();

                        document.WriteStartElement("Date_of_birth");
                        document.WriteString(Date.Text);
                        document.WriteEndElement();

                        document.WriteStartElement("Available");
                        document.WriteString(avail);
                        document.WriteEndElement();

                        document.WriteStartElement("Department");
                        document.WriteString(dep);
                        document.WriteEndElement();

                        document.WriteStartElement("Password");
                        document.WriteString(password.Text);
                        document.WriteEndElement();

                        document.WriteEndElement();
                        document.WriteEndElement();
                        document.WriteEndDocument();

                        document.Close();

                        MessageBox.Show("Employee Successfuly Added.");
                    }
                    else

                    {
                        XmlDocument doc = new XmlDocument();
                        doc.Load("Employees.xml");

                        XmlNode employee = doc.CreateElement("Employee");

                        XmlNode Employee_Name = doc.CreateElement("Employee_Name");
                        Employee_Name.InnerText = Name.Text;
                        employee.AppendChild(Employee_Name);

                        XmlNode Employee_ID = doc.CreateElement("Employeement_ID");
                        Employee_ID.InnerText = id;
                        employee.AppendChild(Employee_ID);

                        XmlNode MobileNum = doc.CreateElement("Mobile_Number");
                        MobileNum.InnerText = number.Text;
                        employee.AppendChild(MobileNum);

                        XmlNode Genderr = doc.CreateElement("Gender");
                        Genderr.InnerText = gender;
                        employee.AppendChild(Genderr);

                        XmlNode Medical = doc.CreateElement("Medical_Form");
                        Medical.InnerText = med;
                        employee.AppendChild(Medical);

                        XmlNode salary = doc.CreateElement("Salary");
                        salary.InnerText = Salary.Text;
                        employee.AppendChild(salary);

                        XmlNode b = doc.CreateElement("Bonus");
                        b.InnerText = x.ToString();
                        employee.AppendChild(b);

                        XmlNode Employementdate = doc.CreateElement("Employement_Date");
                        Employementdate.InnerText = Emplyedate.Text;
                        employee.AppendChild(Employementdate);

                        XmlNode workingyears = doc.CreateElement("Working_Years");
                        workingyears.InnerText = working_years;
                        employee.AppendChild(workingyears);

                        XmlNode dateofbirth = doc.CreateElement("Date_of_birth");
                        dateofbirth.InnerText = Date.Text;
                        employee.AppendChild(dateofbirth);

                        XmlNode avaliable = doc.CreateElement("Available");
                        avaliable.InnerText = avail;
                        employee.AppendChild(avaliable);

                        XmlNode depp = doc.CreateElement("Department");
                        depp.InnerText = Department.Text;
                        employee.AppendChild(depp);

                        XmlNode pas = doc.CreateElement("Password");
                        pas.InnerText = password.Text;
                        employee.AppendChild(pas);

                        doc.DocumentElement.AppendChild(employee);
                        doc.Save("Employees.xml");

                        MessageBox.Show("Employee Successfuly Added.");
                    }

                    if (Department.Text == "Coach")
                    {
                        if (!File.Exists("Coaches.xml"))
                        {
                            XmlTextWriter document = new XmlTextWriter("Coaches.xml", Encoding.UTF8);

                            document.Formatting = Formatting.Indented;
                            document.WriteStartDocument();
                            document.WriteStartElement("Coaches");
                            document.WriteStartElement("Coach");
                            document.WriteStartElement("Coach_Name");
                            document.WriteString(Name.Text);
                            document.WriteEndElement();

                            document.WriteStartElement("Coach_ID");
                            document.WriteString(id);
                            document.WriteEndElement();

                            document.WriteStartElement("Mobile_Number");
                            document.WriteString(number.Text);
                            document.WriteEndElement();

                            document.WriteStartElement("Gender");
                            document.WriteString(gender);
                            document.WriteEndElement();

                            document.WriteStartElement("Medical_Form");
                            document.WriteString(med);
                            document.WriteEndElement();

                            document.WriteStartElement("Salary");
                            document.WriteString(Salary.Text);
                            document.WriteEndElement();

                            document.WriteStartElement("Bonus");
                            document.WriteString(x.ToString());
                            document.WriteEndElement();

                            document.WriteStartElement("Employement_Date");
                            document.WriteString(Emplyedate.Text);
                            document.WriteEndElement();

                            document.WriteStartElement("Working_Years");
                            document.WriteString(working_years);
                            document.WriteEndElement();

                            document.WriteStartElement("Date_of_birth");
                            document.WriteString(Date.Text);
                            document.WriteEndElement();

                            document.WriteStartElement("Available");
                            document.WriteString(avail);
                            document.WriteEndElement();

                            document.WriteStartElement("Department");
                            document.WriteString(dep);
                            document.WriteEndElement();

                            document.WriteStartElement("Results");
                            document.WriteString("0");
                            document.WriteEndElement();


                            document.WriteStartElement("Password");
                            document.WriteString(password.Text);
                            document.WriteEndElement();

                            document.WriteEndElement();
                            document.WriteEndElement();
                            document.WriteEndDocument();

                            document.Close();

                            MessageBox.Show("Coach Successfuly Added.");
                        }
                        else

                        {
                            XmlDocument doc = new XmlDocument();
                            doc.Load("Coaches.xml");

                            XmlNode employee = doc.CreateElement("Coach");

                            XmlNode Employee_Name = doc.CreateElement("Coach_Name");
                            Employee_Name.InnerText = Name.Text;
                            employee.AppendChild(Employee_Name);

                            XmlNode Employee_ID = doc.CreateElement("Coach_ID");
                            Employee_ID.InnerText = id;
                            employee.AppendChild(Employee_ID);

                            XmlNode MobileNum = doc.CreateElement("Mobile_Number");
                            MobileNum.InnerText = number.Text;
                            employee.AppendChild(MobileNum);

                            XmlNode Genderr = doc.CreateElement("Gender");
                            Genderr.InnerText = gender;
                            employee.AppendChild(Genderr);

                            XmlNode Medical = doc.CreateElement("Medical_Form");
                            Medical.InnerText = med;
                            employee.AppendChild(Medical);

                            XmlNode salary = doc.CreateElement("Salary");
                            salary.InnerText = Salary.Text;
                            employee.AppendChild(salary);

                            XmlNode b = doc.CreateElement("Bonus");
                            b.InnerText = x.ToString();
                            employee.AppendChild(b);

                            XmlNode Employementdate = doc.CreateElement("Employement_Date");
                            Employementdate.InnerText = Emplyedate.Text;
                            employee.AppendChild(Employementdate);

                            XmlNode workingyears = doc.CreateElement("Working_Years");
                            workingyears.InnerText = working_years;
                            employee.AppendChild(workingyears);

                            XmlNode dateofbirth = doc.CreateElement("Date_of_birth");
                            dateofbirth.InnerText = Date.Text;
                            employee.AppendChild(dateofbirth);

                            XmlNode avaliable = doc.CreateElement("Available");
                            avaliable.InnerText = avail;
                            employee.AppendChild(avaliable);

                            XmlNode depp = doc.CreateElement("Department");
                            depp.InnerText = dep;
                            employee.AppendChild(depp);

                            XmlNode res = doc.CreateElement("Results");
                            res.InnerText = "0";
                            employee.AppendChild(res);

                            XmlNode pas = doc.CreateElement("Password");
                            pas.InnerText = password.Text;
                            employee.AppendChild(pas);

                            doc.DocumentElement.AppendChild(employee);
                            doc.Save("Coaches.xml");

                            MessageBox.Show("Coach Successfuly Added.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("You're not allowed to add HR !");
                }
            }
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            adminoptions cccc = new adminoptions();
            cccc.Show();
            this.Close();
        }

        private void ID_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            adminoptions o = new adminoptions();
                o.Show();
            this.Close();
        }

        private void Male_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
    }

