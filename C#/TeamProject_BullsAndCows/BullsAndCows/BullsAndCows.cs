using System;
using System.Linq;
using System.IO;

class BullsAndCows
{
    static void Main()
    {
        Console.SetWindowSize(80, 30);
        StartPage();
    }

    static void StartPage()
    {
        while (true)
        {
            Console.Clear();

            PrintCenteredAt("B U L L S   A N D   C O W S", 2);
            PrintCenteredAt("by team \"Droopy\"", 4);
            PrintCenteredAt("Welcome to our game!", 9);
            PrintCenteredAt("We wish you lots of fun playing it!", 11);

            Console.SetCursorPosition(20, 20);
            Console.WriteLine("Press  'S'  to Start a new game!");
            Console.SetCursorPosition(20, 21);
            Console.WriteLine("Press  'V'  to view HIGH SCORES!");
            Console.SetCursorPosition(20, 22);
            Console.WriteLine("Press  'H'  for HELP!");
            Console.SetCursorPosition(20, 23);
            Console.WriteLine("Press  'Q'  to QUIT the game!");

            Console.SetCursorPosition((Console.WindowWidth / 2), 25);
            ReadKeyStartPage();
        }
    }

    static void ReadKeyStartPage()
    {
        ConsoleKeyInfo pressed = new ConsoleKeyInfo();
        bool isValid = false;
        while (!isValid)
        {
            pressed = Console.ReadKey(true);

            if (pressed.Key == ConsoleKey.S)
            {
                isValid = true;
                StartNewGame();
            }
            else if (pressed.Key == ConsoleKey.V)
            {
                isValid = true;
                ViewHighscores();
            }
            else if (pressed.Key == ConsoleKey.H)
            {
                isValid = true;
                HelpPage();
            }
            else if (pressed.Key == ConsoleKey.Q)
            {
                isValid = true;
                Exit();
            }
            else
            {
                string msg = ("Invalid key, please, try again!");
                Console.SetCursorPosition(20, 25);
                Console.WriteLine(msg);
                Console.SetCursorPosition(20, 25);
            }
        }
        return;
    }

    static void HelpPage()
    {
        Console.Clear();

        string msg = "RULES";
        Console.SetCursorPosition((Console.WindowWidth / 2) - msg.Length / 2, 2);
        Console.WriteLine(msg);
        msg = "On a sheet of paper, the players each write a 4-digit secret number.";
        Console.SetCursorPosition(2, 5);
        Console.WriteLine(msg);
        msg = "The digits must be all different. Then, in turn, the players try to";
        Console.SetCursorPosition(2, 6);
        Console.WriteLine(msg);
        msg = "guess their opponent's number who gives the number of matches.";
        Console.SetCursorPosition(2, 7);
        Console.WriteLine(msg);
        msg = "If the matching digits are on their right positions, they are \"bulls\",";
        Console.SetCursorPosition(2, 8);
        Console.WriteLine(msg);
        msg = "if on different positions, they are \"cows\".";
        Console.SetCursorPosition(2, 9);
        Console.WriteLine(msg);
        msg = "Example:";
        Console.SetCursorPosition(6, 11);
        Console.WriteLine(msg);
        msg = "Secret number: 4271";
        Console.SetCursorPosition(2, 12);
        Console.WriteLine(msg);
        msg = "Player's try : 1234";
        Console.SetCursorPosition(2, 13);
        Console.WriteLine(msg);
        msg = "Result: 1 BULLS and 2 COWS.";
        Console.SetCursorPosition(2, 14);
        Console.WriteLine(msg);
        msg = "(The bull is \"2\", the cows are \"4\" and \"1\".)";
        Console.SetCursorPosition(2, 15);
        Console.WriteLine(msg);
        msg = "You start the game with 10 000 points and you will lose some of them";
        Console.SetCursorPosition(2, 17);
        Console.WriteLine(msg);
        msg = "depending on the number of your tries and the elapsed time.";
        Console.SetCursorPosition(2, 18);
        Console.WriteLine(msg);
        Console.SetCursorPosition(20, 22);
        Console.WriteLine("Press 'Esc' to go BACK!");
        Console.SetCursorPosition(20, 23);
        Console.WriteLine("Press  'Q'  to Quit game!");

        Console.SetCursorPosition((Console.WindowWidth / 2), 25);
        ReadKeyHelpPage();
        return;
    }

