//Problem 2 – Girls Gone Wild
//As you know girls like to exchange their clothes. 
//You are given N girls with K shirts and L skirts. 
//For easier understanding shirts are indexed with numbers (zero-based) and skirts are indexed with letters. 
//Numbers are always from 0 to K – 1. 
//Letters are any lower case English letter. 
//Some skirts are the same so letters are not distinct.
//Your task is to find in how many ways the girls can choose one shirt and one skirt for each one of them. 

namespace _02.GirlsGoneWild
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class GirlsGoneWild
    {
        private static SortedSet<string> finalResult = new SortedSet<string>();
        private static int[] usedShirt;
        private static int[] usedSkirt;

        static void Main()
        {
            //var numberOfShirtsK = int.Parse(Console.ReadLine());
            var numberOfShirtsK = 3;

            usedShirt = new int[numberOfShirtsK];

            //var skirts = Console.ReadLine();
            var skirtsL = "baca";
            var numberOfSkirtsL = skirtsL.Length;

            usedSkirt = new int[numberOfSkirtsL];

            //var numberOfGirls = int.Parse(Console.ReadLine());
            var numberOfGirls = 2;

            HashSet<string> possibleCombos = new HashSet<string>();

            for (int i = 0; i < numberOfShirtsK; i++)
            {
                for (int j = 0; j < numberOfSkirtsL; j++)
                {
                    possibleCombos.Add(i.ToString() + j.ToString());
                }
            }

            GenerateCombinations(0, 0, numberOfGirls, possibleCombos.ToArray(), new string[numberOfGirls]);
        }

        private static void GenerateCombinations(int index, int start, int k, string[] n, string[] result)
        {
            if (index >= k)
            {
                if (result.Count(element => element.Contains("#")) == 0)
                {
                    var wtf = string.Join(" ", result);
                    finalResult.Add(wtf);
                    //Console.WriteLine(string.Join(" ", result));
                }
            }
            else
            {
                for (int i = start; i < n.Length; i++)
                {
                    if (result[0] != null && (n[i][0] == result[0][0] || n[i][1] == result[0][1]))
                    {
                        result[index] = "##";
                        GenerateCombinations(index + 1, i + 1, k, n, result);
                        //return;
                    }
                    else
                    {
                        result[index] = n[i];
                        GenerateCombinations(index + 1, i + 1, k, n, result);
                    }

                }
            }
        }
    }
}
