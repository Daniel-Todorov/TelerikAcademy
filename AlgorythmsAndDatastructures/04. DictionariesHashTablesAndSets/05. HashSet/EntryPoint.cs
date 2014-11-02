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

    public class EntryPoint
    {
        static void Main()
        {
            HashedSet<string> myBestFriends = new HashedSet<string>();

            myBestFriends.Add("Ivan");
            myBestFriends.Add("Daniel");
            myBestFriends.Add("Cecilia");

            Console.WriteLine(myBestFriends.Count);

            myBestFriends.Remove("Cecilia");
            Console.WriteLine(myBestFriends.Count);

            HashedSet<string> yourBestFriends = new HashedSet<string>();

            yourBestFriends.Add("Petar");
            yourBestFriends.Add("Daniel");
            yourBestFriends.Add("Monika");

            HashedSet<string> allBestFriends = myBestFriends.Union(yourBestFriends);

            Console.WriteLine("All best friends: ");
            foreach (var item in allBestFriends.setOfData)
            {
                Console.WriteLine("{0}", item.Value);
            }

            HashedSet<string> mutualBestFriends = myBestFriends.Intersect(yourBestFriends);

            Console.WriteLine("Mutual best friends: ");
            foreach (var item in mutualBestFriends.setOfData)
            {
                Console.WriteLine("{0}", item.Value);
            }
        }
    }
}
