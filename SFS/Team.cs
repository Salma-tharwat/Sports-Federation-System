using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFS
{
    class Team
    {
        string Name;
        string senior;
       // List<int>res;

        public Team()
        {
            Name = "";
            senior = "";
        }
        public Team(string N,string s)
        {
            Name = N;
            senior = s;
        }

        public void setTeam(string name)
        {
            this.Name = name;
        }
        public string getTeam()
        {
            return this.Name;
        }


        public void setage(string Senior)
        {
            this.senior = Senior;
        }
        public string getage()
        {
            return this.senior;
        }
    }
}

