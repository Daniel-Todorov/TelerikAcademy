//Implement the data structure "hash table" in a class 
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

    class EntryPoint
    {

        static void Main()
        {
            var hashTable = new HashTable<string, int>();

            hashTable.Add("Ivan", 1);
            hashTable.Add("Pesho", 2);
            hashTable.Add("Gosho", 3);
            Console.WriteLine(hashTable.Find("Gosho"));

            hashTable.Remove("Gosho");
            Console.WriteLine(hashTable.Count);

            hashTable.Clear();
            Console.WriteLine(hashTable.Count);

            hashTable["Ivan"] = 1;
            hashTable["Pesho"] = 2;
            hashTable["Gosho"] = 3;

            foreach (var pair in hashTable)
            {
                Console.WriteLine("{0} -> {1}", pair.Key, pair.Value);
            }
        }
    }
}
