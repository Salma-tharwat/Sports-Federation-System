using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFS
{
    class Employee : Person
    {
        int working_year;
        string Employment_date;
        string status;
        string department;


        public Employee()
        {
            working_year = 0;
            Employment_date = "";
            status = "Available";
            department = "";
            
        }
        public Employee(string namee, string date, string genderr, string ID, string medical, float sal, float bon, string mob,int workyear,string empdate, string statue, string dep) :base(namee,date,genderr,ID,medical,sal,bon,mob)
        {
            
            Employment_date = empdate;
            status = statue;
            department = dep;
            working_year = workyear;

        }
        public void setWorking_Year(int working_year)
        {
            this.working_year = working_year;

        }
        public int getWorking_Year()
        {
            return this.working_year;

        }
        public void setEmployment_date(string Employment_date)
        {
            this.Employment_date = Employment_date;

        }
        public string getEmployment_date()
        {
            return this.Employment_date;
        }
        public void setStatus(string status)
        {

            this.status = status;
        }
        public string GetStatus()
        {
            return this.status;

        }
        public void setDepartment(string department)
        {
            this.department = department;
        }
        public string GetDepartment()
        {
            return this.department;
        }
        public int Working_year_calc()
        {
            int current_year = 2018;
            int years;
            years= current_year - working_year;
            return years;
        }
 
    }
}