    static void ReadKeyHelpPage()
    {
        ConsoleKeyInfo pressed = new ConsoleKeyInfo();

        while (true)
        {
            pressed = Console.ReadKey(true);

            if (pressed.Key == ConsoleKey.Escape)
            {
                return;
            }
            else if (pressed.Key == ConsoleKey.Q)
            {
                Exit();
            }
            else
            {
                string msg = ("Invalid key, please, try again!");
                Console.SetCursorPosition(20, 25);
                Console.WriteLine(msg);
                Console.SetCursorPosition(20, 25);
            }
        }
    }

    static void ViewHighscores()
    {
        string[] scoresName = new string[10];
        int[] scoresValue = new int[10];
        string scoresFileName = "highscores.txt";

        ReadScoresFile(scoresName, scoresValue, scoresFileName);

        Console.Clear();

        PrintHighScores(scoresName, scoresValue, 5);

        Console.SetCursorPosition(20, 22);
        Console.WriteLine("Press 'Esc' to go BACK!");
        Console.SetCursorPosition(20, 23);
        Console.WriteLine("Press  'Q'  to QUIT!");

        Console.SetCursorPosition((Console.WindowWidth / 2), 25);
        ReadViewHighScoresPage();
        return;
    }

    static void ReadViewHighScoresPage()
    {
        ConsoleKeyInfo pressed = new ConsoleKeyInfo();

        while (true)
        {
            pressed = Console.ReadKey(true);

            if (pressed.Key == ConsoleKey.Escape)
            {
                return;
            }
            else if (pressed.Key == ConsoleKey.Q)
            {
                Exit();
            }
            else
            {
                string msg = ("Invalid key, please, try again!");
                Console.SetCursorPosition(20, 25);
                Console.WriteLine(msg);
                Console.SetCursorPosition(20, 25);
            }
        }
    }

