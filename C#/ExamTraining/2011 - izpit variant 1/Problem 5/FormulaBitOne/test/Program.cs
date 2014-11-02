using System;

class FormulaBitOne
{
    static void Main()
    {
        int line1 = int.Parse(Console.ReadLine());
        int line2 = int.Parse(Console.ReadLine());
        int line3 = int.Parse(Console.ReadLine());
        int line4 = int.Parse(Console.ReadLine());
        int line5 = int.Parse(Console.ReadLine());
        int line6 = int.Parse(Console.ReadLine());
        int line7 = int.Parse(Console.ReadLine());
        int line8 = int.Parse(Console.ReadLine());

        int[] line1Bit = GetIntBinaryString(line1);
        int[] line2Bit = GetIntBinaryString(line2);
        int[] line3Bit = GetIntBinaryString(line3);
        int[] line4Bit = GetIntBinaryString(line4);
        int[] line5Bit = GetIntBinaryString(line5);
        int[] line6Bit = GetIntBinaryString(line6);
        int[] line7Bit = GetIntBinaryString(line7);
        int[] line8Bit = GetIntBinaryString(line8);

        //...........................................................................................

        foreach (var a in line1Bit)
        {
            Console.Write(a);
        }
        Console.WriteLine("");
        foreach (var a in line2Bit)
        {
            Console.Write(a);
        }
        Console.WriteLine("");
        foreach (var a in line3Bit)
        {
            Console.Write(a);
        }
        Console.WriteLine("");
        foreach (var a in line4Bit)
        {
            Console.Write(a);
        }
        Console.WriteLine("");
        foreach (var a in line5Bit)
        {
            Console.Write(a);
        }
        Console.WriteLine("");
        foreach (var a in line6Bit)
        {
            Console.Write(a);
        }
        Console.WriteLine("");
        foreach (var a in line7Bit)
        {
            Console.Write(a);
        }
        Console.WriteLine("");
        foreach (var a in line8Bit)
        {
            Console.Write(a);
        }
        Console.WriteLine("");

        //...........................................................................................

        int positionX = 7;
        int positionY = 1;
        int counter = 0;
        int checker = 0;

        bool moveSouth = true;
        bool moveWest = false;
        bool moveNorth = false;
        bool lastTrack = true;

        //move south

        while (moveSouth == true)
        {
            switch (positionY)
            {
                case 1:
                    if (line1Bit[positionX] == 0)
                    {
                        counter++;
                        positionY++;
                    }
                    else
                    {
                        if (checker == 1)
                        {
                            lastTrack = false;
                        }
                        else
                        {
                            checker++;
                            moveSouth = false;
                            moveWest = true;
                            positionY--;
                            if (positionX > 0)
                            {
                                positionX--;
                            }
                            else
                            {
                                lastTrack = false;
                            }    
                        }
                    }
                    break;
                case 2:
                    if (line2Bit[positionX] == 0)
                    {
                        counter++;
                        positionY++;
                    }
                    else
                    {
                        if (checker == 1)
                        {
                            lastTrack = false;
                        }
                        else
                        {
                            checker++;
                            moveSouth = false;
                            moveWest = true;
                            positionY--;
                            if (positionX > 0)
                            {
                                positionX--;
                            }
                            else
                            {
                                lastTrack = false;
                            }   
                        }
                    }
                    break;
                case 3:
                    if (line3Bit[positionX] == 0)
                    {
                        counter++;
                        positionY++;
                    }
                    else
                    {
                        if (checker == 1)
                        {
                            lastTrack = false;
                        }
                        else
                        {
                            checker++;
                            moveSouth = false;
                            moveWest = true;
                            positionY--;
                            if (positionX > 0)
                            {
                                positionX--;
                            }
                            else
                            {
                                lastTrack = false;
                            }   
                        }
                    }
                    break;
                case 4:
                    if (line4Bit[positionX] == 0)
                    {
                        counter++;
                        positionY++;
                    }
                    else
                    {
                        if (checker == 1)
                        {
                            lastTrack = false;
                        }
                        else
                        {
                            checker++;
                            moveSouth = false;
                            moveWest = true;
                            positionY--;
                            if (positionX > 0)
                            {
                                positionX--;
                            }
                            else
                            {
                                lastTrack = false;
                            }   
                        }
                    }
                    break;
                case 5:
                    if (line5Bit[positionX] == 0)
                    {
                        counter++;
                        positionY++;
                    }
                    else
                    {
                        if (checker == 1)
                        {
                            lastTrack = false;
                        }
                        else
                        {
                            checker++;
                            moveSouth = false;
                            moveWest = true;
                            positionY--;
                            if (positionX > 0)
                            {
                                positionX--;
                            }
                            else
                            {
                                lastTrack = false;
                            }   
                        }
                    }
                    break;
                case 6:
                    if (line6Bit[positionX] == 0)
                    {
                        counter++;
                        positionY++;
                    }
                    else
                    {
                        if (checker == 1)
                        {
                            lastTrack = false;
                        }
                        else
                        {
                            checker++;
                            moveSouth = false;
                            moveWest = true;
                            positionY--;
                            if (positionX > 0)
                            {
                                positionX--;
                            }
                            else
                            {
                                lastTrack = false;
                            }   
                        }
                    }
                    break;
                case 7:
                    if (line7Bit[positionX] == 0)
                    {
                        counter++;
                        positionY++;
                    }
                    else
                    {
                        if (checker == 1)
                        {
                            lastTrack = false;
                        }
                        else
                        {
                            checker++;
                            moveSouth = false;
                            moveWest = true;
                            positionY--;
                            if (positionX > 0)
                            {
                                positionX--;
                            }
                            else
                            {
                                lastTrack = false;
                            }   
                        }
                    }
                    break;
                case 8:
                    if (line8Bit[positionX] == 0)
                    {
                        counter++;
                        if (positionX > 0)
                        {
                            positionX--;
                        }
                        else
                        {
                            lastTrack = false;
                        }   
                        moveSouth = false;
                        moveWest = true;
                    }
                    else
                    {
                        if (checker == 1)
                        {
                            lastTrack = false;
                        }
                        else
                        {
                            checker++;
                            moveSouth = false;
                            moveWest = true;
                            positionY--;
                            positionX--;
                        }
                    }
                    break;
                default:
                    break;
            }
        }

        while (moveWest == true)
        {
            switch (positionY)
            {
                case 1:
                    while (line1Bit[positionX] == 0)
                    {
                        counter++;
                        if (positionX > 0)
                        {
                            positionX--;
                        }
                        else
                        {
                            moveWest = false;
                            moveNorth = true;
                            positionY--;
                            checker++;
                        }
                    }
                    if (line1Bit[positionX] == 1 && moveWest == true)
                    {
                        moveWest = false;
                        moveNorth = true;
                        positionY--;
                        positionX++;
                        checker++;
                    }
                    break;
                case 2:
                    while (line2Bit[positionX] == 0)
                    {
                        counter++;
                        if (positionX > 0)
                        {
                            positionX--;
                        }
                        else
                        {
                            moveWest = false;
                            moveNorth = true;
                            positionY--;
                            checker++;
                        }
                    }
                    if (line2Bit[positionX] == 1 && moveWest == true)
                    {
                        moveWest = false;
                        moveNorth = true;
                        positionY--;
                        positionX++;
                        checker++;
                    }
                    break;
                case 3:
                    while (line3Bit[positionX] == 0)
                    {
                        counter++;
                        if (positionX > 0)
                        {
                            positionX--;
                        }
                        else
                        {
                            moveWest = false;
                            moveNorth = true;
                            positionY--;
                            checker++;
                        }
                    }
                    if (line3Bit[positionX] == 1 && moveWest == true)
                    {
                        moveWest = false;
                        moveNorth = true;
                        positionY--;
                        positionX++;
                        checker++;
                    }
                    break;
                case 4:
                    while (line4Bit[positionX] == 0)
                    {
                        counter++;
                        if (positionX > 0)
                        {
                            positionX--;
                        }
                        else
                        {
                            moveWest = false;
                            moveNorth = true;
                            positionY--;
                            checker++;
                        }
                    }
                    if (line4Bit[positionX] == 1 && moveWest == true)
                    {
                        moveWest = false;
                        moveNorth = true;
                        positionY--;
                        positionX++;
                        checker++;
                    }
                    break;
                case 5:
                    while (line5Bit[positionX] == 0)
                    {
                        counter++;
                        if (positionX > 0)
                        {
                            positionX--;
                        }
                        else
                        {
                            moveWest = false;
                            moveNorth = true;
                            positionY--;
                            checker++;
                        }
                    }
                    if (line5Bit[positionX] == 1 && moveWest == true)
                    {
                        moveWest = false;
                        moveNorth = true;
                        positionY--;
                        positionX++;
                        checker++;
                    }
                    break;
                case 6:
                    while (line6Bit[positionX] == 0)
                    {
                        counter++;
                        if (positionX > 0)
                        {
                            positionX--;
                        }
                        else
                        {
                            moveWest = false;
                            moveNorth = true;
                            positionY--;
                            checker++;
                        }
                    }
                    if (line6Bit[positionX] == 1 && moveWest == true)
                    {
                        moveWest = false;
                        moveNorth = true;
                        positionY--;
                        positionX++;
                        checker++;
                    }
                    break;
                case 7:
                    while (line7Bit[positionX] == 0)
                    {
                        counter++;
                        if (positionX > 0)
                        {
                            positionX--;
                        }
                        else
                        {
                            moveWest = false;
                            moveNorth = true;
                            positionY--;
                            checker++;
                        }
                    }
                    if (line7Bit[positionX] == 1 && moveWest == true)
                    {
                        moveWest = false;
                        moveNorth = true;
                        positionY--;
                        positionX++;
                        checker++;
                    }
                    break;
                case 8:
                    while (line8Bit[positionX] == 0)
                    {
                        counter++;
                        if (positionX > 0)
                        {
                            positionX--;
                        }
                        else
                        {
                            moveWest = false;
                            moveNorth = true;
                            positionY--;
                            checker++;
                        }
                    }
                    if (line8Bit[positionX] == 1 && moveWest == true)
                    {
                        moveWest = false;
                        moveNorth = true;
                        positionY--;
                        positionX++;
                        checker++;
                    }
                    break;
                default:
                    break;
            }
        }

        while (moveNorth == true)
        {
            switch (positionY)
            {
                case 1:
                    if (line1Bit[positionX] == 0)
                    {
                        counter++;
                        checker++;
                        positionX--;
                        moveNorth = false;
                        moveWest = true;
                    }
                    else
                    {
                        if (checker == 1)
                        {
                            lastTrack = false;
                        }
                        else
                        {
                            checker++;
                            moveNorth = false;
                            moveWest = true;
                            positionY++;
                            if (positionX > 0)
                            {
                                positionX--;
                            }
                            else
                            {
                                lastTrack = false;
                            }
                        }
                    }
                    break;
                case 2:
                    if (line2Bit[positionX] == 0)
                    {
                        counter++;
                        positionY--;
                    }
                    else
                    {
                        if (checker == 1)
                        {
                            lastTrack = false;
                        }
                        else
                        {
                            checker++;
                            moveNorth = false;
                            moveWest = true;
                            positionY++;
                            if (positionX > 0)
                            {
                                positionX--;
                            }
                            else
                            {
                                lastTrack = false;
                            }
                        }
                    }
                    break;
                case 3:
                    if (line3Bit[positionX] == 0)
                    {
                        counter++;
                        positionY--;
                    }
                    else
                    {
                        if (checker == 1)
                        {
                            lastTrack = false;
                        }
                        else
                        {
                            checker++;
                            moveNorth = false;
                            moveWest = true;
                            positionY--;
                            if (positionX > 0)
                            {
                                positionX--;
                            }
                            else
                            {
                                lastTrack = false;
                            }
                        }
                    }
                    break;
                case 4:
                    if (line4Bit[positionX] == 0)
                    {
                        counter++;
                        positionY++;
                    }
                    else
                    {
                        if (checker == 1)
                        {
                            lastTrack = false;
                        }
                        else
                        {
                            checker++;
                            moveNorth = false;
                            moveWest = true;
                            positionY--;
                            if (positionX > 0)
                            {
                                positionX--;
                            }
                            else
                            {
                                lastTrack = false;
                            }
                        }
                    }
                    break;
                case 5:
                    if (line5Bit[positionX] == 0)
                    {
                        counter++;
                        positionY++;
                    }
                    else
                    {
                        if (checker == 1)
                        {
                            lastTrack = false;
                        }
                        else
                        {
                            checker++;
                            moveNorth = false;
                            moveWest = true;
                            positionY--;
                            if (positionX > 0)
                            {
                                positionX--;
                            }
                            else
                            {
                                lastTrack = false;
                            }
                        }
                    }
                    break;
                case 6:
                    if (line6Bit[positionX] == 0)
                    {
                        counter++;
                        positionY++;
                    }
                    else
                    {
                        if (checker == 1)
                        {
                            lastTrack = false;
                        }
                        else
                        {
                            checker++;
                            moveNorth = false;
                            moveWest = true;
                            positionY--;
                            if (positionX > 0)
                            {
                                positionX--;
                            }
                            else
                            {
                                lastTrack = false;
                            }
                        }
                    }
                    break;
                case 7:
                    if (line7Bit[positionX] == 0)
                    {
                        counter++;
                        positionY++;
                    }
                    else
                    {
                        if (checker == 1)
                        {
                            lastTrack = false;
                        }
                        else
                        {
                            checker++;
                            moveNorth = false;
                            moveWest = true;
                            positionY--;
                            if (positionX > 0)
                            {
                                positionX--;
                            }
                            else
                            {
                                lastTrack = false;
                            }
                        }
                    }
                    break;
                case 8:
                    if (line8Bit[positionX] == 0)
                    {
                        counter++;
                        if (positionX > 0)
                        {
                            positionX--;
                        }
                        else
                        {
                            lastTrack = false;
                        }
                        moveNorth = false;
                        moveWest = true;
                    }
                    else
                    {
                        if (checker == 1)
                        {
                            lastTrack = false;
                        }
                        else
                        {
                            checker++;
                            moveNorth = false;
                            moveWest = true;
                            positionY++;
                            positionX--;
                        }
                    }
                    break;
                default:
                    break;
            }
        }


        while (moveWest == true)
        {
            switch (positionY)
            {
                case 1:
                    while (line1Bit[positionX] == 0)
                    {
                        counter++;
                        if (positionX > 0)
                        {
                            positionX--;
                        }
                        else
                        {
                            moveWest = false;
                            moveSouth = true;
                            positionY--;
                            checker++;
                        }
                    }
                    if (line1Bit[positionX] == 1 && moveWest == true)
                    {
                        moveWest = false;
                        moveSouth = true;
                        positionY--;
                        positionX++;
                        checker++;
                    }
                    break;
                case 2:
                    while (line2Bit[positionX] == 0)
                    {
                        counter++;
                        if (positionX > 0)
                        {
                            positionX--;
                        }
                        else
                        {
                            moveWest = false;
                            moveSouth = true;
                            positionY--;
                            checker++;
                        }
                    }
                    if (line2Bit[positionX] == 1 && moveWest == true)
                    {
                        moveWest = false;
                        moveSouth = true;
                        positionY--;
                        positionX++;
                        checker++;
                    }
                    break;
                case 3:
                    while (line3Bit[positionX] == 0)
                    {
                        counter++;
                        if (positionX > 0)
                        {
                            positionX--;
                        }
                        else
                        {
                            moveWest = false;
                            moveSouth = true;
                            positionY--;
                            checker++;
                        }
                    }
                    if (line3Bit[positionX] == 1 && moveWest == true)
                    {
                        moveWest = false;
                        moveSouth = true;
                        positionY--;
                        positionX++;
                        checker++;
                    }
                    break;
                case 4:
                    while (line4Bit[positionX] == 0)
                    {
                        counter++;
                        if (positionX > 0)
                        {
                            positionX--;
                        }
                        else
                        {
                            moveWest = false;
                            moveSouth = true;
                            positionY--;
                            checker++;
                        }
                    }
                    if (line4Bit[positionX] == 1 && moveWest == true)
                    {
                        moveWest = false;
                        moveSouth = true;
                        positionY--;
                        positionX++;
                        checker++;
                    }
                    break;
                case 5:
                    while (line5Bit[positionX] == 0)
                    {
                        counter++;
                        if (positionX > 0)
                        {
                            positionX--;
                        }
                        else
                        {
                            moveWest = false;
                            moveSouth = true;
                            positionY--;
                            checker++;
                        }
                    }
                    if (line5Bit[positionX] == 1 && moveWest == true)
                    {
                        moveWest = false;
                        moveSouth = true;
                        positionY--;
                        positionX++;
                        checker++;
                    }
                    break;
                case 6:
                    while (line6Bit[positionX] == 0)
                    {
                        counter++;
                        if (positionX > 0)
                        {
                            positionX--;
                        }
                        else
                        {
                            moveWest = false;
                            moveSouth = true;
                            positionY--;
                            checker++;
                        }
                    }
                    if (line6Bit[positionX] == 1 && moveWest == true)
                    {
                        moveWest = false;
                        moveSouth = true;
                        positionY--;
                        positionX++;
                        checker++;
                    }
                    break;
                case 7:
                    while (line7Bit[positionX] == 0)
                    {
                        counter++;
                        if (positionX > 0)
                        {
                            positionX--;
                        }
                        else
                        {
                            moveWest = false;
                            moveSouth = true;
                            positionY--;
                            checker++;
                        }
                    }
                    if (line7Bit[positionX] == 1 && moveWest == true)
                    {
                        moveWest = false;
                        moveSouth = true;
                        positionY--;
                        positionX++;
                        checker++;
                    }
                    break;
                case 8:
                    while (line8Bit[positionX] == 0)
                    {
                        counter++;
                        if (positionX > 0)
                        {
                            positionX--;
                        }
                        else
                        {
                            moveWest = false;
                            moveSouth = true;
                            positionY--;
                            checker++;
                        }
                    }
                    if (line8Bit[positionX] == 1 && moveWest == true)
                    {
                        moveWest = false;
                        moveSouth = true;
                        positionY--;
                        positionX++;
                        checker++;
                    }
                    break;
                default:
                    break;
            }
        }


        Console.WriteLine(counter);
        Console.WriteLine("X = {0}, Y = {1}", positionX + 1, positionY);
    }

    static int[] GetIntBinaryString(int n)
    {
        int[] b = new int[8];
        int pos = 7;
        int i = 0;

        while (i < 8)
        {
            if ((n & (1 << i)) != 0)
            {
                b[pos] = 1;
            }
            else
            {
                b[pos] = 0;
            }
            pos--;
            i++;
        }
        return b;
    }

}