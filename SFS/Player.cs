using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFS
{
   class Player : Person
    {
        string TeamName;
        // list of championships
        bool senior;
   public  Player()
        {
            TeamName = "";
            if (ageCalculator() > 18)
            {
                senior = true;
            }
            else
            {
                senior = false;
            }
        }

        public Player(string namee, string date, string genderr, string ID, string medical, float sal, float bon, string mob, string teamname) : base(namee, date, genderr, ID, medical, sal, bon,mob)
        {
            this.TeamName = teamname;
            
        }

        public void set_teamname(string name)
        {
            TeamName = name;
        }
        public bool is_senior()
        {
            return this.senior;
        }
        public string get_teamname()
        {
            return TeamName;
        }
        public void display()
        {

        }
        public void displayplayer()
        {

        }

    }
}
