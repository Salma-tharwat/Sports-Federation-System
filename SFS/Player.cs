﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFS
{
   class Player : Person
    {
        string TeamName;
        bool senior;
        public List<Championships> champion = new List<Championships>();
        int result;
        string CoachName;
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

        public Player(string namee, string date, string genderr, string ID, string medical, float sal, float bon, string mob, string teamname,string coach) : base(namee, date, genderr, ID, medical, sal, bon,mob)
        {
            this.TeamName = teamname;
            this.CoachName = coach;
        }

        public void set_teamname(string name)
        {
            TeamName = name;
        }
        public string get_teamname()
        {
            return TeamName;
        }
        public void set_CoachName(string n)
        {
            CoachName = n;
        }
        public string get_CoachName()
        {
            return CoachName ;
        }
        public void set_results(int x)
        {
            result = x;
        }
        public int get_results()
        {
            return result;
        }
        public bool is_senior()
        {
            return this.senior;
        }
        public void display()
        {

        }
        public void displayplayer()
        {

        }

    }
}
