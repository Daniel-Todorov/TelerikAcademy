using System;
using System.Threading;
using System.Linq;

public class Rock
{
    public int YCoordinate { get; set; }
    public int XCoordinate { get; set; }
    public string Symbol { get; set; }
    public Rock(int yCoordinate, int xCoordinate, string symbol)
    {
        YCoordinate = yCoordinate;
        XCoordinate = xCoordinate;
        Symbol = symbol;
    }
}

class Program
{
    static void Main()
    {
        int scoreCounter = 0;
        string rockShape;
        int yCoordinate;
        var random = new Random();
        var chars = "^@*&+%$#!.;-";
        bool gameStart = true;
        int whileCounter = 0; //This is used as counter in one of the while loops
        int numberOfRocks;
        ConsoleKeyInfo startGame = new ConsoleKeyInfo();
        ConsoleKeyInfo cki = new ConsoleKeyInfo();
        Rock dwarf = new Rock(13, 20, "(0)");

        //Initializing the Rock object of every line of the game
        Rock[] line20 = new Rock[3];
        Rock[] line19 = new Rock[3];
        Rock[] line18 = new Rock[3];
        Rock[] line17 = new Rock[3];
        Rock[] line16 = new Rock[3];
        Rock[] line15 = new Rock[3];
        Rock[] line14 = new Rock[3];
        Rock[] line13 = new Rock[3];
        Rock[] line12 = new Rock[3];
        Rock[] line11 = new Rock[3];
        Rock[] line10 = new Rock[3];
        Rock[] line9 = new Rock[3];
        Rock[] line8 = new Rock[3];
        Rock[] line7 = new Rock[3];
        Rock[] line6 = new Rock[3];
        Rock[] line5 = new Rock[3];
        Rock[] line4 = new Rock[3];
        Rock[] line3 = new Rock[3];
        Rock[] line2 = new Rock[3];
        Rock[] line1 = new Rock[3];

        Console.WriteLine("FALLING ROCKS - the game");
        Console.WriteLine("a 'Zhak-Daniel-Iv' production");
        Console.WriteLine("");
        Console.WriteLine("You can move your dwarf - (0) -  by clicking the Right and Left arrow keys.");
        Console.WriteLine("Game ends if any of the falling rocks manage to hit your dwarf.");
        Console.WriteLine("The longer you survive, the more scores you'll get");
        Console.WriteLine("To exit the game, press ESC");
        Console.WriteLine("");
        Console.WriteLine("Press ENTER to start the game!!!");
        startGame = Console.ReadKey();

        while (startGame.Key == ConsoleKey.Enter && gameStart == true)
        {
            scoreCounter++;

            line1 = new Rock[3];

            Console.Clear();

            numberOfRocks = random.Next(0, 2);
            while (whileCounter <= numberOfRocks)
            {
                rockShape = null;
                rockShape = new string(Enumerable.Repeat(chars, 1).Select(s => s[random.Next(s.Length)]).ToArray());
                yCoordinate = random.Next(0, 36);
                line1[whileCounter] = new Rock(yCoordinate, 0, rockShape);
                whileCounter++;
            }
            whileCounter = 0;

            //Typing every rock in every line on the console
            foreach (Rock b in line1)
            {
                if (b != null)
                {
                    Console.SetCursorPosition(b.YCoordinate, 0);
                    Console.Write(b.Symbol);
                }
            }

            foreach (Rock b in line2)
            {
                if (b != null)
                {
                    Console.SetCursorPosition(b.YCoordinate, 1);
                    Console.Write(b.Symbol);
                }
            }

            foreach (Rock b in line3)
            {
                if (b != null)
                {
                    Console.SetCursorPosition(b.YCoordinate, 2);
                    Console.Write(b.Symbol);
                }
            }

            foreach (Rock b in line4)
            {
                if (b != null)
                {
                    Console.SetCursorPosition(b.YCoordinate, 3);
                    Console.Write(b.Symbol);
                }
            }

            foreach (Rock b in line5)
            {
                if (b != null)
                {
                    Console.SetCursorPosition(b.YCoordinate, 4);
                    Console.Write(b.Symbol);
                }
            }

            foreach (Rock b in line6)
            {
                if (b != null)
                {
                    Console.SetCursorPosition(b.YCoordinate, 5);
                    Console.Write(b.Symbol);
                }
            }

            foreach (Rock b in line7)
            {
                if (b != null)
                {
                    Console.SetCursorPosition(b.YCoordinate, 6);
                    Console.Write(b.Symbol);
                }
            }

            foreach (Rock b in line8)
            {
                if (b != null)
                {
                    Console.SetCursorPosition(b.YCoordinate, 7);
                    Console.Write(b.Symbol);
                }
            }

            foreach (Rock b in line9)
            {
                if (b != null)
                {
                    Console.SetCursorPosition(b.YCoordinate, 8);
                    Console.Write(b.Symbol);
                }
            }

            foreach (Rock b in line10)
            {
                if (b != null)
                {
                    Console.SetCursorPosition(b.YCoordinate, 9);
                    Console.Write(b.Symbol);
                }
            }

            foreach (Rock b in line11)
            {
                if (b != null)
                {
                    Console.SetCursorPosition(b.YCoordinate, 10);
                    Console.Write(b.Symbol);
                }
            }

            foreach (Rock b in line12)
            {
                if (b != null)
                {
                    Console.SetCursorPosition(b.YCoordinate, 11);
                    Console.Write(b.Symbol);
                }
            }

            foreach (Rock b in line13)
            {
                if (b != null)
                {
                    Console.SetCursorPosition(b.YCoordinate, 12);
                    Console.Write(b.Symbol);
                }
            }

            foreach (Rock b in line14)
            {
                if (b != null)
                {
                    Console.SetCursorPosition(b.YCoordinate, 13);
                    Console.Write(b.Symbol);
                }
            }

            foreach (Rock b in line15)
            {
                if (b != null)
                {
                    Console.SetCursorPosition(b.YCoordinate, 14);
                    Console.Write(b.Symbol);
                }
            }

            foreach (Rock b in line16)
            {
                if (b != null)
                {
                    Console.SetCursorPosition(b.YCoordinate, 15);
                    Console.Write(b.Symbol);
                }
            }

            foreach (Rock b in line17)
            {
                if (b != null)
                {
                    Console.SetCursorPosition(b.YCoordinate, 16);
                    Console.Write(b.Symbol);
                }
            }

            foreach (Rock b in line18)
            {
                if (b != null)
                {
                    Console.SetCursorPosition(b.YCoordinate, 17);
                    Console.Write(b.Symbol);
                }
            }

            foreach (Rock b in line19)
            {
                if (b != null)
                {
                    Console.SetCursorPosition(b.YCoordinate, 18);
                    Console.Write(b.Symbol);
                }
            }

            foreach (Rock b in line20)
            {
                if (b != null)
                {
                    Console.SetCursorPosition(b.YCoordinate, 19);
                    Console.Write(b.Symbol);
                }
            }

            //Type rocks at line 20 and check if the coordinates of any rock match the coordinates of the dwarf's body
            foreach (Rock b in line20)
            {
                if (b != null)
                {
                    if (b.YCoordinate == dwarf.YCoordinate || b.YCoordinate == dwarf.YCoordinate + 1 || b.YCoordinate == dwarf.YCoordinate + 2)
                    {
                        gameStart = false;
                        Console.Clear();
                        Console.WriteLine("Your dwarf was smashed like a bug by a huge rock :(");
                        Console.WriteLine("However you managed to get {0} scores!", scoreCounter);
                        Console.WriteLine("Try again if you dare!");
                        Thread.Sleep(5000);
                    }
                }
            }

            //Move all rocks with one line
            line20 = line19;
            line19 = line18;
            line18 = line17;
            line17 = line16;
            line16 = line15;
            line15 = line14;
            line14 = line13;
            line13 = line12;
            line12 = line11;
            line11 = line10;
            line10 = line9;
            line9 = line8;
            line8 = line7;
            line7 = line6;
            line6 = line5;
            line5 = line4;
            line4 = line3;
            line3 = line2;
            line2 = line1;

            //Implementing a key to Exit the game
            while (Console.KeyAvailable == true)
            {
                cki = Console.ReadKey();

                if (cki.Key == ConsoleKey.LeftArrow && dwarf.YCoordinate > 0)
                {
                    dwarf.YCoordinate = dwarf.YCoordinate - 1;
                }

                if (cki.Key == ConsoleKey.RightArrow && dwarf.YCoordinate < 33)
                {
                    dwarf.YCoordinate = dwarf.YCoordinate + 1;
                }

                if (cki.Key == ConsoleKey.Escape)
                {
                    startGame = new ConsoleKeyInfo();
                    Console.Clear();
                    Console.WriteLine("Why the hell you left? :(");
                    Console.WriteLine("You managed to get {0} scores!", scoreCounter);
                    Console.WriteLine("Try again if you dare!");
                    Thread.Sleep(10000);
                }
            }

            //Type the dwarf at line 20 of the console
            Console.SetCursorPosition(dwarf.YCoordinate, 19);
            Console.Write(dwarf.Symbol);

            //Set game speed to 150 milisecodns according to the condition
            Thread.Sleep(150);
        }
    }
}
