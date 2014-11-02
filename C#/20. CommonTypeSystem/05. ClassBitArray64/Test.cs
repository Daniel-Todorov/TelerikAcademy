//Define a class BitArray64 to hold 64 bit values inside an ulong value. 
//Implement IEnumerable<int> and Equals(...), GetHashCode(), [], == and !=.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.ClassBitArray64
{
    class Test
    {
        static void Main()
        {
            BitArray64 testNumber = new BitArray64(8L);

            foreach (var item in testNumber)
            {
                Console.Write(item);
            }
            Console.WriteLine();
            Console.WriteLine(testNumber[60]);
            Console.WriteLine();
            Console.WriteLine(testNumber.Equals(new BitArray64(8L)));
            Console.WriteLine(testNumber.Equals(new BitArray64(6L)));

            if (testNumber == new BitArray64(8L))
            {
                Console.WriteLine("8 == 8");
            }
            if (testNumber != new BitArray64(33L))
            {
                Console.WriteLine("8 != 33");
            }
        }
    }
}
