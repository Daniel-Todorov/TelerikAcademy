using System;

class Slides
{
    static void Main()
    {
        string dimentions = Console.ReadLine();
        string[] splitedDimentions = dimentions.Split(' ');
        int W = int.Parse(splitedDimentions[0]);
        int H = int.Parse(splitedDimentions[1]);
        int D = int.Parse(splitedDimentions[2]);
        
        string[, ,] cuboid = new string[W, H, D];
        
        for (int h = 0; h < H; h++)
        {
            string line = Console.ReadLine();
            string[] separator = { " | " };
            string[] depths = line.Split(separator, StringSplitOptions.RemoveEmptyEntries);
            for (int d = 0; d < D; d++)
            {
                char[] separators = { '(', ')' };
                string[] widths = depths[d].Split(separators, StringSplitOptions.RemoveEmptyEntries);
                for (int w = 0; w < W; w++)
                {
                    cuboid[w, h, d] = widths[w];
                }
            }
        }
        //string[, ,] cuboid = new string[3, 3, 3] { { { "S L", "E", "S L" }, { "S L", "S R", "S L" }, { "B", "S F", "S L" } }, 
        //                                             { { "S B", "S F", "E" }, { "S B", "S F", "T 1 1" }, { "S L", "S R", "B" } },
        //                                             { { "S FL", "S FL", "S FR" }, { "S FL", "S FL", "S FR" }, { "S F", "S BR", "S FR" } } };

        string initialCoords = Console.ReadLine();
        string[] splitedCoords = initialCoords.Split(' ');
        int ballW = int.Parse(splitedCoords[0]);
        int ballH = 0;
        int ballD = int.Parse(splitedCoords[1]);
        int[] currentCoords = { ballW, ballH, ballD };

        string msg = null;
        while (true)
        {
            if (cuboid[currentCoords[0], currentCoords[1], currentCoords[2]].Equals("B"))
            {
                msg = "No";
                break;
            }
            else if (cuboid[currentCoords[0], currentCoords[1], currentCoords[2]].Equals("E"))
            {
                currentCoords = FallThrough(currentCoords);
            }
            else if (cuboid[currentCoords[0], currentCoords[1], currentCoords[2]].StartsWith("T"))
            {
                currentCoords = TeleportTo(currentCoords, cuboid[currentCoords[0], currentCoords[1], currentCoords[2]]);
            }
            else if (cuboid[currentCoords[0], currentCoords[1], currentCoords[2]].StartsWith("S"))
            {
                currentCoords = Slide(currentCoords, cuboid[currentCoords[0], currentCoords[1], currentCoords[2]]);
            }

            if (currentCoords[0] >= cuboid.GetLength(0) || currentCoords[2] >= cuboid.GetLength(2) || currentCoords[0] < 0 || currentCoords[2] < 0)
            {
                msg = "No";
                break;
            }

            if (currentCoords[1] >= cuboid.GetLength(1))
            {
                msg = "Yes";
                break;
            }

            ballW = currentCoords[0];
            ballH = currentCoords[1];
            ballD = currentCoords[2];
        }
        Console.WriteLine(msg);
        Console.WriteLine("{0} {1} {2}", ballW, ballH, ballD);
    }

    static int[] FallThrough(int[] currentCoords)
    {
        currentCoords[0] = currentCoords[0];
        currentCoords[1] = currentCoords[1] + 1;
        currentCoords[2] = currentCoords[2];

        return currentCoords;
    }

    static int[] TeleportTo(int[] currentCoords, string teleportTo)
    {
        char[] separators = { ' ', 'T' };
        string[] teleportCoords = teleportTo.Split(separators, StringSplitOptions.RemoveEmptyEntries);

        currentCoords[0] = int.Parse(teleportCoords[0]);
        currentCoords[1] = currentCoords[1];
        currentCoords[2] = int.Parse(teleportCoords[1]);

        return currentCoords;
    }

    static int[] Slide(int[] currentCoords, string slideDirection)
    {
        //The directions are: “L” – left, “R” – right, “F” – front, “B” – back, “FL” – front left, “FR” – front right, “BL” – back left, “BR” – back right.
        if (slideDirection.Equals("S L"))
        {
            currentCoords[0] = currentCoords[0] - 1;
            currentCoords[1] = currentCoords[1] + 1;
            currentCoords[2] = currentCoords[2];
        }
        else if (slideDirection.Equals("S R"))
        {
            currentCoords[0] = currentCoords[0] + 1;
            currentCoords[1] = currentCoords[1] + 1;
            currentCoords[2] = currentCoords[2];
        }
        else if (slideDirection.Equals("S F"))
        {
            currentCoords[0] = currentCoords[0];
            currentCoords[1] = currentCoords[1] + 1;
            currentCoords[2] = currentCoords[2] - 1;
        }
        else if (slideDirection.Equals("S B"))
        {
            currentCoords[0] = currentCoords[0];
            currentCoords[1] = currentCoords[1] + 1;
            currentCoords[2] = currentCoords[2] + 1;
        }
        else if (slideDirection.Equals("S FL"))
        {
            currentCoords[0] = currentCoords[0] - 1;
            currentCoords[1] = currentCoords[1] + 1;
            currentCoords[2] = currentCoords[2] - 1;
        }
        else if (slideDirection.Equals("S FR"))
        {
            currentCoords[0] = currentCoords[0] + 1;
            currentCoords[1] = currentCoords[1] + 1;
            currentCoords[2] = currentCoords[2] - 1;
        }
        else if (slideDirection.Equals("S BL"))
        {
            currentCoords[0] = currentCoords[0] - 1;
            currentCoords[1] = currentCoords[1] + 1;
            currentCoords[2] = currentCoords[2] + 1;
        }
        else if (slideDirection.Equals("S BR"))
        {
            currentCoords[0] = currentCoords[0] + 1;
            currentCoords[1] = currentCoords[1] + 1;
            currentCoords[2] = currentCoords[2] + 1;
        }

        return currentCoords;
    }
}
