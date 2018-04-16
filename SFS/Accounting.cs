using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFS
{
    class Accounting: Employee
    {
        int expenses;
        string Accountant;

        public Accounting()
        {
            expenses = 0;
            Accountant = "";
        }
        public Accounting(string namee, string date, string genderr, string ID, string medical, float sal, float bon, string mob,int workyear,string empdate, string statue, string dep,int Expenses, string accountant,string pass) :base(namee,date,genderr,ID,medical,sal,bon,mob,workyear,empdate,statue,dep,pass)
        {
            expenses = Expenses;
            Accountant = accountant;
        }
        public void Setexpenses(int expenses)
        {
            this.expenses = expenses;
        }
        public int Getexpenses()
        {
            return this.expenses;
        }
        public void setAccountant(string Accountant)
        {
            this.Accountant = Accountant;
        }
        public string GetAccountat()
        {
            return this.Accountant;
        }
        public double Bonus_Calc()
        {
           double Salary_with_bonus = 0;
            if (Working_year_calc()>=10)
            {
                Salary_with_bonus = getSalary()+ (getSalary() * 0.2);
            }
            return Salary_with_bonus;

        }
    }
}
