using System;

class Neurons
{
    static void Main()
    {
        int[] array = new int[32];
        bool endOfSequence = false;
        int counter = 0;

        int mask = 0;
        int numberToCheck = 0;

        int startPosition = 0;
        int endPosition = 0;

        int a = 0;
        int b = 0;

        while (endOfSequence == false)
        {
            array[counter] = int.Parse(Console.ReadLine());
            if (array[counter] == -1)
            {
                endOfSequence = true;
            }

            counter++;
        }

            for (; a == 0; a++)
            {
                //find the starting ONE
                for (; b < 32; b++)
                {
                    numberToCheck = array[0];
                    mask = 1;
                    mask = mask << b;

                    numberToCheck = numberToCheck & mask;

                    if (numberToCheck > 0)
                    {
                        startPosition = b;
                        break;
                    }
                }
                //------------------------------------

                //find the ending ONE
                for (b = b + 1; b < 32; b++)
                {
                    numberToCheck = array[0];
                    mask = 1;
                    mask = mask << b;

                    numberToCheck = numberToCheck & mask;

                    if (numberToCheck > 0)
                    {
                        endPosition = b;
                        break;
                    }
                }
                //-----------------------------------------

                if (endPosition > startPosition + 1)
                {
                    numberToCheck = 0;
                    for (int c = startPosition + 1; c < endPosition; c++)
                    {
                        mask = 1;
                        mask = mask << c;
                        numberToCheck = numberToCheck | mask;
                    }

                    array[0] = numberToCheck;
                    break;
                }
                else
                {
                    array[0] = 0;
                }

                b = 0;
            }

            for (; a == 1; a++)
            {
                //find the starting ONE
                for (; b < 32; b++)
                {
                    numberToCheck = array[1];
                    mask = 1;
                    mask = mask << b;

                    numberToCheck = numberToCheck & mask;

                    if (numberToCheck > 0)
                    {
                        startPosition = b;
                        break;
                    }
                }
                //------------------------------------

                //find the ending ONE
                for (b = b + 1; b < 32; b++)
                {
                    numberToCheck = array[1];
                    mask = 1;
                    mask = mask << b;

                    numberToCheck = numberToCheck & mask;

                    if (numberToCheck > 0)
                    {
                        endPosition = b;
                        break;
                    }
                }
                //-----------------------------------------

                if (endPosition > startPosition + 1)
                {
                    numberToCheck = 0;
                    for (int c = startPosition + 1; c < endPosition; c++)
                    {
                        mask = 1;
                        mask = mask << c;
                        numberToCheck = numberToCheck | mask;
                    }

                    array[1] = numberToCheck;
                    break;
                }
                else
                {
                    array[1] = 0;
                }

                b = 0;
            }

            for (; a == 2; a++)
            {
                //find the starting ONE
                for (; b < 32; b++)
                {
                    numberToCheck = array[2];
                    mask = 1;
                    mask = mask << b;

                    numberToCheck = numberToCheck & mask;

                    if (numberToCheck > 0)
                    {
                        startPosition = b;
                        break;
                    }
                }
                //------------------------------------

                //find the ending ONE
                for (b = b + 1; b < 32; b++)
                {
                    numberToCheck = array[2];
                    mask = 1;
                    mask = mask << b;

                    numberToCheck = numberToCheck & mask;

                    if (numberToCheck > 0)
                    {
                        endPosition = b;
                        break;
                    }
                }
                //-----------------------------------------

                if (endPosition > startPosition + 1)
                {
                    numberToCheck = 0;
                    for (int c = startPosition + 1; c < endPosition; c++)
                    {
                        mask = 1;
                        mask = mask << c;
                        numberToCheck = numberToCheck | mask;
                    }

                    array[2] = numberToCheck;
                    break;
                }
                else
                {
                    array[2] = 0;
                }

                b = 0;
            }

            foreach (var item in array)
            {
                if (item == -1)
                {
                    break;
                }
                else
                {
                    Console.WriteLine(item);
                }
                
            }

    }
}