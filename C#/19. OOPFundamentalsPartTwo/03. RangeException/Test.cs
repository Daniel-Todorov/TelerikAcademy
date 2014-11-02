//Define a class InvalidRangeException<T> that holds information about an error condition related to invalid range. 
//It should hold error message and a range definition [start … end].
//Write a sample application that demonstratesthe InvalidRangeException<int> and InvalidRangeException<DateTime> by entering 
//numbers in the range [1..100] and dates in the range [1.1.1980 … 31.12.2013].

using System;

namespace _03.RangeException
{
    class Test
    {
        static void Main()
        {
            int number = 99;
            try
            {
                if (number > 0 && number < 101)
                {
                    throw new InvalidRangeException<int>(1, 100);
                }
            }
            catch (InvalidRangeException<int> intEx)
            {
                Console.WriteLine(intEx);
            }

            DateTime date = DateTime.Now;
            try
            {
                if (date > new DateTime(1980,1,1) && date < new DateTime(2013, 12,31))
                {
                    throw new InvalidRangeException<DateTime>(new DateTime(1980, 1, 1), new DateTime(2013, 12, 31));
                }
            }
            catch (InvalidRangeException<DateTime> dateEx)
            {
                Console.WriteLine(dateEx.ToString());
            }
        }
    }
}
