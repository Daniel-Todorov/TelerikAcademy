//A large trade company has millions of articles, each 
//described by barcode, vendor, title and price. 
//Implement a data structure to store them that 
//allows fast retrieval of all articles in given price range 
//[x…y]. Hint: use OrderedMultiDictionary<K,T>
//from Wintellect's Power Collections for .NET. 

using System;

public class Testing
{
    public static void Main()
    {
        CustomizedDataStructure storage = new CustomizedDataStructure();

        storage.Add(new Article("380012343", "Daniel Todorov", "My life in Telerik Academy", 10.99M));
        storage.Add(new Article("380012344", "Daniel Todorov", "My homeworks in Telerik Academy", 35.99M));
        storage.Add(new Article("380012345", "Daniel Todorov", "My free time in Telerik Academy", 0.99M));
        storage.Add(new Article("380012346", "Daniel Todorov", "My friends in Telerik Academy", 9.99M));
        storage.Add(new Article("380012347", "Daniel Todorov", "My nightmares in Telerik Academy", 9.99M));
        storage.Add(new Article("380012348", "Daniel Todorov", "My favorite chair in Telerik Academy", 15.99M));
        storage.Add(new Article("380012349", "Daniel Todorov", "My favorite trainer in Telerik Academy", 12.99M));
        storage.Add(new Article("380012350", "Daniel Todorov", "My sexy jeans in Telerik Academy", 12.99M));
        storage.Add(new Article("380012351", "Daniel Todorov", "My wicked self in Telerik Academy", 14.99M));

        var articlesInRange = storage.GetArticlesInPriceRange(9M, 13M);

        Console.WriteLine("Articles with price between 9 and 13 inclusive:");
        Console.WriteLine();

        foreach (var article in articlesInRange)
        {
            Console.WriteLine("Title: {0}, Price: {1}", article.Title, article.Price);
        }
    }
}
