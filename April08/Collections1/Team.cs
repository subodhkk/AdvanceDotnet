using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace April08.Collections1
{
    class Player
    {
        int id;
        string name, team, country;
        public Player()
        {
             
        }
        public Player(int id,string name,string country, string team)
        {
            this.id = id;
            this.name = name;
            this.team = team;
            this.country = country;
        }
        public int Id { get => id;set => id = value; }
        public string Name {  get => name; set => name = value; }
        public string Team { get => team; set => team = value; }
        public string Country { get => country; set => country = value; }
    }
    internal class Team
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            al.Add(new Player(1, "Dhoni", "India", "CSK"));
            al.Add(new Player(2, "Virat", "India", "RCB"));
            al.Add(new Player(3, "Maxwell", "Australia", "RCB"));
            al.Add(new Player(4, "Marsh", "Australia", "CSK"));
            al.Add(new Player(5, "Faf", "Australia", "RCB"));


            string max_team = " ";
            int maxcount = 0;
            foreach (Player p in al)
            {
                string t = p.Team;

                int c = 0;
                foreach (Player pp in al)
                {
                    if (pp.Team == t && pp.Country == "Australia")
                        c++;
                }
                if (maxcount < c)
                {
                    max_team = p.Team;
                    maxcount = c;
                }
            }
            Console.WriteLine($"Maximum Australian Players are in {max_team}={maxcount}");


        }
    } 
}
