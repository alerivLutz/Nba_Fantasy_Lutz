using System;
using System.Data;
using System.Drawing;
using System.Xml.Linq;
using System.IO;
using System.Text.Json;
using System.Security.Cryptography.X509Certificates;

namespace NbaFantasyProjekt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ReadKey();
            List<PlayerRank_Stats> players = LoadPlayers();
            List<Draft> drafts = LoadDrafts();
            List<Teams> teams = LoadTeams();
            Console.OutputEncoding = System.Text.Encoding.UTF8;








            // This is our Welcoming screen where we will be trying to create an NBA logo.

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("N     N  BBBBB    AAAAA       *******    ");
            Console.WriteLine("NN    N  B    B  A     A    *      * *  ");
            Console.WriteLine("N N   N  B    B  A     A   *      * *  * ");
            Console.WriteLine("N  N  N  BBBBB   AAAAAAA  *      * *    *");
            Console.WriteLine("N   N N  B    B  A     A  *     * *     *");
            Console.WriteLine("N    NN  B    B  A     A   *   * *     * ");
            Console.WriteLine("N     N  BBBBB   A     A    * * *     *  ");
            Console.WriteLine("                              ********    ");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("FFFFF   AAAAA  N     N  TTTTT  AAAAA  SSSS   Y   Y");
            Console.WriteLine("F       A   A  NN    N    T    A   A  S      Y   Y");
            Console.WriteLine("FFFF    AAAAA  N N   N    T    AAAAA  SSSS    Y Y ");
            Console.WriteLine("F       A   A  N  N  N    T    A   A     S     Y  ");
            Console.WriteLine("F       A   A  N   N N    T    A   A  SSSS     Y  ");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("DDDD   RRRR    AAAAA  FFFFF  TTTTT");
            Console.WriteLine("D   D  R   R  A     A F        T  ");
            Console.WriteLine("D   D  RRRR   AAAAAAA FFFF     T  ");
            Console.WriteLine("D   D  R  R   A     A F        T  ");
            Console.WriteLine("DDDD   R   R  A     A F        T  ");
            Console.ResetColor();


            Console.ReadKey();

            Menu(players, teams, drafts);


        }

        public static void Menu(List<PlayerRank_Stats> players, List<Teams> teams, List<Draft> drafts)

        {



            int auswahl = 0;
            List<string> options = new List<string>()
        {

                " NBA Fanatasy 🏀🏀🏀",
            "1. Player Database",
            "2. How many teams will be playing in the League",
            "3. Get draft order",
            "4. Start the draft!",
            "5. Exit"

        };
            while (true)
            {
                Console.Clear();
                Console.WriteLine("\n\n\n\n");
                for (int i = 0; i < options.Count; i++)
                {
                    if (i == auswahl)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.WriteLine(options[i]);
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.WriteLine(options[i]);
                    }
                }


                var key = Console.ReadKey().Key;
                if (key == ConsoleKey.UpArrow) auswahl--;
                else if (key == ConsoleKey.DownArrow) auswahl++;
                if (auswahl < 0) auswahl = options.Count - 1;
                if (auswahl >= options.Count) auswahl = 0;
                if (key == ConsoleKey.Enter)
                {
                    // Here is the code where we will add player to the data bank 
                    if (auswahl == 1)
                        PlayerRankDatabase();


                    // here we are creating the teams that will part take of the draft
                    else if (auswahl == 2)
                        TeamsCreation();

                    else if (auswahl == 3)
                        DraftLottery();

                    else if (auswahl == 4)
                        DraftStart();
                    else if (auswahl == 5)
                        break;







                    void PlayerRankDatabase()


                    {
                        Console.Clear();

                        Console.WriteLine("Please press the following key to navigate in the menu");
                        Console.WriteLine("(1)\t➕ Add Players to the data base.");
                        Console.WriteLine("(2)\t❌ Remove players from the data base.");
                        Console.WriteLine("(3)\t🔙 Return to the main menu.");
                        var input = Console.ReadKey();

                        Console.Clear();

                        switch (input.KeyChar)
                        {

                            case '1':
                                PLayerAdd();
                                break;

                            case '2':
                                RemovePlayer();
                                break;
                            case '3':
                                return;


                        }
                    }




                    void PLayerAdd()
                    {
                        bool playercreation = true;
                        do
                        {
                            Console.Clear();

                            Console.WriteLine("Lets create a Player! ");
                            Thread.Sleep(2000);


                            int rank;
                            while (true)
                            {
                                Console.Clear();
                                Console.WriteLine("Rank");

                                var rankInput = Console.ReadLine();

                                if (int.TryParse(rankInput, out rank))
                                {
                                    break;
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Please provide only numbers");
                                    Console.ResetColor();
                                    Console.ReadKey();

                                }
                            }
                            Console.Clear();



                            Console.WriteLine("Name");
                            var name = Console.ReadLine();
                            Console.Clear();

                            Console.WriteLine("Last Name");
                            var lastname = Console.ReadLine();
                            Console.Clear();


                            int points;
                            while (true)
                            {
                                Console.Clear();
                                Console.WriteLine("Points");

                                var pointsInput = Console.ReadLine();

                                if (int.TryParse(pointsInput, out points))
                                {
                                    break;
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Please provide only numbers");
                                    Console.ResetColor();
                                    Console.ReadKey();

                                }
                            }

                            int assists;
                            while (true)
                            {
                                Console.Clear();
                                Console.WriteLine("Assists");

                                var assistsInput = Console.ReadLine();
                                if (int.TryParse(assistsInput, out assists))
                                {
                                    break;
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Please provide only numbers");
                                    Console.ResetColor();
                                    Console.ReadKey();
                                }
                            }
                            int rebounds;
                            while (true)
                            {
                                Console.Clear();
                                Console.WriteLine("Rebounds");

                                var reboundsInput = Console.ReadLine();
                                if (int.TryParse(reboundsInput, out rebounds))
                                {
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Please provide only numbers");
                                }

                            }
                            int threes;
                            Console.Clear();
                            while (true)
                            {
                                Console.WriteLine("Threes");
                                var threesInput = Console.ReadLine();
                                if (int.TryParse(threesInput, out threes))
                                {
                                    break;
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Please provide only numbers");
                                    Console.ResetColor();
                                    Console.ReadKey();
                                }
                            }

                            int steals;
                            while (true)
                            {
                                Console.Clear();
                                Console.WriteLine("Steals");
                                var stealsInput = Console.ReadLine();
                                if (int.TryParse(stealsInput, out steals))
                                { break; }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Please provide only numbers");
                                    Console.ResetColor();
                                    Console.ReadKey();
                                }
                            }
                            int blocks;
                            while (true)
                            {
                                Console.Clear();
                                Console.WriteLine("Blocks");
                                var blocksInput = Console.ReadLine();
                                if (int.TryParse(blocksInput, out blocks))
                                { break; }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Please provide only numbers");
                                    Console.ResetColor();
                                    Console.ReadKey();

                                }
                            }
                            int tunronvers;
                            while (true)
                            {
                                Console.Clear();
                                Console.WriteLine("Tunrovers");
                                var tunronversInput = Console.ReadLine();
                                if (int.TryParse(tunronversInput, out tunronvers))
                                { break; }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Please provide only numbers");
                                    Console.ResetColor();
                                    Console.ReadKey();

                                }
                            }
                            int fGpercent;
                            while (true)
                            {
                                Console.Clear();
                                Console.WriteLine("FG%");
                                var fGpercentInput = Console.ReadLine();
                                if (int.TryParse(fGpercentInput, out fGpercent))
                                { break; }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Please provide only numbers");
                                    Console.ResetColor();
                                    Console.ReadKey();
                                }
                            }

                            int fTpercent;
                            while (true)
                            {
                                Console.Clear();
                                Console.WriteLine("FT%");
                                var tpercentInput = Console.ReadLine();
                                if (int.TryParse(tpercentInput, out fTpercent))
                                { break; }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Please provide only numbers");
                                    Console.ResetColor();
                                    Console.ReadKey();
                                }
                            }
                            Console.WriteLine("Owner");
                            var owner = Console.ReadLine();

                            //This will allow us to make sure no players are created with out a name
                            if (name != null && name != "" && lastname != null && lastname != "")
                            {

                                // unsingedint googled it so we dont have negative numbers

                                int playerrank = rank;
                                var player = new PlayerRank_Stats(playerrank, name, lastname, points, assists, rebounds, threes, steals, blocks, tunronvers, fGpercent, fTpercent, owner);
                                players.Add(player);
                                SavePlayersToJson(players);


                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Player saved successfully!");
                                Console.ResetColor();
                                Console.WriteLine("Would you like to add an other player?");
                                Console.WriteLine("Y/N");
                                string YN = Console.ReadLine();
                                if (YN == "Y")
                                {
                                    playercreation = true;
                                }
                                else if (YN == "N")
                                {
                                    playercreation = false;
                                }




                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Please fill in name and last name");
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.ResetColor();



                            }



                        } while (playercreation);





                    }
                    void RemovePlayer()
                    {
                        Console.Clear();
                        if (players.Count == 0)
                        {
                            Console.WriteLine("No players available to remove.");
                            Console.ReadKey();
                            return;
                        }

                        Console.WriteLine("Current Players:");
                        for (int i = 0; i < players.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}. {players[i].Name} {players[i].LastName} (Rank: {players[i].PlayerRank})");
                        }

                        Console.WriteLine("\nEnter the number of the player to remove:");
                        if (int.TryParse(Console.ReadLine(), out int index) && index > 0 && index <= players.Count)
                        {
                            var playerToRemove = players[index - 1];
                            Console.WriteLine($"Are you sure you want to delete {playerToRemove.Name} {playerToRemove.LastName}? (Y/N)");
                            string confirm = Console.ReadLine();

                            if (confirm?.ToUpper() == "Y")
                            {
                                players.RemoveAt(index - 1);
                                SavePlayersToJson(players);
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Player removed successfully!");
                                Console.ResetColor();
                            }
                            else
                            {
                                Console.WriteLine("Player not removed.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid selection.");
                        }

                        Console.ReadKey();
                    }



                    void TeamsCreation()
                    {
                        {
                            Console.Clear();
                            Console.WriteLine("Please press the following key to navigate the teams menu:");
                            Console.WriteLine("(1)\t➕ Add a team.");
                            Console.WriteLine("(2)\t❌ Remove a team.");
                            Console.WriteLine("(3)\t🔙 Return to main menu.");
                            var input = Console.ReadKey();

                            Console.Clear();

                            switch (input.KeyChar)
                            {
                                case '1':
                                    AddTeam();
                                    break;
                                case '2':
                                    RemoveTeam();
                                    break;
                                case '3':
                                    return; // Returns to main menu
                            }

                        }

                    }



                    void AddTeam()
                    {
                        int numberofteams;
                        bool check;
                        do
                        {

                            Console.Clear();
                            Console.WriteLine("Please input how many teams will be in your league. ");
                            check = int.TryParse(Console.ReadLine(), out numberofteams);
                            if (!check)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Please provide only numbers");
                                Console.ResetColor();
                                Console.ReadKey();
                            }
                        }
                        while (!check);
                        int i = 1;
                        //This loops helps us to start creating the teams and it will only loop the ammount of times the number of teams.
                        do

                        {

                            while (true)
                            {
                                int teamnumber;
                                Console.WriteLine("Team number:");
                                var teamnumberInput = Console.ReadLine();
                                if (int.TryParse(teamnumberInput, out teamnumber))

                                {
                                    break;
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Please provide only numbers");
                                    Console.ResetColor();
                                    Console.ReadKey();
                                }
                            }


                            Console.WriteLine("Team Name");
                            var teamname = Console.ReadLine();

                            Console.WriteLine("Team Owner");
                            var teamowner = Console.ReadLine();









                            if (teamname != null && teamname != "" && teamowner != null && teamowner != "")
                            {

                                int teamnumber = 0;
                                var team = new Teams(teamnumber, teamname, teamowner);
                                teams.Add(team);
                                SaveTeamsToJson(teams);
                                Console.WriteLine("Team Saved is saved");
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Team saved successfully!");
                                Console.ResetColor();
                                i++;

                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Please fill in Team number, Team Name, Team owner");



                            }

                        }

                        while (i <= numberofteams);
                    }
                    void RemoveTeam()
                    {
                        Console.Clear();
                        if (teams.Count == 0)
                        {
                            Console.WriteLine("No teams available to remove.");
                            Console.ReadKey();
                            return;
                        }

                        Console.WriteLine("Current Teams:");
                        for (int i = 0; i < teams.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}. {teams[i].TeamName} (Owner: {teams[i].TeamOwner})");
                        }

                        Console.WriteLine("\nEnter the number of the team to remove:");
                        if (int.TryParse(Console.ReadLine(), out int index) && index > 0 && index <= teams.Count)
                        {
                            var teamToRemove = teams[index - 1];
                            Console.WriteLine($"Are you sure you want to delete {teamToRemove.TeamName}? (Y/N)");
                            string confirm = Console.ReadLine();

                            if (confirm?.ToUpper() == "Y")
                            {
                                teams.RemoveAt(index - 1);
                                SaveTeamsToJson(teams);
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Team removed successfully!");
                                Console.ResetColor();
                            }
                            else
                            {
                                Console.WriteLine("Team not removed.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid selection.");
                        }

                        Console.ReadKey();
                    }




                    void DraftLottery()
                    {

                        Console.Clear();
                        Console.WriteLine("Please press the following key to navigate the drafts menu:");
                        Console.WriteLine("(1)\t➕ Add a draft.");
                        Console.WriteLine("(2)\t❌ Remove a draft.");
                        Console.WriteLine("(3)\t🔙 Return to main menu.");
                        var input = Console.ReadKey();

                        Console.Clear();

                        switch (input.KeyChar)
                        {
                            case '1':
                                AddDraft();
                                break;
                            case '2':
                                RemoveDraft();
                                break;
                            case '3':
                                return; // Returns to main menu
                        }

                    }
                    
                    
                    void AddDraft()
                    {
                        int TeamsComingToodraft;

                        bool check;
                        do
                        {

                            Console.Clear();
                            Console.WriteLine("Please input how many teams will be taking part in the draft. ");
                            check = int.TryParse(Console.ReadLine(), out TeamsComingToodraft);
                            if (!check)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Please provide only numbers");
                                Console.ResetColor();
                                Console.ReadKey();
                            }
                        }
                        while (!check);


                        int[] draft = new int[TeamsComingToodraft];


                        for (int i = 0; i < TeamsComingToodraft; i++)
                        {
                            draft[i] = i + 1;
                        }

                        Random rnd = new Random();

                        // This part of the code i did not know how to genrate it so went to chatgpt 
                        for (int i = TeamsComingToodraft - 1; i > 0; i--)
                        {
                            int j = rnd.Next(i + 1);
                            int temp = draft[i];
                            draft[i] = draft[j];
                            draft[j] = temp;
                        }

                        // Here is now my own code 

                        int x = 1;
                        for (int i = 0; i < TeamsComingToodraft; i++)
                        {
                            Console.WriteLine($" Team {x++}-{draft[i]}");
                        }
                        Console.ReadKey();

                        while (true)
                        {
                            Console.WriteLine("Please write the Name of the draft");
                            var draftname = Console.ReadLine();

                            Console.WriteLine("Please write the order of the draft starting from the number on top");
                            var drafroder = Console.ReadLine();

                            if (draftname != null && draftname != "" && drafroder != null && drafroder != "")
                            {

                                var draftx = new Draft(draftname, drafroder);
                                drafts.Add(draftx);
                                SaveDraftsToJson(drafts);
                                Console.WriteLine("Draft order is saved");
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Team saved successfully!");
                                Console.ResetColor();
                                Console.ReadKey();
                                break;

                            }
                            else
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Please fill in Draft name and Draft order");
                                Console.ResetColor();
                                Console.ReadKey();

                            }
                        }
                    }
                    void RemoveDraft()
                    {
                        Console.Clear();
                        if (drafts.Count == 0)
                        {
                            Console.WriteLine("No drafts available to remove.");
                            Console.ReadKey();
                            return;
                        }

                        Console.WriteLine("Current Drafts:");
                        for (int i = 0; i < drafts.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}. {drafts[i].DraftName} - Order: {drafts[i].DraftOrder}");
                        }

                        Console.WriteLine("\nEnter the number of the draft to remove:");
                        if (int.TryParse(Console.ReadLine(), out int index) && index > 0 && index <= drafts.Count)
                        {
                            var draftToRemove = drafts[index - 1];
                            Console.WriteLine($"Are you sure you want to delete draft '{draftToRemove.DraftName}'? (Y/N)");
                            string confirm = Console.ReadLine();

                            if (confirm?.ToUpper() == "Y")
                            {
                                drafts.RemoveAt(index - 1);
                                SaveDraftsToJson(drafts);
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Draft removed successfully!");
                                Console.ResetColor();
                            }
                            else
                            {
                                Console.WriteLine("Draft not removed.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid selection.");
                        }

                        Console.ReadKey();
                    }




                    void DraftStart()
                    {
                        Console.Clear();
                        Console.WriteLine("Please press the following key to navigate the drafts menu:");
                        Console.WriteLine("(1)\t🎉▶️ START draft.");
                        Console.WriteLine("(2)\t👀 View Teams");
                        Console.WriteLine("(3)\t🔙 Return to main menu.");
                        var input = Console.ReadKey();

                        Console.Clear();

                        switch (input.KeyChar)
                        {
                            case '1':
                                StartDraft();
                                break;
                            case '2':
                                ViewDraft();
                                break;
                            case '3':
                                return; // Returns to main menu
                        }






                    }
                    
                    
                    void StartDraft()
                    {
                        bool drafting = true;
                        while (drafting)
                        {
                            Console.Clear();
                            foreach (var draft in drafts)

                            {
                                Console.WriteLine($"\t\tDraft Name: {draft.DraftName}");

                                Console.WriteLine($"\t\tDraft Order: {draft.DraftOrder}");
                            }






                            Console.WriteLine("Lets start the draft!");
                            Console.WriteLine("All players \n\n");
                            Console.WriteLine("Rank\tName\tLast Name\tPoints\tAssists\tRebounds\tThrees\tSteals\tBlocks\tT.O\tFG%\tFT%");

                            var availablePlayers = players.Where(p => p.Status).ToList();

                            for (int i = 0; i < availablePlayers.Count; i++)

                            {
                                var p = availablePlayers[i];
                                Console.WriteLine(
                                    $"{players[i].PlayerRank}\t" +
                                    $"{players[i].Name}\t" +
                                    $"{players[i].LastName}\t\t" +
                                    $"{players[i].Points}\t" +
                                    $"{players[i].Assists}\t" +
                                    $"{players[i].Rebounds}\t\t" +
                                    $"{players[i].Threes}\t" +
                                    $"{players[i].Steals}\t" +
                                    $"{players[i].Blocks}\t" +
                                    $"{players[i].Turnovers}\t" +
                                    $"{players[i].FGpercent}\t" +
                                    $"{players[i].FTpercent}"
                                );
                            }
                            Console.WriteLine("\nEnter the player's rank:");

                            if (int.TryParse(Console.ReadLine(), out int input))
                            {
                                var selectedPlayer = availablePlayers.FirstOrDefault(p => p.PlayerRank == input);
                                if (selectedPlayer != null)
                                {

                                    Console.WriteLine($"Selected: {selectedPlayer.Name} {selectedPlayer.LastName}");
                                    Console.WriteLine($"Current owner: {selectedPlayer.Owner}");

                                    Console.WriteLine("Enter new owner:");
                                    string newOwner = Console.ReadLine();
                                    if (!string.IsNullOrEmpty(newOwner))
                                    {
                                        selectedPlayer.Owner = newOwner;
                                        selectedPlayer.Status = false;
                                        Console.WriteLine($"Owner updated to {selectedPlayer.Owner}.");
                                        Console.Clear();
                                        Console.WriteLine("Draft another player? (Y/N)");
                                        string draftMore = Console.ReadLine();
                                        if (draftMore?.Trim().ToUpper() != "Y")
                                        {

                                            drafting = false; // exit loop if not 'Y'
                                        }
                                        Console.WriteLine("Would you like to see the draft so far");
                                        string viewDraftsChoice = Console.ReadLine();
                                        if (viewDraftsChoice?.Trim().ToUpper() == "Y")
                                        {
                                            Console.Clear();
                                            ViewDraft();  
                                        }
                                        
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Invalid input for owner.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Invalid player rank or player already drafted.");
                            }
                        }

                    }
                    void ViewDraft()
                    {
                        void ListPlayersByOwner(List<PlayerRank_Stats> players, List<Teams> teams)
                        {
                            var grouped = players
                                .OrderBy(p => p.Owner)
                                .GroupBy(p => p.Owner);

                            foreach (var group in grouped)
                            {
                                // Find the team for this owner
                                var team = teams.FirstOrDefault(t => t.TeamOwner == group.Key);
                                string teamName = team != null ? team.TeamName : "(No Team)";

                                Console.WriteLine($"Team: {teamName} | Owner: {group.Key}");
                                foreach (var player in group)
                                {
                                    Console.WriteLine($"  {player.PlayerRank}. {player.Name} {player.LastName}");
                                }
                                Console.WriteLine();
                            }
                            Console.ReadKey();
                        }

                        ListPlayersByOwner(players, teams);
                    }


                }




                void SavePlayersToJson(List<PlayerRank_Stats> players)
                {
                    string filePath = "players.json";
                    string json = JsonSerializer.Serialize(players, new JsonSerializerOptions { WriteIndented = true });
                    File.WriteAllText(filePath, json);
                    Console.WriteLine("Players successfully saved to JSON file!");
                }
                void SaveDraftsToJson(List<Draft> drafts)
                {
                    string filePath = "drafts.json";
                    string json = JsonSerializer.Serialize(drafts, new JsonSerializerOptions { WriteIndented = true });
                    File.WriteAllText(filePath, json);
                    Console.WriteLine("Drafts successfully saved to JSON file!");
                }
                void SaveTeamsToJson(List<Teams> teams)
                {
                    string filePath = "teams.json";
                    string json = JsonSerializer.Serialize(teams, new JsonSerializerOptions { WriteIndented = true });
                    File.WriteAllText(filePath, json);
                    Console.WriteLine("Teams successfully saved to JSON file!");
                }




            }
        }




        public static List<PlayerRank_Stats> LoadPlayers()
        {
            if (!File.Exists("players.json"))
                return new List<PlayerRank_Stats>();
            var json = File.ReadAllText("players.json");
            return JsonSerializer.Deserialize<List<PlayerRank_Stats>>(json);
        }

        // Load teams list from JSON
        public static List<Teams> LoadTeams()
        {
            if (!File.Exists("teams.json"))
                return new List<Teams>();
            var json = File.ReadAllText("teams.json");
            return JsonSerializer.Deserialize<List<Teams>>(json);
        }

        // Save teams list to JSON
        public static void SaveTeamsToJson(List<Teams> teams)
        {
            var json = JsonSerializer.Serialize(teams, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText("teams.json", json);
        }

        // Load drafts list from JSON
        public static List<Draft> LoadDrafts()
        {
            if (!File.Exists("drafts.json"))
                return new List<Draft>();
            var json = File.ReadAllText("drafts.json");
            return JsonSerializer.Deserialize<List<Draft>>(json);
        }

        // Save drafts list to JSON
        public static void SaveDraftsToJson(List<Draft> drafts)
        {
            var json = JsonSerializer.Serialize(drafts, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText("drafts.json", json);
        }
    }
}