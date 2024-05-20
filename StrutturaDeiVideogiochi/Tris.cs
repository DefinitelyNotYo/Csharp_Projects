internal class Program
{
    private static void Main(string[] args)
    {
        int[] buckets = [0, 0, 0, 0, 0, 0, 0, 0, 0];
        bool winCondition = false;
        int playerPlaying = 1;
        int winner = 0;
        while (winCondition == false)
        {
            Console.Clear();
            for (int i = 0; i < 9; i++)
            {
                if(i+1 == 1 || i + 1 == 3 || i + 1 == 5 || i + 1 == 7 || i + 1 == 9)
                {
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                    drawSign(buckets[i]);
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Gray;
                    drawSign(buckets[i]);
                }
                if (i == 2 || i == 5)
                    Console.Write("\n");
            }
            Console.Write("\n\n\n\n");
            for (int i = 0; i < 9; i++)
            {
                if (i + 1 == 1 || i + 1 == 3 || i + 1 == 5 || i + 1 == 7 || i + 1 == 9)
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                    Console.Write($" {i + 1}");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.Write($" {i + 1}");
                }
                if (i == 2 || i == 5)
                    Console.Write("\n");
            }
            Console.Write("\n\n\n\n");
            Console.ResetColor();
            if(winCondition == false)
            {
                Console.Write($"Tocca al giocatore {playerPlaying}\n");
                Console.Write("Indica quale casella vuoi marcare: ");
            }
            else
            {
                Console.Write($"Tocca al giocatore {playerPlaying}\n");
            }
            if (buckets[0] == 1 && buckets[1] == 1 && buckets[2] == 1 || buckets[3] == 1 && buckets[4] == 1 && buckets[5] == 1 || buckets[6] == 1 && buckets[7] == 1 && buckets[8] == 1 ||
                buckets[0] == 1 && buckets[3] == 1 && buckets[6] == 1 || buckets[1] == 1 && buckets[4] == 1 && buckets[7] == 1 || buckets[2] == 1 && buckets[5] == 1 && buckets[8] == 1 ||
                buckets[0] == 1 && buckets[4] == 1 && buckets[8] == 1 || buckets[2] == 1 && buckets[4] == 1 && buckets[6] == 1)
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write("\n\nVince il giocatore 1!");
                winCondition = true;
                Console.ResetColor();
                break;
            }
            if (buckets[0] == 2 && buckets[1] == 2 && buckets[2] == 2 || buckets[3] == 2 && buckets[4] == 2 && buckets[5] == 2 || buckets[6] == 2 && buckets[7] == 2 && buckets[8] == 2 ||
                buckets[0] == 2 && buckets[3] == 2 && buckets[6] == 2 || buckets[1] == 2 && buckets[4] == 2 && buckets[7] == 2 || buckets[2] == 2 && buckets[5] == 2 && buckets[8] == 2 ||
                buckets[0] == 2 && buckets[4] == 2 && buckets[8] == 2 || buckets[2] == 2 && buckets[4] == 2 && buckets[6] == 2)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Vince il giocatore 2!");
                winCondition = true;
                Console.ResetColor();
                break;
            }
            if (buckets[0] != 0 && buckets[1] != 0 && buckets[2] != 0 && buckets[3] != 0 && buckets[4] != 0 && buckets[5] != 0 && buckets[6] != 0 && buckets[7] != 0 && buckets[8] != 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Partita finita in pareggio!");
                winCondition = true;
                Console.ResetColor();
                break;
            }
            bool check = false;
            while(check == false)
            {
                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        if (buckets[0] == 0)
                        {
                            buckets[0] = playerPlaying;
                            check = true;
                            break;
                        }
                        else
                            break;
                    case "2":
                        if (buckets[1] == 0)
                        {
                            buckets[1] = playerPlaying;
                            check = true;
                            break;
                        }
                        else
                            break;
                    case "3":
                        if (buckets[2] == 0)
                        {
                            buckets[2] = playerPlaying;
                            check = true;
                            break;
                        }
                        else
                            break;
                    case "4":
                        if (buckets[3] == 0)
                        {
                            buckets[3] = playerPlaying;
                            check = true;
                            break;
                        }
                        else
                            break;
                    case "5":
                        if (buckets[4] == 0)
                        {
                            buckets[4] = playerPlaying;
                            check = true;
                            break;
                        }
                        else
                            break;
                    case "6":
                        if (buckets[5] == 0)
                        {
                            buckets[5] = playerPlaying;
                            check = true;
                            break;
                        }
                        else
                            break;
                    case "7":
                        if (buckets[6] == 0)
                        {
                            buckets[6] = playerPlaying;
                            check = true;
                            break;
                        }
                        else
                            break;
                    case "8":
                        if (buckets[7] == 0)
                        {
                            buckets[7] = playerPlaying;
                            check = true;
                            break;
                        }
                        else
                            break;
                    case "9":
                        if (buckets[8] == 0)
                        {
                            buckets[8] = playerPlaying;
                            check = true;
                            break;
                        }
                        else
                            break;
                    default:
                        break;
                }
            }
            if (playerPlaying == 1)
                playerPlaying = 2;
            else
                playerPlaying = 1;
        }



    }
    public static void drawSign(int bucket)
    {
        if (bucket == 1)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("X ");
        }
        else if (bucket == 2)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("O ");
        }
        else
            Console.Write("  ");

    }
}
