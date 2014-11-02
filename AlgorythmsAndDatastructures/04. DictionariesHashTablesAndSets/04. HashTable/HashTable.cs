//HashTable<K,T>. Keep the data in array of lists of key -
//value pairs (LinkedList<KeyValuePair<K,T>>[]) with 
//initial capacity of 16. When the hash table load runs 
//over 75%, perform resizing to 2 times larger capacity. 
//Implement the following methods and properties: 
//Add(key, value), Find(key)value, Remove( 
//key), Count, Clear(), this[], Keys. Try to make 
//the hash table to support iterating over its elements 
//with foreach.

namespace _04.HashTable
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public class HashTable<K, T> : IEnumerable<KeyValuePair<K, T>>
    {
        public const int InitialCapacity = 16;

        public HashTable()
        {
            this.Values = new LinkedList<KeyValuePair<K, T>>[InitialCapacity];
            this.Count = 0;
        }

        public int Capacity
        {
            get
            {
                return this.Values.Length;
            }
        }

        public int Count
        {
            get;
            private set;
        }

        public T this[K key]
        {
            get
            {
                return this.Find(key);
            }
            set
            {
                this.Add(key, value);
            }
        }

        public void Clear()
        {
            this.Values = new LinkedList<KeyValuePair<K, T>>[InitialCapacity];
            Count = 0;
        }

        public LinkedList<KeyValuePair<K, T>>[] Values { get; set; }

        public T Find(K key)
        {
            var keyHash = GetHashCode(key);

            if (this.Values[keyHash] != null)
            {
                foreach (var pair in this.Values[keyHash])
                {
                    if (pair.Key.Equals(key))
                    {
                        return pair.Value;
                    }
                }
            }
            else
            {
                throw new InvalidOperationException("The key does not exist.");
            }

            return default(T);
        }

        public void Remove(K key)
        {
            var keyHash = GetHashCode(key);
            var pairToRemove = new KeyValuePair<K, T>();

            if (this.Values[keyHash] != null)
            {
                foreach (var pair in this.Values[keyHash])
                {
                    if (pair.Key.Equals(key))
                    {
                        pairToRemove = pair;
                    }
                }

                this.Values[keyHash].Remove(pairToRemove);
                this.Count--;
            }

            
        }

        public void Add(K key, T value)
        {
            int hash = GetHashCode(key);

            if (this.Values[hash] == null)
            {
                this.Values[hash] = new LinkedList<KeyValuePair<K, T>>();
            }

            bool keyAlreadyExists= this.Values[hash].Any(pairs => pairs.Key.Equals(value));

            if (keyAlreadyExists)
            {
                throw new ArgumentException("Key already exists");
            }

            KeyValuePair<K, T> pair = new KeyValuePair<K, T>(key, value);
            this.Values[hash].AddLast(pair);
            this.Count++;

            if (this.Count >= this.Capacity * 0.75)
            {
                this.Resize();
            }
        }

        private int GetHashCode(K key)
        {
            int hash = key.GetHashCode();
            hash = hash % this.Capacity;
            hash = Math.Abs(hash);

            return hash;
        }

        private void Resize()
        {
            var copyOfValues = this.Values;
            this.Values = new LinkedList<KeyValuePair<K, T>>[this.Capacity * 2];
            this.Count = 0;

            foreach (var element in copyOfValues)
            {
                if (element != null)
                {
                    foreach (var pair in element)
                    {
                        this.Add(pair.Key, pair.Value);
                    }
                }
            }
        }

        public IEnumerator<KeyValuePair<K, T>> GetEnumerator()
        {
            foreach (var element in this.Values)
            {
                if (element != null)
                {
                    foreach (var pair in element)
                    {
                        yield return pair;
                    }
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
