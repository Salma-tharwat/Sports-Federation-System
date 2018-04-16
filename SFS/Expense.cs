using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Drawing;
using System.Data;
namespace SFS
{
    class Expense
    {
        int expense_value;
        string month;
        string taken_for;
        public Expense()
        {
            expense_value = 0;
             month = "";
            taken_for = "";
        }
        public Expense(int v,string m,string t)
        {
            expense_value = v;
            month = m;
            taken_for = t;
        }
        public void set_expense(int v,string m,string t)
        {
            expense_value = v;
            month = m;
            taken_for = t;
        }
        public int get_value()
        {
            return expense_value;
        }
        public string get_expense_month()
        {
            return month;
        }
        public string get_expense_takenfor()
        {
            return taken_for;
        }
        public void write_expense()
        {
            if (!File.Exists("Expenses.xml"))
            {
                XmlTextWriter document = new XmlTextWriter("Expenses.xml", Encoding.UTF8);

                document.Formatting = Formatting.Indented;
                document.WriteStartDocument();
                document.WriteStartElement("Expenses");
                document.WriteStartElement("Expense");
                document.WriteStartElement("Expense_value");
                document.WriteString(expense_value.ToString());
                document.WriteEndElement();

                document.WriteStartElement("Month_Given");
                document.WriteString(month);
                document.WriteEndElement();

                document.WriteStartElement("Given_to");
                document.WriteString(taken_for);
                document.WriteEndElement();
                document.WriteEndElement();
                document.WriteEndElement();
                document.WriteEndDocument();

                document.Close();
            }
            else

            {
                XmlDocument doc = new XmlDocument();
                doc.Load("Expenses.xml");

                XmlNode expense = doc.CreateElement("Expense");

                XmlNode Expense_value = doc.CreateElement("Expense_value");
                Expense_value.InnerText = expense_value.ToString();
                expense.AppendChild(Expense_value);

                XmlNode Month = doc.CreateElement("Month");
                Month.InnerText = month;
                expense.AppendChild(Month);

                XmlNode gto = doc.CreateElement("Given_to");
                gto.InnerText = taken_for;
                expense.AppendChild(gto);
                doc.DocumentElement.AppendChild(expense);
                doc.Save("Employees.xml");

                
            }
        }
    }
}
