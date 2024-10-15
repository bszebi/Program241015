using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program241015
{
    internal class Competitor
    {
        public string Name {  get; set; }
        public int YearOfBirt {  get; set; }
        public int RaceNumber { get; set; }
        public bool Gender {  get; set; }
        public string AgeCategory {  get; set; }
        public Dictionary<string, TimeSpan> RaceTimes { get; set; }
            
        public Competitor(string row) 
        {
            var v = row.Split(';');
            Name = v[0];
            YearOfBirt = int.Parse(v[1]);
            RaceNumber = int.Parse(v[2]);
            Gender = v[3] == "f";
            AgeCategory = v[4];
            RaceTimes = new()
            {
                {"swimming",    TimeSpan.Parse(v[5])},
                {"1st depot",   TimeSpan.Parse(v[6])},
                {"cycling",     TimeSpan.Parse(v[7])},
                {"2nd depot",   TimeSpan.Parse(v[8])},
                {"running",     TimeSpan.Parse(v[9])},
            };

        }
    }
}
