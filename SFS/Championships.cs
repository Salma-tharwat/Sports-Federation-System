using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFS
{
    class Championships
    {
        string Name;
        string place;
        List<Team> teamList;
        int results;
        public Championships()
        {
            Name = "";
            place = "";
            teamList = new List<Team>();
            results = 0;
           
        }
        public Championships(string name,string placee,int Results)
        {
            Name = name;
            place = placee;
            results = Results;
            
        }
        public void setPlace(string place)
        {
            this.place = place;
        }
        public void setName(string n)
        {
            this.Name = n;
        }
        public string getName()
        {
            return this.Name;
        }
        public string GetPlace()
        {
            return this.place;
        }
        public void setresults(int results)
        {
            this.results = results;
        }
        public int Getresults()
        {
            return this.results;
        }

    }
}
