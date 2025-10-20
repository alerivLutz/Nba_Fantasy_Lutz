using System;
using System.Data;
using System.Drawing;
using System.Xml.Linq;

namespace NbaFantasyProjekt
{
    internal class Program
    {
        static void Main(string[] args)
        {
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

            Menu();
            string draftx;
        }

        public static void Menu()

        {
            List<PlayerRank_Stats> players = new List<PlayerRank_Stats>();
            List<Teams> teams = new List<Teams>();
            List<Draft> drafts = new List<Draft>();

            int auswahl = 0;
            List<string> options = new List<string>()
        {
            "1. Create a player data rank",
            "2. How many teams will be playing in the League",
            "3. Get draft order",
            "4. Start the draft!",

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
                    if (auswahl == 0)
                        PlayerRankDatabase();


                    // here we are creating the teams that will part take of the draft
                    else if (auswahl == 1)
                        TeamsCreation();

                    else if (auswahl == 2)
                        DraftLottery();

                    else if (auswahl == 3)
                        DraftStart();






                    void PlayerRankDatabase()


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

                            //This will allow us to make sure no players are created with out a name
                            if (name != null && name != "" && lastname != null && lastname != "")
                            {


                                int playerrank = rank;
                                var player = new PlayerRank_Stats(playerrank, name, lastname, points, assists, rebounds, threes, steals, blocks, tunronvers, fGpercent, fTpercent);
                                players.Add(player);


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
                    void TeamsCreation()
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
                    void DraftLottery()
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
                    void DraftStart()
                    {





                        Console.WriteLine("Lets start the draft!");
                        Console.WriteLine("All players \n\n");
                        Console.WriteLine("Rank\tName\tLast Name\tPoints\tAssists\tRebounds\tThrees\tSteals\tBlocks\tT.O\tFG%\tFT%");

                        for (int i = 0; i < players.Count; i++)
                        {
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

                    }
                    Console.ReadKey();
                }
            }





        }
    }

}






























