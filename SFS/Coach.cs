using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFS
{
    class Coach : Employee
    {
        string team;
       public List<Championships> champlist;
        public Coach()
        {
            team = "";
          champlist = new List<Championships>();
        }
        public Coach(string namee, string date, string genderr, string ID, string medical, float sal, float bon, string mob, int workyear, string empdate, string statue, string dep, int Expenses, string accountant,string team) : base(namee, date, genderr, ID, medical, sal, bon, mob, workyear, empdate, statue, dep)
        {
            this.team = team;
        }
        public void setTeam(string team)
        {
            this.team = team;
        }
        public string getTeam()
        {
            return this.team;
        }
    }
}
