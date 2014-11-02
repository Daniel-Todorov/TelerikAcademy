//You are given a list of numbers containing a permutation of the integers between 1 and N, inclusive.
//You are allowed to make only one operation at a time with the numbers: 
//Take any K consecutive elements of the list and reverse their order.
//You need to sort the list in ascending order.
//Return the fewest number of operations necessary to sort the numbers in ascending order, or -1 if it's impossible.

namespace _05.SortingDescription
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class SortingDescription
    {
        static void Main()
        {
            //var stepsAllowed = int.Parse(Console.ReadLine());
            var stepsAllowed = 5;

            //var arrayOfDigits = Console.ReadLine().Split(' ').Select(number => int.Parse(number));
            //var arrayOfDigits = new int[]{5, 4, 3, 2, 1};

            int[] number = { 5, 4, 3, 2, 1 };
            bool flag = true;
            int temp;
            int numLength = number.Length;
            //sorting an array
            for (int i = 1; (i <= (numLength - 1)) && flag; i++)
            {
                flag = false;
                for (int j = 0; j < (numLength - 1); j++)
                {
                    if (number[j + 1] > number[j])
                    {
                        temp = number[j];
                        number[j] = number[j + 1];
                        number[j + 1] = temp;
                        flag = true;
                    }
                }
            }
            //Sorted array
            foreach (int num in number)
            {
                Console.Write("\t {0}", num);
            }
            Console.Read();
        }
    }
}
