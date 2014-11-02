//Implement a class BiDictionary<K1,K2,T> that 
//allows adding triples {key1, key2, value} and fast 
//search by key1, key2 or by both key1 and key2. 
//Note: multiple values can be stored for given key.

using System;

public class Testing
{
    public static void Main()
    {
        BiDictionary<string, int, string> biDictionary = new BiDictionary<string, int, string>();

        biDictionary.Add("first", 1, "Superman");
        biDictionary.Add("second", 2, "Batman");
        biDictionary.Add("third", 1, "Cat woman");
        biDictionary.Add("first", 3, "Joker");
        biDictionary.Add("second", 2, "Boyko Borisov");
        biDictionary.Add("first", 1, "Hawk woman");

        Console.WriteLine("Get records by key1 = 'first':");
        var allFirst = biDictionary.Get("first");

        foreach (var superhero in allFirst)
        {
            Console.WriteLine(superhero);
        }
        Console.WriteLine();

        Console.WriteLine("Get records by key2 = 1:");
        var allOne = biDictionary.Get(1);

        foreach (var superhero in allOne)
        {
            Console.WriteLine(superhero);
        }
        Console.WriteLine();

        Console.WriteLine("Get records bykey1 = 'first' and key2 = 1:");
        var allFirstOne = biDictionary.Get("first", 1);

        foreach (var superhero in allFirstOne)
        {
            Console.WriteLine(superhero);
        }
        Console.WriteLine();
    }
}
