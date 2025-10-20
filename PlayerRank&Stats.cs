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
        public int Assists { get; }
        public int Tunronvers { get; }

        public PlayerRank_Stats(int playerrank, string name, string lastname, int points, int assists
            , int rebounds, int threes, int steals, int blocks, int turnovers, int fGpercent, int fTpercent)
        {
            PlayerRank = playerrank;
            Name = name;
            LastName = lastname;
            Points = points;
            Assists = assists;
            Rebounds = rebounds;
            Threes = threes;
            Steals = steals;
            Blocks = blocks;
            Turnovers = turnovers;
            FGpercent = fGpercent;
            FTpercent = fTpercent;



        }

        public PlayerRank_Stats(int playerrank, string name, string lastname, int points, int assists, int rebounds, int threes, int steals, int tunronvers, int fGpercent, int fTpercent)
        {
            PlayerRank = playerrank;
            Name = name;
            LastName = lastname;
            Points = points;
            Assists = assists;
            Rebounds = rebounds;
            Threes = threes;
            Steals = steals;
            Tunronvers = tunronvers;
            FGpercent = fGpercent;
            FTpercent = fTpercent;
        }
    }
    internal class Teams
    {

        public int TeamNumber { get; set; }

        public string TeamOwner { get; set; }

        public string TeamName { get; set; }

        public string Draftoder { get; set; }

        public Teams(int teamnumber, string teamowner, string teamname, string draftoder)
        {

            TeamNumber = teamnumber;
            TeamOwner = teamowner;
            TeamName = teamname;
            Draftoder = draftoder;
        }

        public Teams(int teamnumber, string teamname, string teamowner)
        {
            TeamNumber = teamnumber;
            TeamName = teamname;
            TeamOwner = teamowner;
        }
        static int[] draftOrder;
    }
    internal class Draft
    {
        internal readonly object DraftName;

        string Draftorder { get; set; }
        string Draftname { get; set; }


        public Draft(string draftname, string draftorder)

        {
            Draftname = draftname;
            Draftorder = draftorder;
        }

       



    }


}






