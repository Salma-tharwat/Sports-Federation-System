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
        string type;
        string senior;
        int results;
        public Championships()
        {
            Name = "";
            place = "";
            type = "";
            results = 0;
           
        }
        public Championships(string placee,string Type,string sn,string name)
        {
            Name = name;
            place = placee;
            type = Type;
            senior = sn;
            
        }
        public Championships(string type, string place, int result, string name)
        {
            this.type = type;
            this.place = place;
            this.results = result;
            this.Name = name;
        }
        public void setPlace(string place)
        {
            this.place = place;
        }
        public void setName(string n)
        {
            this.Name = n;
        }
        public void Setresults(int results)
        {
            this.results = results;
        }
        public string getName()
        {
            return this.Name;
        }
        
        public string GetPlace()
        {
            return this.place;
        }

        public int Getresults()
        {
            return this.results;
        }


        public void Settype(string type)
        {
            this.type = type;
        }
        public string Gettype()
        {
            return this.type;
        }
        public void setSenior(string senior)
        {
            this.senior = senior;
        }
        public string getSenior()
        {
            return this.senior;
        }
    }
}