    static void StartNewGame()
    {
        Console.Clear();

        string playerNumber = "";
        string msg = null;
        string randomNumber = null;
        string[,] results = new string[2, 10];
        string scores = "10000";
        bool victory = false;
        ConsoleKeyInfo pressed;
        DateTime startTime;
        DateTime endTime;

        Console.SetCursorPosition(3, 1);
        Console.Write("Scores:");
        Console.SetCursorPosition(3, 2);
        Console.Write(scores);

        randomNumber = GenerateRandomNumber();
        msg = "Guess the hidden number!";
        Console.SetCursorPosition((Console.WindowWidth / 2) - (msg.Length / 2), 2);
        Console.WriteLine(msg);
        msg = "* * * *";
        Console.SetCursorPosition((Console.WindowWidth / 2) - (msg.Length / 2), 4);
        Console.WriteLine(msg);
        msg = "Your try:";
        Console.SetCursorPosition(25, 7);
        Console.Write(msg);

        Console.SetCursorPosition(20, 22);
        Console.WriteLine("Press 'Esc' to cancel the game!");

        int leftCoordinates = 37;
        int topCoordinates = 7;
        while (!victory)
        {
            startTime = DateTime.Now;

            while (playerNumber.Length < 4)
            {
                Console.SetCursorPosition(leftCoordinates, topCoordinates);
                pressed = Console.ReadKey();
                while (pressed.Key != ConsoleKey.D0 && pressed.Key != ConsoleKey.D1 && pressed.Key != ConsoleKey.D2 && pressed.Key != ConsoleKey.D3 &&
                    pressed.Key != ConsoleKey.D4 && pressed.Key != ConsoleKey.D5 && pressed.Key != ConsoleKey.D6 && pressed.Key != ConsoleKey.D7 &&
                    pressed.Key != ConsoleKey.D8 && pressed.Key != ConsoleKey.D9 &&
                    pressed.Key != ConsoleKey.NumPad0 && pressed.Key != ConsoleKey.NumPad1 && pressed.Key != ConsoleKey.NumPad2 && pressed.Key != ConsoleKey.NumPad3 &&
                    pressed.Key != ConsoleKey.NumPad4 && pressed.Key != ConsoleKey.NumPad5 && pressed.Key != ConsoleKey.NumPad6 && pressed.Key != ConsoleKey.NumPad7 &&
                    pressed.Key != ConsoleKey.NumPad8 && pressed.Key != ConsoleKey.NumPad9)
                {
                    if (pressed.Key == ConsoleKey.Escape)
                    {
                        return;
                    }
                    Console.SetCursorPosition(leftCoordinates, topCoordinates);
                    Console.Write(" ");
                    Console.SetCursorPosition(leftCoordinates, topCoordinates);
                    pressed = Console.ReadKey();
                }
                playerNumber = playerNumber + pressed.KeyChar;
                leftCoordinates += 2;
            }
            Console.SetCursorPosition(leftCoordinates + 2, topCoordinates);
            Console.Write("Press Enter!");
            Console.SetCursorPosition(leftCoordinates + 2, topCoordinates);
            pressed = Console.ReadKey(true);
            while (pressed.Key != ConsoleKey.Enter && pressed.Key != ConsoleKey.Escape)
            {
                msg = "                                                  ";
                Console.SetCursorPosition((Console.WindowWidth / 2) - (msg.Length / 2), topCoordinates + 2);
                Console.WriteLine(msg);
                msg = "Invalid key. Try again!";
                Console.SetCursorPosition((Console.WindowWidth / 2) - (msg.Length / 2), topCoordinates + 2);
                Console.WriteLine(msg);
                Console.SetCursorPosition(leftCoordinates + 2, topCoordinates);
                pressed = Console.ReadKey(true);
            }
            if (pressed.Key == ConsoleKey.Escape)
            {
                return;
            }

            if (pressed.Key == ConsoleKey.Enter)
            {
                if (ValidatePlayerNumber(playerNumber) == false)
                {
                    topCoordinates = topCoordinates + 2;
                    msg = "                                                  ";
                    Console.SetCursorPosition((Console.WindowWidth / 2) - (msg.Length / 2), topCoordinates);
                    Console.WriteLine(msg);
                    msg = "All digits must be different. Try again!";
                    Console.SetCursorPosition((Console.WindowWidth / 2) - (msg.Length / 2), topCoordinates);
                    Console.WriteLine(msg);
                }
                else
                {
                    victory = CheckForVictory(randomNumber, playerNumber);

                    if (victory == false)
                    {
                        topCoordinates = topCoordinates + 2;
                        msg = "                                                  ";
                        Console.SetCursorPosition((Console.WindowWidth / 2) - (msg.Length / 2), topCoordinates);
                        Console.WriteLine(msg);
                        msg = CheckForBullsAndCows(playerNumber, randomNumber);
                        Console.SetCursorPosition((Console.WindowWidth / 2) - (msg.Length / 2), topCoordinates);
                        Console.WriteLine(msg);

                        leftCoordinates = 0;
                        topCoordinates = topCoordinates + 2;
                        for (int row = 0; row < results.GetLength(0); row++)
                        {
                            for (int col = 0; col < results.GetLength(1); col++)
                            {
                                Console.SetCursorPosition(leftCoordinates, topCoordinates);
                                Console.WriteLine(results[row, col]);
                                topCoordinates++;
                            }
                            leftCoordinates = Console.WindowWidth / 2;
                            topCoordinates = topCoordinates - 10;
                        }

                        results = AddToResults(msg, results);
                    }
                    else
                    {
                        break;
                    }
                }
            }
            Console.SetCursorPosition(3, 1);
            Console.Write("Scores:");
            endTime = DateTime.Now;
            scores = CountScores(startTime, endTime, scores);
            Console.SetCursorPosition(3, 2);
            Console.WriteLine("     ");
            Console.SetCursorPosition(3, 2);
            Console.Write(scores);

            leftCoordinates = 37;
            topCoordinates = 7;
            Console.SetCursorPosition(leftCoordinates, topCoordinates);
            Console.Write("                               ");
            playerNumber = "";
        }

        VictoryPage(scores);
    }

    static string GenerateRandomNumber()
    {
        string randomNumber = null;
        char[] chars = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        Random generator = new Random();

        while (randomNumber == null || randomNumber[0] == randomNumber[1] || randomNumber[0] == randomNumber[2] || randomNumber[0] == randomNumber[3] || randomNumber[1] == randomNumber[2] || randomNumber[1] == randomNumber[3] || randomNumber[2] == randomNumber[3])
        {
            randomNumber = null;
            randomNumber = randomNumber + chars[generator.Next(1, 10)];
            for (int i = 0; i < 3; i++)
            {
                randomNumber = randomNumber + chars[generator.Next(0, 10)];
            }
        }

        return randomNumber;
    }

    static string[,] AddToResults(string msg, string[,] initial)
    {
        string[,] results = new string[2, 10];

        results[0, 0] = msg;
        for (int col = 1; col < results.GetLength(1); col++)
        {
            results[0, col] = initial[0, col - 1];
        }
        results[1, 0] = initial[0, 9];
        for (int col = 1; col < results.GetLength(1); col++)
        {
            results[1, col] = initial[1, col - 1];
        }

        return results;
    }

