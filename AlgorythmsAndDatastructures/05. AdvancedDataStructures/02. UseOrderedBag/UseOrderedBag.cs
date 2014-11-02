//Write a program to read a large collection of 
//products (name + price) and efficiently find the first 
//20 products in the price range [a…b]. Test for 500 000 
//products and 10 000 price searches.
//Hint: you may use OrderedBag<T> and sub-ranges.

//NOTE!!! The number of results is huge and it's a hell to try printing them at the console.
//Please, use the debugger to check the values of the variables instead.

using System.Collections.Generic;

using Wintellect.PowerCollections;

public class UseOrderedBag
{
    public static void Main()
    {
        OrderedBag<Product> test = new OrderedBag<Product>();
        string originalName = "Product";
        decimal originalPrice = 1;
        Product productToAdd;

        for (int i = 0; i < 500000; i++)
        {
            productToAdd = new Product(originalName + i, originalPrice + i);
            test.Add(productToAdd);
        }

        int numberOfRangeChecks = 0;
        List<Product> topTwentyProductsInRange = new List<Product>();

        for (int i = 0, j = 10000; i < 10000; i++, j += 10)
        {
            var productsInRange = test.Range(new Product("", i), true, new Product("", j), true);

            for (int k = 0; k < 20; k++)
			{
                topTwentyProductsInRange.Add(productsInRange[k]);
			}

            numberOfRangeChecks++;
        }
    }
}
