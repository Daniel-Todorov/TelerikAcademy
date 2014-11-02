//As you know in our Academy we give you some problems to solve. 
//You must first solve problem 0. 
//After solving each problem i, you must either move on to problem i+1 or skip ahead to problem i+2. 
//You are not allowed to skip more than one problem. 
//For example, {0, 2, 3, 5} is a valid order, but {0, 2, 4, 7} is not because the skip from 4 to 7 is too long.
//You are given an array pleasantness (0-based), where pleasantness[i] indicates how much you like problem i. 
//We will let you stop solving problems once the range of pleasantness you've encountered reaches a certain threshold. 
//Specifically, you may stop once the difference between the maximum and minimum pleasantness of the problems 
//you've solved is greater than or equal to the integer variety. 
//If this never happens, you must solve all the problems. 
//Return the minimum number of problems you must solve to satisfy our requirements.

namespace AcademyTasks
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class AcademyTasks
    {
        private static int minCount = int.MaxValue;

        static void Main()
        {
            var rawPleasantness = Console.ReadLine();
            //var rawPleasantness = "94, 41, 231, 245, 229, 169, 84, 336, 109, 342, 99, 94, 90, 174, 162, 322, 214, 251, 126, 145, 86, 89, 80, 219, 179, 95, 162, 221, 11, 353, 172, 384, 53, 193, 408, 389, 106, 108, 30, 61";
            var pleasantness = rawPleasantness.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).Select(item => int.Parse(item)).ToArray();

            var variety = int.Parse(Console.ReadLine());
            //var variety = 305;

            if (pleasantness.Max() - pleasantness.Min() < variety)
            {
                Console.WriteLine(pleasantness.Length);
                return;
            }

            var problems = new List<Problem>();
            int numberOfProblems = pleasantness.Length;
            for (int i = 0; i < numberOfProblems; i++)
            {
                problems.Add(new Problem(pleasantness[i]));
            }

            for (int i = 0; i < numberOfProblems - 2; i++)
            {
                problems[i].Children.Add(problems[i + 1]);
                problems[i].Children.Add(problems[i + 2]);
            }

            if (numberOfProblems >= 2)
            {
                problems[numberOfProblems - 2].Children.Add(problems[numberOfProblems - 1]);
            }

            DFS(problems[0], 0, int.MaxValue, int.MinValue, variety);

            Console.WriteLine(minCount);
        }

        private static void DFS(Problem node, int count, int minP, int maxP, int variety)
        {
            count++;

            if (minP > node.Pleasantness)
            {
                minP = node.Pleasantness;
            }

            if (maxP < node.Pleasantness)
            {
                maxP = node.Pleasantness;
            }

            if (maxP - minP >= variety)
            {
                if (minCount > count)
                {
                    minCount = count;
                }
            }

            if (minCount < count)
            {
                count--;
                return;
            }

            foreach (var item in node.Children)
            {
                DFS(item, count, minP, maxP, variety);
            }

            count--;
        }

    }

    class Problem
    {
        public Problem(int pleasantness)
        {
            this.Children = new List<Problem>();
            this.Pleasantness = pleasantness;
        }

        public List<Problem> Children { get; set; }

        public int Pleasantness { get; set; }
    }
}
