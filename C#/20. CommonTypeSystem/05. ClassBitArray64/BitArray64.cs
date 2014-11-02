//Define a class BitArray64 to hold 64 bit values inside an ulong value. 
//Implement IEnumerable<int> and Equals(...), GetHashCode(), [], == and !=.


using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.ClassBitArray64
{
    class BitArray64 : IEnumerable<int>
    {
        //Fields
        private ulong number;

        //Properties
        public ulong Number
        {
            get { return this.number; }
            set { this.number = value; }
        }

        //Constructors
        public BitArray64(ulong number)
        {
            this.number = number;
        }

        //IEnumerable
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public IEnumerator<int> GetEnumerator()
        {
            int[] bits = this.ConvertToBits();

            for (int i = 0; i < bits.Length; i++)
            {
                yield return bits[i];
            }
        }

        private int[] ConvertToBits()
        {
            ulong number = this.number;
            int[] bits = new int[64];

            for (int i = 63; i >= 0; i--)
            {
                bits[i] = (int) number % 2;
                number = number / 2;
            }

            return bits;
        }

        //Indexer
        public int this[int index]
        {
            get
            {
                if (index > 63 || index < 0)
                {
                    throw new System.IndexOutOfRangeException();
                }

                int[] bits = this.ConvertToBits();
                return bits[index];
            }
        }

        public override int GetHashCode()
        {
            return this.number.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            BitArray64 newBitArray = obj as BitArray64;

            if (newBitArray == null)
            {
                return false;
            }
            if (this.number == newBitArray.number)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator ==(BitArray64 first, BitArray64 second)
        {
            return BitArray64.Equals(first, second);
        }
        
        public static bool operator !=(BitArray64 first, BitArray64 second)
        {
            return !BitArray64.Equals(first, second);
        }
    }
}
