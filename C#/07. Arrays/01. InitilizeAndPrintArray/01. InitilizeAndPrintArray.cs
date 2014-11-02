//Write a program that allocates array of 20 integers 
//and initializes each element by its index multiplied 
//by 5. Print the obtained array on the console.

using System;

class InitilizeAndPrintArray
{
    static void Main()
    {
        int[] myFirstArray = new int[20];

        //Initilize array
        for (int a = 0; a < myFirstArray.Length; a++)
        {
            myFirstArray[a] = a * 5;
        }

        //Print array
        for (int b = 0; b < myFirstArray.Length; b++)
        {
            if (b < 19)
            {
                Console.Write("{0} ", myFirstArray[b]);
            }
            else
            {
                Console.Write("{0}", myFirstArray[b]);
            }
        }

        Console.WriteLine("");
    }
}
