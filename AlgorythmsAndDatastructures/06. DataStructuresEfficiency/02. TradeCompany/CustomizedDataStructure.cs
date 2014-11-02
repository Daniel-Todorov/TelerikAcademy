//The logic is simple - we create a sorted multidictionary which allows us to search quickly for keys.
//We make the price as key for the dictionary because we'll search by it.
//Then we just use the built in function to get range by min and max key (price).

using System.Collections.Generic;

using Wintellect.PowerCollections;

public class CustomizedDataStructure
{
    private OrderedMultiDictionary<decimal, Article> data;

    public CustomizedDataStructure()
    {
        this.data = new OrderedMultiDictionary<decimal, Article>(true);
    }

    public void Add(Article article)
    {
        var key = article.Price;

        this.data.Add(key, article);
    }

    public List<Article> GetArticlesInPriceRange(decimal lowerLimit, decimal upperLimit)
    {
        List<Article> result = new List<Article>();

        var articlesInRange = this.data.Range(lowerLimit, true, upperLimit, true);

        foreach (var article in articlesInRange.KeyValuePairs)
        {
            result.Add(article.Value);
        }

        return result;
    }
}
