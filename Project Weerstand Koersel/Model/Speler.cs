using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Weerstand_Koersel.Model
{
    public class Speler
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Position { get; set; }
        public int TotalGames { get; set; }
        public int TotalGoals { get; set; }
        public int TotalAssists { get; set; }
    }
}
