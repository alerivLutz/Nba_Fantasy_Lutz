using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NbaFantasyProjekt
{
    internal class PlayerRank_Stats
    {
        public int PlayerRank { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Points { get; set; }
        public int Assits { get; set; }
        public int Rebounds { get; set; }
        public int Threes { get; set; }
        public int Steals { get; set; }
        public int Blocks { get; set; }
        public int Turnovers { get; set; }
        public int FGpercent { get; set; }
        public int FTpercent { get; set; }

        public bool Status { get; set; } = true;
        public PlayerRank_Stats(int playerrank, string name, string lastname, int points, int assists
            , int rebounds, int threes, int steals, int blocks, int turnovers, int fGpercent, int fTpercent)
        { 
          PlayerRank = playerrank;
            Name = name;
            LastName = lastname;
            Points = points;
            Assits = assists;
            Rebounds = rebounds;
            Threes = threes;
            Steals = steals;
            Blocks = blocks;
            Turnovers = turnovers;
            FGpercent = fGpercent;
            FTpercent = fTpercent;
            
        
        
        }

 
    }




}
