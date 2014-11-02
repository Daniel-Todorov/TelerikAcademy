//Write a program that finds all prime numbers 
//in the range [1...10 000 000]. Use the sieve of 
//Eratosthenes algorithm (find it in Wikipedia).


                                       //WARNING!!!
                         //This program takes a lot of time to execute!!!
                      //The console has problems printing all the results!!!

using System;
using System.Collections.Generic;

class FindAllPrimeNumbers
{
    static void Main()
    {
        List<int> numbersN = new List<int>();

        //Populate the list with numbers from 1 to 10 000 000.
        numbersN.Add(2);
        for (int a = 1; a < 9999999; a++)
        {
            numbersN.Add(numbersN[a - 1] + 1);
        }

        //Run though the list of numbers and make those with more than two divisors to have the value of 1.
        for (int a = 0; a < 9999999; a++)
        {
            if (numbersN[a] > 3162) //3162 is close to the square of 10 000 000
            {
                break;
            }
            if (numbersN[a] > 1)
            {
                for (int b = a + 1; b < 9999999; b++)
                {
                    if (numbersN[b] > 1 && numbersN[b] % numbersN[a] == 0)
                    {
                        numbersN[b] = 1;
                    }
                }
            }
        }

        //Print all the numbers in the list which have value more than 1.
        Console.Write("The prime numbers from 1 to 10 000 000 are: ");
        foreach (var item in numbersN)
        {
            if (item > 1)
            {
                Console.Write("{0}, ", item);
            }
        }
    }
}