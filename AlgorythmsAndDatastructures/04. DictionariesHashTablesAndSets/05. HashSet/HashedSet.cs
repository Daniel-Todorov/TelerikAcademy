//Implement the data structure "set" in a class 
//HashedSet<T> using your class HashTable<K,T> to 
//hold the elements. Implement all standard set 
//operations like Add(T), Find(T), Remove(T), Count, 
//Clear(), union and intersect.

namespace _05.HashSet
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using _04.HashTable;


    public class HashedSet<T>
    {
        public HashTable<T, T> setOfData { get; set; }

        public HashedSet()
        {
            this.setOfData = new HashTable<T, T>();
            this.Count = 0;
        }

        public int Count { get; set; }

        public HashedSet<T> Intersect(HashedSet<T> anotherSet)
        {
            var newSet = new HashedSet<T>();

            foreach (var otherSetItem in anotherSet.setOfData)
            {
                if (this.Find(otherSetItem.Value))
                {
                    newSet.Add(otherSetItem.Value);
                }
            }

            return newSet;
        }

        public HashedSet<T> Union(HashedSet<T> anotherSet)
        {
            var newSet = new HashedSet<T>();

            foreach (var item in this.setOfData)
            {
                newSet.Add(item.Value);
            }

            foreach (var otherSetItem in anotherSet.setOfData)
            {
                if (!newSet.Find(otherSetItem.Value))
                {
                    newSet.Add(otherSetItem.Value);
                }
            }

            return newSet;
        }

        public void Clear()
        {
            this.setOfData = new HashTable<T, T>();
        }

        public void Add(T value)
        {
            if (!this.Find(value))
            {
                this.setOfData.Add(value, value);
                this.Count++;
            }
        }

        public void Remove(T value)
        {
            this.setOfData.Remove(value);
            this.Count--;
        }

        //I presume they mean that Find(T) returns a boolean result because a set does not keep key - value, pairs, just values.
        public bool Find(T value)
        {
            try
            {
                if (this.setOfData.Find(value) != null)
                {
                    return true;
                }
            }
            catch (Exception)
            {

                return false;
            }


            return false;
        }
    }
}