    static string CheckForBullsAndCows(string playerNumber, string randomNumber)
    {
        string result = null;
        int bulls = 0;
        int cows = 0;

        for (int i = 0; i < playerNumber.Length; i++)
        {
            if (playerNumber[i] == randomNumber[i])
            {
                bulls++;
            }
        }
        if (playerNumber[0] == randomNumber[1] || playerNumber[0] == randomNumber[2] || playerNumber[0] == randomNumber[3])
        {
            cows++;
        }
        if (playerNumber[1] == randomNumber[0] || playerNumber[1] == randomNumber[2] || playerNumber[1] == randomNumber[3])
        {
            cows++;
        }
        if (playerNumber[2] == randomNumber[0] || playerNumber[2] == randomNumber[1] || playerNumber[2] == randomNumber[3])
        {
            cows++;
        }
        if (playerNumber[3] == randomNumber[0] || playerNumber[3] == randomNumber[1] || playerNumber[3] == randomNumber[2])
        {
            cows++;
        }

        result = "Number " + playerNumber + " : " + bulls + " BULLS and " + cows + " COWS!";

        return result;
    }

    static bool ValidatePlayerNumber(string playerNumber)
    {
        bool isValid =
            playerNumber[0] != playerNumber[1] && playerNumber[0] != playerNumber[2] &&
            playerNumber[0] != playerNumber[3] && playerNumber[1] != playerNumber[2] &&
            playerNumber[1] != playerNumber[3] && playerNumber[2] != playerNumber[3];

        return isValid;
    }

    static string CountScores(DateTime startime, DateTime endTime, string scores)
    {
        double scoresConvertor = double.Parse(scores);
        TimeSpan timeDifference = (endTime - startime);
        scoresConvertor = scoresConvertor - double.Parse(timeDifference.TotalSeconds.ToString());
        scoresConvertor = scoresConvertor - 50.0;

        scores = ((int)scoresConvertor).ToString();

        return scores;
    }

    static bool CheckForVictory(string randomNumber, string playerNumber)
    {
        bool victory = false;

        if (randomNumber.CompareTo(playerNumber) == 0)
        {
            victory = true;
        }

        return victory;
    }

    static void VictoryPage(string scores)
    {
        Console.Clear();
        int score = int.Parse(scores);
        string playerName = null;
        string msg = null;
        string[] scoresName = new string[10];
        int[] scoresValue = new int[10];
        string scoresFileName = "highscores.txt";
        int lowestHighscores = 0;

        PrintCenteredAt("CONGRATULATIONS!", 2);
        PrintCenteredAt("You have won this trial of inteligence", 4);
        PrintCenteredAt("with the scores of " + scores, 5);

        ReadScoresFile(scoresName, scoresValue, scoresFileName);

        lowestHighscores = scoresValue[scoresValue.Length - 1];

        PrintHighScores(scoresName, scoresValue, 11);

        if (lowestHighscores >= int.Parse(scores))
        {
            PrintCenteredAt("Alas, your result is not high enough to earn you a place in our scoreboard!", 8);
        }
        else
        {
            PrintCenteredAt("You earned your place in our scoreboard!", 7);
            PrintCenteredAt("Type your name (up to 14 symbols) and press Enter:", 8);
            Console.SetCursorPosition((Console.WindowWidth / 2) - 6, 9);
            
            playerName = ValidatePlayerName();

            scoresValue[scoresValue.Length - 1] = score;
            scoresName[scoresName.Length - 1] = playerName;
            Array.Sort(scoresValue, scoresName);
            Array.Reverse(scoresValue);
            Array.Reverse(scoresName);

            PrintHighScores(scoresName, scoresValue, 11);

            WriteScoresFile(scoresName, scoresValue, scoresFileName);
        }
        msg = "Press 'Esc' to go to the Main Menu";
        Console.SetCursorPosition(20, 25);
        Console.WriteLine(msg);
        msg = "Press  'Q'  to QUIT game";
        Console.SetCursorPosition(20, 26);
        Console.WriteLine(msg);

        Console.SetCursorPosition((Console.WindowWidth / 2), 28);
        ReadKeyVictoryPage();
        return;
    }

    static string ValidatePlayerName()
    {
        string playerName = Console.ReadLine();

        while (playerName.Length > 14 || playerName.Length == 0)
        {
            Console.SetCursorPosition(0, 8);
            string msg = new string(' ', Console.WindowWidth);
            Console.WriteLine(msg);
            Console.SetCursorPosition((Console.WindowWidth / 2) - 6, 8);
            playerName = Console.ReadLine();
        }
        
        return playerName;
    }

