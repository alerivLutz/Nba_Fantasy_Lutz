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

            Console.ForegroundColor= ConsoleColor.White;
            Console.WriteLine("FFFFF   AAAAA  N     N  TTTTT  AAAAA  SSSS   Y   Y");
            Console.WriteLine("F       A   A  NN    N    T    A   A  S      Y   Y");
            Console.WriteLine("FFFF    AAAAA  N N   N    T    AAAAA  SSSS    Y Y ");
            Console.WriteLine("F       A   A  N  N  N    T    A   A     S     Y  ");
            Console.WriteLine("F       A   A  N   N N    T    A   A  SSSS     Y  ");
            Console.ResetColor();

            Console.ForegroundColor=ConsoleColor.Red;
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
                if (key == ConsoleKey.Enter) ;
            }
        }
    }
}