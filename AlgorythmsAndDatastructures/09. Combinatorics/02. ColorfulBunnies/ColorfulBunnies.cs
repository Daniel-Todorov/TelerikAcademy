//Задача 2 – Цветни зайци
//Автор: Николай Костов

//Котаракът Стиви посетил града на зайците и попитал няколко от тях следния въпрос: 
//„Ако не броиш себе си, колко зайци с еднакъв на твоя цвят, живеят в града?“. 
//Всеки от попитаните зайци казал истината като бил попитан само веднъж от котарака. 
//Помогнете на Стиви да разбере най-малко колко зайци живеят в града.

//Test at bgcoder => http://bgcoder.com/Contests/Practice/Index/132#1;

namespace _02.ColorfulBunnies
{
    using System;
    using System.Collections.Generic;

    class ColorfulBunnies
    {
        static void Main()
        {
            int numberOfBunniesAsked = int.Parse(Console.ReadLine());
            Dictionary<long, long> dictionary = new Dictionary<long, long>();

            for (int i = 0; i < numberOfBunniesAsked; i++)
            {
                long numberOfBunniesWithSameColor = long.Parse(Console.ReadLine());

                if (dictionary.ContainsKey(numberOfBunniesWithSameColor))
                {
                    dictionary[numberOfBunniesWithSameColor]++;
                }
                else
                {
                    dictionary[numberOfBunniesWithSameColor] = 1;
                }
            }

            long minimalNumberOfbunnies = 0;
            foreach (var pair in dictionary)
            {
                if (pair.Value <= pair.Key + 1)
                {
                    minimalNumberOfbunnies += (pair.Key + 1);
                }
                else
                {
                    long minimalNumberOfDuplicates = pair.Value / (pair.Key + 1);
                    long aditionalColors = pair.Value % (pair.Key + 1);

                    minimalNumberOfbunnies += (minimalNumberOfDuplicates * (pair.Key + 1));

                    if (aditionalColors > 0)
                    {
                        minimalNumberOfbunnies += (pair.Key + 1);
                    }
                }
            }

            Console.WriteLine(minimalNumberOfbunnies);
        }
    }
}
