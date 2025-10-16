using System.Drawing;

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

        }

        public static void Menu()

        {
            List<PlayerRank_Stats> player = new List<PlayerRank_Stats>();

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
                    if (auswahl == 0)
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
                                Console.ForegroundColor= ConsoleColor.Red;
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






                    }
                }

            }
        }
    }
}


