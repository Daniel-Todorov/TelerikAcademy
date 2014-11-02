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

        string line1Bit = GetIntBinaryString(line1);
        string line2Bit = GetIntBinaryString(line2);
        string line3Bit = GetIntBinaryString(line3);
        string line4Bit = GetIntBinaryString(line4);
        string line5Bit = GetIntBinaryString(line5);
        string line6Bit = GetIntBinaryString(line6);
        string line7Bit = GetIntBinaryString(line7);
        string line8Bit = GetIntBinaryString(line8);


        bool moveSouth = true;
        bool moveWest = false;
        bool moveNorth = false;
        bool lastingTrack = true;
        int checker = 0;
        int positionX = 7;
        int positionY = 0;
        int counter = 0;

        while (moveSouth == true)
        {
            switch (positionY)
            {
                case 0:
                    if (line1Bit[positionX] == '0')
                    {
                        counter++;
                        positionY++;
                        checker = 0;
                    }
                    else
                    {
                        if (checker < 1)
                        {
                            checker++;
                            positionY--;
                            positionX--;
                            moveSouth = false;
                            moveWest = true;
                        }
                        else
                        {
                            lastingTrack = false;
                        }
                    }
                    break;

                case 1:
                    if (line2Bit[positionX] == '0')
                    {
                        counter++;
                        positionY++;
                        checker = 0;
                    }
                    else
                    {
                        if (checker < 1)
                        {
                            checker++;
                            positionY--;
                            positionX--;
                            moveSouth = false;
                            moveWest = true;
                        }
                        else
                        {
                            lastingTrack = false;
                        }
                    }
                    break;
                case 2:
                    if (line3Bit[positionX] == '0')
                    {
                        counter++;
                        positionY++;
                        checker = 0;
                    }
                    else
                    {
                        if (checker < 1)
                        {
                            checker++;
                            positionY--;
                            positionX--;
                            moveSouth = false;
                            moveWest = true;
                        }
                        else
                        {
                            lastingTrack = false;
                        }
                    }
                    break;
                case 3:
                    if (line4Bit[positionX] == '0')
                    {
                        counter++;
                        positionY++;
                        checker = 0;
                    }
                    else
                    {
                        if (checker < 1)
                        {
                            checker++;
                            positionY--;
                            positionX--;
                            moveSouth = false;
                            moveWest = true;
                        }
                        else
                        {
                            lastingTrack = false;
                        }
                    }
                    break;
                case 4:
                    if (line5Bit[positionX] == '0')
                    {
                        counter++;
                        positionY++;
                        checker = 0;
                    }
                    else
                    {
                        if (checker < 1)
                        {
                            checker++;
                            positionY--;
                            positionX--;
                            moveSouth = false;
                            moveWest = true;
                        }
                        else
                        {
                            lastingTrack = false;
                        }
                    }
                    break;
                case 5:
                    if (line6Bit[positionX] == '0')
                    {
                        counter++;
                        positionY++;
                        checker = 0;
                    }
                    else
                    {
                        if (checker < 1)
                        {
                            checker++;
                            positionY--;
                            positionX--;
                            moveSouth = false;
                            moveWest = true;
                        }
                        else
                        {
                            lastingTrack = false;
                        }
                    }
                    break;
                case 6:
                    if (line7Bit[positionX] == '0')
                    {
                        counter++;
                        positionY++;
                        checker = 0;
                    }
                    else
                    {
                        if (checker < 1)
                        {
                            checker++;
                            positionY--;
                            positionX--;
                            moveSouth = false;
                            moveWest = true;
                        }
                        else
                        {
                            lastingTrack = false;
                        }
                    }
                    break;
                case 7:
                    if (line8Bit[positionX] == '0')
                    {
                        counter++;
                        if (positionX > 0)
                        {
                            positionX--;
                            moveSouth = false;
                            moveWest = true;
                        }
                        else
                        {
                            positionY--;
                            moveSouth = false;
                            moveWest = true;
                        }

                        checker = 0;
                    }
                    else
                    {
                        if (checker < 1)
                        {
                            checker++;
                            positionY--;
                            positionX--;
                        }
                        else
                        {
                            lastingTrack = false;
                        }
                    }
                    break;
                default:
                    break;
            }
        }
        Console.WriteLine(counter);
    }

    static string GetIntBinaryString(int n)
    {
        char[] b = new char[8];
        int pos = 7;
        int i = 0;

        while (i < 8)
        {
            if ((n & (1 << i)) != 0)
            {
                b[pos] = '1';
            }
            else
            {
                b[pos] = '0';
            }
            pos--;
            i++;
        }
        return new string(b);
    }
}
