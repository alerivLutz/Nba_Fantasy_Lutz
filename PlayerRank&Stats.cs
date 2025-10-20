namespace NbaFantasyProjekt
{
    internal class PlayerRank_Stats
    {
        public int PlayerRank { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Points { get; set; }
        public int Assists { get; set; }
        public int Rebounds { get; set; }
        public int Threes { get; set; }
        public int Steals { get; set; }
        public int Blocks { get; set; }
        public int Turnovers { get; set; }
        public int FGpercent { get; set; }
        public int FTpercent { get; set; }
        public bool Status { get; set; } = true;

        public PlayerRank_Stats(int playerRank, string name, string lastName, int points, int assists,
            int rebounds, int threes, int steals, int blocks, int turnovers, int fgPercent, int ftPercent)
        {
            PlayerRank = playerRank;
            Name = name;
            LastName = lastName;
            Points = points;
            Assists = assists;
            Rebounds = rebounds;
            Threes = threes;
            Steals = steals;
            Blocks = blocks;
            Turnovers = turnovers;
            FGpercent = fgPercent;
            FTpercent = ftPercent;
        }
    }

    internal class Teams
    {
        public int TeamNumber { get; set; }
        public string TeamName { get; set; }
        public string TeamOwner { get; set; }
        public string DraftOrder { get; set; }

        public Teams(int teamNumber, string teamName, string teamOwner)
        {
            TeamNumber = teamNumber;
            TeamName = teamName;
            TeamOwner = teamOwner;
        }

        public Teams(int teamNumber, string teamOwner, string teamName, string draftOrder)
        {
            TeamNumber = teamNumber;
            TeamOwner = teamOwner;
            TeamName = teamName;
            DraftOrder = draftOrder;
        }

        public override string ToString()
        {
            return $"Team Number: {TeamNumber}, Name: {TeamName}, Owner: {TeamOwner}, Draft Order: {DraftOrder}";
        }
    }

    public class Draft
    {
        public string DraftName { get; set; }
        public string DraftOrder { get; set; }

        public Draft(string draftName, string draftOrder)
        {
            DraftName = draftName;
            DraftOrder = draftOrder;
        }

        public override string ToString()
        {
            return $"Draft Name: {DraftName}, Draft Order: {DraftOrder}";
        }
    }
}