    static void PrintHighScores(string[] scoresName, int[] scoresValue, int startLine)
    {
        int winStart = Console.WindowWidth/2 - 15;
        PrintCenteredAt("H I G H    S C O R E S", startLine);
        Console.CursorLeft = winStart;
        Console.WriteLine(new String('-', 30));

        for (int i = 0; i < scoresValue.Length; i++)
        {
            Console.CursorLeft = winStart;
            if (scoresValue[i] > 0)
            {
                Console.WriteLine("| {0,2}. {1,-14} - {2,5} |", i + 1, scoresName[i], scoresValue[i]);
            }
            else
            {
                Console.WriteLine("|" + new String(' ', 28) + "|", scoresValue.Length - i, scoresName[i], scoresValue[i]);
            }
        }
        Console.CursorLeft = winStart;
        Console.WriteLine(new String('-', 30));
    }

    static void ReadScoresFile(string[] scoresName, int[] scoresValue, string scoresFileName)
    {
        try
        {
            StreamReader readScores = new StreamReader(scoresFileName);
            using (readScores)
            {
                string line;
                for (int i = 0; i < scoresValue.Length; i++)
                {
                    if ((line = readScores.ReadLine()) != null)
                    {
                        scoresName[i] = line;
                    }
                    if ((line = readScores.ReadLine()) != null)
                    {
                        scoresValue[i] = int.Parse(line);
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }
        catch (FileNotFoundException)
        {
            using (File.Create(scoresFileName))
            {
            }
        }
        catch (FormatException fe)
        {
            FileErrorMessage(fe.Message);
        }
        catch (System.IO.PathTooLongException ptle)
        {
            FileErrorMessage(ptle.Message);
        }
        catch (System.IO.DirectoryNotFoundException dnfe)
        {
            FileErrorMessage(dnfe.Message);
        }
        catch (System.IO.IOException ioe)
        {
            FileErrorMessage(ioe.Message);
        }
        catch (System.UnauthorizedAccessException uae)
        {
            FileErrorMessage(uae.Message);
        }
        catch (System.NotSupportedException nse)
        {
            FileErrorMessage(nse.Message);
        }
        catch (System.Security.SecurityException se)
        {
            FileErrorMessage(se.Message);
        }
    }

    static void WriteScoresFile(string[] scoresName, int[] scoresValue, string scoresFileName)
    {
        try
        {
            StreamWriter writeScores = new StreamWriter(scoresFileName);
            using (writeScores)
            {
                for (int i = 0; i < scoresValue.Length; i++)
                {
                    writeScores.WriteLine(scoresName[i]);
                    writeScores.WriteLine(scoresValue[i]);
                }
            }
            writeScores.Dispose();
        }
        catch (FileNotFoundException)
        {
            using (File.Create(scoresFileName))
            {
            }
        }
        catch (FormatException fe)
        {
            FileErrorMessage(fe.Message);
        }
        catch (System.IO.PathTooLongException ptle)
        {
            FileErrorMessage(ptle.Message);
        }
        catch (System.IO.DirectoryNotFoundException dnfe)
        {
            FileErrorMessage(dnfe.Message);
        }
        catch (System.IO.IOException ioe)
        {
            FileErrorMessage(ioe.Message);
        }
        catch (System.UnauthorizedAccessException uae)
        {
            FileErrorMessage(uae.Message);
        }
        catch (System.NotSupportedException nse)
        {
            FileErrorMessage(nse.Message);
        }
        catch (System.Security.SecurityException se)
        {
            FileErrorMessage(se.Message);
        }
    }

    static void FileErrorMessage(string message)
    {
        int windowTop = Console.CursorTop;
        Console.WriteLine();
        Console.WriteLine("There were following problem with scores file:");
        Console.WriteLine(message);
        Console.WriteLine("Press Enter to continue");
        Console.ReadLine();
        int windowBottom = Console.CursorTop;
        Console.CursorTop = windowTop;
        string blankLine = new String(' ', Console.WindowWidth - 1);
        for (int i = windowTop; i <= windowBottom; i++)
        {
            Console.WriteLine(blankLine);
        }
    }

    static void PrintCenteredAt(string message, int verticalPos)
    {
        Console.SetCursorPosition(((Console.WindowWidth - message.Length) / 2), verticalPos);
        Console.WriteLine(message);
    }

    static void ReadKeyVictoryPage()
    {
        ConsoleKeyInfo pressed = new ConsoleKeyInfo();

        while (true)
        {
            pressed = Console.ReadKey(true);

            if (pressed.Key == ConsoleKey.Escape)
            {
                return;
            }
            else if (pressed.Key == ConsoleKey.Q)
            {
                Exit();
            }
            else
            {
                string msg = ("Invalid key, please, try again!");
                Console.SetCursorPosition(20, 27);
                Console.WriteLine(msg);
                Console.SetCursorPosition(20, 27);
            }
        }
    }

    static void Exit()
    {
        Environment.Exit(0);
    }
}
