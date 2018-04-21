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
    class Containers
    {
        public static List<Player> Player_list = new List<Player>();
        public static List<Club> Club_list = new List<Club>();
        public static List<Employee> Employee_list = new List<Employee>();
        public static List<Sponsers> Sponsor_list = new List<Sponsers>();
        public static List<Team> Team_list = new List<Team>();
        public static List<Championships> championship_list = new List<Championships>();
        public static List<Coach> Coach_list = new List<Coach>();
        public static List<Admin> Admin_list = new List<Admin>();
        public static List<Championships> Players_results = new List<Championships>();

        public static void Read_Admin()
        {
            Containers.Admin_list.Clear();
            XmlDocument doc = new XmlDocument();
            doc.Load("Admins.xml");
            XmlNodeList list = doc.GetElementsByTagName("Admin");
            FileStream w = new FileStream("Admins.xml", FileMode.Open);
            for (int i = 0; i < list.Count; i++)
            {
                XmlNodeList list_2 = list[i].ChildNodes;
                string Name = list_2[0].Name;
                string nvalue = list_2[0].InnerText;
                string Password = list_2[1].Name;
                string pvalue = list_2[1].InnerText;
               
                Admin Ad = new Admin(nvalue, pvalue);
                Admin_list.Add(Ad);
            }
            w.Close();
        }
        public static void Read_Players()
        {
            Containers.Player_list.Clear();
            XmlDocument doc = new XmlDocument();
            doc.Load("Players.xml");
            XmlNodeList list = doc.GetElementsByTagName("Player");
            BinaryFormatter f = new BinaryFormatter();
            FileStream w = new FileStream("Players.xml", FileMode.Open);
            for (int i = 0; i < list.Count; i++)
            {
                XmlNodeList list_2 = list[i].ChildNodes;
                string Name = list_2[0].Name;
                string nvalue = list_2[0].InnerText;
                string ID = list_2[1].Name;
                string ivalue = list_2[1].InnerText;
                string mobile_number = list_2[2].Name;
                string mvalue = list_2[2].InnerText;
                string gender = list_2[3].Name;
                string gval = list_2[3].InnerText;
                string medical_form = list_2[4].Name;
                string medvalue = list_2[4].InnerText;
                string salary = list_2[5].Name;
                string sval = list_2[5].InnerText;
                string bonus = list_2[6].Name;
                string bval = list_2[6].InnerText;
                string date_of_birth = list_2[7].Name;
                string dval = list_2[7].InnerText;
                string team_name = list_2[8].Name;
                string tval = list_2[8].InnerText;
                string coach_name = list_2[9].Name;
                string ccval = list_2[9].InnerText;
                Player p = new Player(nvalue, dval, gval, ivalue, medvalue, float.Parse(sval), float.Parse(bval), mvalue, tval,ccval);
                Player_list.Add(p);
            }
            w.Close();
        }
        public static void Read_Sponsor()
        {
            Containers.Sponsor_list.Clear();
            XmlDocument doc = new XmlDocument();
            doc.Load("Sponsers.xml");
            XmlNodeList list = doc.GetElementsByTagName("Sponser");
            FileStream w = new FileStream("Sponsers.xml", FileMode.Open);
            for (int i = 0; i < list.Count; i++)
            {
                XmlNodeList list_2 = list[i].ChildNodes;
                string Name = list_2[0].Name;
                string nvalue = list_2[0].InnerText;
                String price = list_2[1].Name;
                String pvalue = list_2[1].InnerText;
             
                Sponsers t = new Sponsers(nvalue, int.Parse(pvalue));
                Sponsor_list.Add(t);
            }
            w.Close();
        }
        public static void Read_Employees()
        {
            Containers.Employee_list.Clear();
            XmlDocument doc = new XmlDocument();
            doc.Load("Employees.xml");
            XmlNodeList list = doc.GetElementsByTagName("Employee");
            BinaryFormatter f = new BinaryFormatter();
            FileStream w = new FileStream("Employees.xml", FileMode.Open);
            for (int i = 0; i < list.Count; i++)
            {
                XmlNodeList list_2 = list[i].ChildNodes;
                string Name = list_2[0].Name;
                string nvalue = list_2[0].InnerText;
                string ID = list_2[1].Name;
                string ivalue = list_2[1].InnerText;
                string mobile_number = list_2[2].Name;
                string mvalue = list_2[2].InnerText;
                string gender = list_2[3].Name;
                string gval = list_2[3].InnerText;
                string medical_form = list_2[4].Name;
                string medvalue = list_2[4].InnerText;
                string salary = list_2[5].Name;
                string sval = list_2[5].InnerText;
                string bonus = list_2[6].Name;
                string bval = list_2[6].InnerText;
                string Employment_date = list_2[7].Name;
                string edval = list_2[7].InnerText;
                string Working_year = list_2[8].Name;
                string wval = list_2[8].InnerText;
                string date_of_birth = list_2[9].Name;
                string dval = list_2[9].InnerText;
                string available = list_2[10].Name;
                string aval = list_2[10].InnerText;
                string department = list_2[11].Name;
                string depval = list_2[11].InnerText;
                string password = list_2[12].Name;
                string pasval = list_2[12].InnerText;
                Employee p = new Employee(nvalue, dval, gval, ivalue, medvalue, float.Parse(sval), float.Parse(bval), mvalue, int.Parse(wval), edval, aval, depval, pasval);
                Employee_list.Add(p);
            }
            w.Close();
        }
        public static void Read_Coach()
        {
            Containers.Coach_list.Clear();
            XmlDocument doc = new XmlDocument();
            doc.Load("Coaches.xml");
            XmlNodeList list = doc.GetElementsByTagName("Coach");
            FileStream w = new FileStream("Coaches.xml", FileMode.Open);
            for (int i = 0; i < list.Count; i++)
            {
                XmlNodeList list_2 = list[i].ChildNodes;
                string Name = list_2[0].Name;
                string nvalue = list_2[0].InnerText;
                string ID = list_2[1].Name;
                string ivalue = list_2[1].InnerText;
                string mobile_number = list_2[2].Name;
                string mvalue = list_2[2].InnerText;
                string gender = list_2[3].Name;
                string gval = list_2[3].InnerText;
                string medical_form = list_2[4].Name;
                string medvalue = list_2[4].InnerText;
                string salary = list_2[5].Name;
                string sval = list_2[5].InnerText;
                string bonus = list_2[6].Name;
                string bval = list_2[6].InnerText;
                string Employment_date = list_2[7].Name;
                string edval = list_2[7].InnerText;
                string Working_year = list_2[8].Name;
                string wval = list_2[8].InnerText;
                string date_of_birth = list_2[9].Name;
                string dval = list_2[9].InnerText;
                string available = list_2[10].Name;
                string aval = list_2[10].InnerText;
                string department = list_2[11].Name;
                string depval = list_2[11].InnerText;
                string results = list_2[12].Name;
                string resval = list_2[12].InnerText;
                string password = list_2[13].Name;
                string pasval = list_2[13].InnerText;
                Coach p = new Coach(nvalue, dval, gval, ivalue, medvalue, float.Parse(sval), float.Parse(bval), mvalue, int.Parse(wval), edval, aval, depval,0,"",int.Parse(resval),pasval);
                Coach_list.Add(p);
            }
            w.Close();
        }
        public static void Read_Clubs()
        {
            Containers.Club_list.Clear();
            XmlDocument doc = new XmlDocument();
            doc.Load("Clubs.xml");
            XmlNodeList list = doc.GetElementsByTagName("Club");
            BinaryFormatter f = new BinaryFormatter();
            FileStream w = new FileStream("Clubs.xml", FileMode.Open);
            for (int i = 0; i < list.Count; i++)
            {
                XmlNodeList list_2 = list[i].ChildNodes;
                string Name = list_2[0].Name;
                string nvalue = list_2[0].InnerText;
                string starting_date = list_2[1].Name;
                string sdvalue = list_2[1].InnerText;
                string Club_teams = list_2[1].Name;
                string ctvalue = list_2[1].InnerText;
                string club_championships = list_2[2].Name;
                string ccval = list_2[2].InnerText;
                string Club_sponsors = list_2[3].Name;
                string csvalue = list_2[3].InnerText;
                Club c = new Club(nvalue, sdvalue);
                Club_list.Add(c);
            }
            w.Close();
        }
        public static void Read_Championships()
        {
            //Containers.championship_list.Clear();
            XmlDocument doc = new XmlDocument();
            doc.Load("Championships.xml");
            XmlNodeList list = doc.GetElementsByTagName("Championship");
            FileStream w = new FileStream("Championships.xml", FileMode.Open);
            for (int i = 0; i < list.Count; i++)
            {
                XmlNodeList list_2 = list[i].ChildNodes;
                string type = list_2[0].Name;
                string tvalue = list_2[0].InnerText;
                string place = list_2[1].Name;
                string pvalue = list_2[1].InnerText;
                string senior = list_2[2].Name;
                string svalue = list_2[2].InnerText;
                string name = list_2[3].Name;
                string nameval = list_2[3].InnerText;
                Championships c = new Championships(pvalue, tvalue, svalue,nameval);
                championship_list.Add(c);
            }
            w.Close();
        }

        public static void Read_Teams()
        {
            Containers.Team_list.Clear();
            XmlDocument doc = new XmlDocument();
            doc.Load("Teams.xml");
            XmlNodeList list = doc.GetElementsByTagName("Team");
            BinaryFormatter f = new BinaryFormatter();
            FileStream w = new FileStream("Teams.xml", FileMode.Open);
            for (int i = 0; i < list.Count; i++)
            {
                XmlNodeList list_2 = list[i].ChildNodes;
                string Name = list_2[0].Name;
                string nvalue = list_2[0].InnerText;
                string senior = list_2[1].Name;
                string svalue = list_2[1].InnerText;
                string numberofresults = list_2[1].Name;
                string nrvalue = list_2[1].InnerText;

                Team t = new Team(nvalue, svalue);
                Team_list.Add(t);
            }
            w.Close();
        }
        public static void read_players_results()
        {
            Containers.Players_results.Clear();
            XmlDocument doc = new XmlDocument();
            doc.Load("Results.xml");
            XmlNodeList list = doc.GetElementsByTagName("Result");
            FileStream w = new FileStream("Results.xml", FileMode.Open);
            for (int i = 0; i < list.Count; i++)
            {
                XmlNodeList list_2 = list[i].ChildNodes;
                string player_ID = list_2[0].Name;
                string ivalue = list_2[0].InnerText;

                string Championship_type = list_2[1].Name;
                string ctvalue = list_2[1].InnerText;

                string Championship_place = list_2[2].Name;
                string cpvalue = list_2[2].InnerText;

                string results = list_2[3].Name;
                string reval = list_2[3].InnerText;

                string name = list_2[4].Name;
                string naval = list_2[4].InnerText;


                for (int l=0;l< Player_list.Count;l++)
                {
                    if(Player_list[l].getId()==ivalue)
                    {
                        Championships c = new Championships(cpvalue, ctvalue, int.Parse(reval), naval);
                        Player_list[l].champion.Add(c);
                        Player_list[l].set_results(Player_list[l].get_results() +int.Parse( reval));
                    }
                }
            }
            w.Close();

        }
        public static void write_Player(Player p)
        {
            if (!File.Exists("Players.xml"))
            {
                XmlTextWriter document = new XmlTextWriter("Players.xml", Encoding.UTF8);

                document.Formatting = Formatting.Indented;
                document.WriteStartDocument();
                document.WriteStartElement("Players");
                document.WriteStartElement("Player");

                document.WriteStartElement("Player_Name");
                document.WriteString(p.getName());
                document.WriteEndElement();

                document.WriteStartElement("Player_ID");
                document.WriteString(p.getId().ToString());
                document.WriteEndElement();

                document.WriteStartElement("Mobile_Number");
                document.WriteString(p.getmobile());
                document.WriteEndElement();

                document.WriteStartElement("Gender");
                document.WriteString(p.getGender());
                document.WriteEndElement();

                document.WriteStartElement("Medical_Form");
                document.WriteString(p.getMedicalReport().ToString());
                document.WriteEndElement();

                document.WriteStartElement("Salary");
                document.WriteString(p.getSalary().ToString());
                document.WriteEndElement();

                document.WriteStartElement("Bonus");
                document.WriteString(p.getBonus().ToString());
                document.WriteEndElement();

                document.WriteStartElement("Date_of_birth");
                document.WriteString(p.getDateOfBirth().ToString());
                document.WriteEndElement();

                document.WriteStartElement("Team_Name");
                document.WriteString(p.get_teamname());
                document.WriteEndElement();

                document.WriteStartElement("Coach_Name");
                document.WriteString(p.get_CoachName());
                document.WriteEndElement();

                document.WriteEndElement();
                document.WriteEndElement();
                document.WriteEndDocument();

                document.Close();


            }
            else

            {
                XmlDocument doc = new XmlDocument();
                doc.Load("Players.xml");

                XmlNode playerr = doc.CreateElement("Player");

                XmlNode Player_Name = doc.CreateElement("Player_Name");
                Player_Name.InnerText = p.getName();
                playerr.AppendChild(Player_Name);

                XmlNode ID = doc.CreateElement("Player_ID");
                ID.InnerText = p.getId().ToString();
                playerr.AppendChild(ID);

                XmlNode MobileNum = doc.CreateElement("Mobile_Number");
                MobileNum.InnerText = p.getmobile();
                playerr.AppendChild(MobileNum);

                XmlNode Genderr = doc.CreateElement("Gender");
                Genderr.InnerText = p.getGender();
                playerr.AppendChild(Genderr);

                XmlNode Medical = doc.CreateElement("Medical_Form");
                Medical.InnerText = p.getMedicalReport().ToString();
                playerr.AppendChild(Medical);

                XmlNode salary = doc.CreateElement("Salary");
                salary.InnerText = p.getSalary().ToString();
                playerr.AppendChild(salary);

                XmlNode bonus = doc.CreateElement("Bonus");
                bonus.InnerText = p.getBonus().ToString();
                playerr.AppendChild(bonus);

                XmlNode dateofbirth = doc.CreateElement("Date_oF_birth");
                dateofbirth.InnerText = p.getDateOfBirth().ToString();
                playerr.AppendChild(dateofbirth);

                XmlNode teamm = doc.CreateElement("Team_Name");
                teamm.InnerText = p.get_teamname();
                playerr.AppendChild(teamm);

                XmlNode cooo = doc.CreateElement("Coach_Name");
                cooo.InnerText = p.get_CoachName();
                playerr.AppendChild(cooo);

                doc.DocumentElement.AppendChild(playerr);
                doc.Save("Players.xml");

            }
        }
        public static void write_Employee(Employee e)
        {
            if (!File.Exists("Employees.xml"))
            {
                XmlTextWriter document = new XmlTextWriter("Employees.xml", Encoding.UTF8);

                document.Formatting = Formatting.Indented;
                document.WriteStartDocument();
                document.WriteStartElement("Employees");
                document.WriteStartElement("Employee");

                document.WriteStartElement("Employee_Name");
                document.WriteString(e.getName());
                document.WriteEndElement();

                document.WriteStartElement("Employment_ID");
                document.WriteString(e.getId().ToString());
                document.WriteEndElement();

                document.WriteStartElement("Mobile_Number");
                document.WriteString(e.getmobile());
                document.WriteEndElement();

                document.WriteStartElement("Gender");
                document.WriteString(e.getGender());
                document.WriteEndElement();

                document.WriteStartElement("Medical_Form");
                document.WriteString(e.getGender());
                document.WriteEndElement();

                document.WriteStartElement("Salary");
                document.WriteString(e.getSalary().ToString());
                document.WriteEndElement();

                document.WriteStartElement("Bonus");
                document.WriteString(e.getBonus().ToString());
                document.WriteEndElement();

                document.WriteStartElement("Employement_Date");
                document.WriteString(e.getEmployment_date());
                document.WriteEndElement();

                document.WriteStartElement("Working_Years");
                document.WriteString(e.getWorking_Year().ToString());
                document.WriteEndElement();

                document.WriteStartElement("Date_of_birth");
                document.WriteString(e.getDateOfBirth().ToString());
                document.WriteEndElement();

                document.WriteStartElement("Available");
                document.WriteString(e.GetStatus().ToString());
                document.WriteEndElement();

                document.WriteStartElement("Department");
                document.WriteString(e.GetDepartment());
                document.WriteEndElement();

                document.WriteStartElement("Password");
                document.WriteString(e.Getpassword());
                document.WriteEndElement();

                document.WriteEndElement();
                document.WriteEndElement();
                document.WriteEndDocument();

                document.Close();

            }
            else

            {
                XmlDocument doc = new XmlDocument();
                doc.Load("Employees.xml");

                XmlNode employee = doc.CreateElement("Employee");

                XmlNode Employee_Name = doc.CreateElement("Employee_Name");
                Employee_Name.InnerText = e.getName();
                employee.AppendChild(Employee_Name);

                XmlNode Employee_ID = doc.CreateElement("Employeement_ID");
                Employee_ID.InnerText = e.getId().ToString();
                employee.AppendChild(Employee_ID);

                XmlNode MobileNum = doc.CreateElement("Mobile_Number");
                MobileNum.InnerText = e.getmobile();
                employee.AppendChild(MobileNum);

                XmlNode Genderr = doc.CreateElement("Gender");
                Genderr.InnerText = e.getGender();
                employee.AppendChild(Genderr);

                XmlNode Medical = doc.CreateElement("Medical_Form");
                Medical.InnerText = e.getMedicalReport().ToString();
                employee.AppendChild(Medical);

                XmlNode salary = doc.CreateElement("Salary");
                salary.InnerText = e.getSalary().ToString();
                employee.AppendChild(salary);

                XmlNode b = doc.CreateElement("Bonus");
                b.InnerText = e.getBonus().ToString();
                employee.AppendChild(b);

                XmlNode Employementdate = doc.CreateElement("Employement_Date");
                Employementdate.InnerText = e.getEmployment_date();
                employee.AppendChild(Employementdate);

                XmlNode workingyears = doc.CreateElement("Working_Years");
                workingyears.InnerText = e.getWorking_Year().ToString();
                employee.AppendChild(workingyears);

                XmlNode dateofbirth = doc.CreateElement("Date_of_birth");
                dateofbirth.InnerText = e.getDateOfBirth().ToString();
                employee.AppendChild(dateofbirth);

                XmlNode avaliable = doc.CreateElement("Available");
                avaliable.InnerText = e.GetStatus().ToString();
                employee.AppendChild(avaliable);

                XmlNode dep = doc.CreateElement("Department");
                dep.InnerText = e.GetDepartment();
                employee.AppendChild(dep);

                XmlNode pas = doc.CreateElement("Password");
                pas.InnerText = e.Getpassword();
                employee.AppendChild(pas);

                doc.DocumentElement.AppendChild(employee);
                doc.Save("Employees.xml");

            }
        }
        public static void write_coach(Coach e)
        {
            if (!File.Exists("Coaches.xml"))
            {
                XmlTextWriter document = new XmlTextWriter("Coaches.xml", Encoding.UTF8);

                document.Formatting = Formatting.Indented;
                document.WriteStartDocument();
                document.WriteStartElement("Coaches");
                document.WriteStartElement("Coach");

                document.WriteStartElement("Coach_Name");
                document.WriteString(e.getName());
                document.WriteEndElement();

                document.WriteStartElement("Coach_ID");
                document.WriteString(e.getId().ToString());
                document.WriteEndElement();

                document.WriteStartElement("Mobile_Number");
                document.WriteString(e.getmobile());
                document.WriteEndElement();

                document.WriteStartElement("Gender");
                document.WriteString(e.getGender());
                document.WriteEndElement();

                document.WriteStartElement("Medical_Form");
                document.WriteString(e.getGender());
                document.WriteEndElement();

                document.WriteStartElement("Salary");
                document.WriteString(e.getSalary().ToString());
                document.WriteEndElement();

                document.WriteStartElement("Bonus");
                document.WriteString(e.getBonus().ToString());
                document.WriteEndElement();

                document.WriteStartElement("Employement_Date");
                document.WriteString(e.getEmployment_date());
                document.WriteEndElement();

                document.WriteStartElement("Working_Years");
                document.WriteString(e.getWorking_Year().ToString());
                document.WriteEndElement();

                document.WriteStartElement("Date_of_birth");
                document.WriteString(e.getDateOfBirth().ToString());
                document.WriteEndElement();

                document.WriteStartElement("Available");
                document.WriteString(e.GetStatus().ToString());
                document.WriteEndElement();

                document.WriteStartElement("Department");
                document.WriteString(e.GetDepartment());
                document.WriteEndElement();


                document.WriteStartElement("Results");
                document.WriteString(e.getResult().ToString());
                document.WriteEndElement();

                document.WriteStartElement("Password");
                document.WriteString(e.Getpassword());
                document.WriteEndElement();

                document.WriteEndElement();
                document.WriteEndElement();
                document.WriteEndDocument();

                document.Close();

            }
            else

            {
                XmlDocument doc = new XmlDocument();
                doc.Load("Coaches.xml");

                XmlNode employee = doc.CreateElement("Coach");

                XmlNode Employee_Name = doc.CreateElement("Coach_Name");
                Employee_Name.InnerText = e.getName();
                employee.AppendChild(Employee_Name);

                XmlNode Employee_ID = doc.CreateElement("Coach_ID");
                Employee_ID.InnerText = e.getId().ToString();
                employee.AppendChild(Employee_ID);

                XmlNode MobileNum = doc.CreateElement("Mobile_Number");
                MobileNum.InnerText = e.getmobile();
                employee.AppendChild(MobileNum);

                XmlNode Genderr = doc.CreateElement("Gender");
                Genderr.InnerText = e.getGender();
                employee.AppendChild(Genderr);

                XmlNode Medical = doc.CreateElement("Medical_Form");
                Medical.InnerText = e.getMedicalReport().ToString();
                employee.AppendChild(Medical);

                XmlNode salary = doc.CreateElement("Salary");
                salary.InnerText = e.getSalary().ToString();
                employee.AppendChild(salary);

                XmlNode b = doc.CreateElement("Bonus");
                b.InnerText = e.getBonus().ToString();
                employee.AppendChild(b);

                XmlNode Employementdate = doc.CreateElement("Employement_Date");
                Employementdate.InnerText = e.getEmployment_date();
                employee.AppendChild(Employementdate);

                XmlNode workingyears = doc.CreateElement("Working_Years");
                workingyears.InnerText = e.getWorking_Year().ToString();
                employee.AppendChild(workingyears);

                XmlNode dateofbirth = doc.CreateElement("Date_of_birth");
                dateofbirth.InnerText = e.getDateOfBirth().ToString();
                employee.AppendChild(dateofbirth);

                XmlNode avaliable = doc.CreateElement("Available");
                avaliable.InnerText = e.GetStatus().ToString();
                employee.AppendChild(avaliable);

                XmlNode dep = doc.CreateElement("Department");
                dep.InnerText = e.GetDepartment();
                employee.AppendChild(dep);

                XmlNode res = doc.CreateElement("Results");
                res.InnerText = e.getResult().ToString();
                employee.AppendChild(res);

                XmlNode pas = doc.CreateElement("Password");
                pas.InnerText = e.Getpassword();
                employee.AppendChild(pas);

                doc.DocumentElement.AppendChild(employee);
                doc.Save("Coach.xml");

            }
        }
        public static void write_PlayerResult(Championships c)
        {
            if (!File.Exists("Results.xml"))
            {
                XmlTextWriter document = new XmlTextWriter("Results.xml", Encoding.UTF8);

                document.Formatting = Formatting.Indented;
                document.WriteStartDocument();
                document.WriteStartElement("Results");
                document.WriteStartElement("Result");

                document.WriteStartElement("Player_ID");
                document.WriteString(Enter_ID.playerid);
                document.WriteEndElement();

                document.WriteStartElement("Championship_Type");
                document.WriteString(c.GetType().ToString());
                document.WriteEndElement();

                document.WriteStartElement("Championship_Place");
                document.WriteString(c.GetPlace());
                document.WriteEndElement();

                document.WriteStartElement("Results");
                document.WriteString(c.Getresults().ToString());
                document.WriteEndElement();



                document.WriteEndElement();
                document.WriteEndElement();
                document.WriteEndDocument();

                document.Close();


            }
            else

            {
                XmlDocument doc = new XmlDocument();
                doc.Load("Results.xml");

                XmlNode resultt = doc.CreateElement("Result");

                XmlNode typee = doc.CreateElement("Championship_Type");
                typee.InnerText = c.GetType().ToString();
                resultt.AppendChild(typee);

                XmlNode placee = doc.CreateElement("Championship_Place");
                placee.InnerText = c.GetPlace();
                resultt.AppendChild(placee);

                XmlNode res = doc.CreateElement("Results");
                res.InnerText = (c.Getresults().ToString());
                resultt.AppendChild(res);

                doc.DocumentElement.AppendChild(resultt);
                doc.Save("Results.xml");


            }
        }
    }
}
