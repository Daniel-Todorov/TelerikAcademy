namespace _03.CableTVCompany
{
    using System;
    using System.Collections.Generic;

    public class CableTVCompany
    {
        public static void Main()
        {
            var priority = new SortedSet<Path>();
            const int numberOfNodes = 6;
            var used = new bool[numberOfNodes + 1];
            var mpdNodes = new List<Path>();
            var edges = new List<Path>();
            InitializeGraph(edges);

            foreach (Path edge in edges)
            {
                if (edge.StartNode == edges[0].StartNode)
                {
                    priority.Add(edge);
                }
            }

            used[edges[0].StartNode] = true;

            FindMinimumSpanningTree(used, priority, mpdNodes, edges);

            Console.WriteLine("The minimal for connecting all houses is {0} for the following spanning tree:", GetMinimumSpanningTreeCost(mpdNodes));
            PrintMinimumSpanningTree(mpdNodes);
        }

        private static int GetMinimumSpanningTreeCost(List<Path> mpdNodes)
        {
            int totalCost = 0;
            foreach (var edge in mpdNodes)
            {
                totalCost += edge.Weight;
            }

            return totalCost;
        }
  
        private static void PrintMinimumSpanningTree(IEnumerable<Path> mpdNodes)
        {
            foreach (Path edge in mpdNodes)
            {
                Console.WriteLine("{0}", edge);
            }
        }

        private static void FindMinimumSpanningTree(bool[] used, SortedSet<Path> priority, List<Path> mpdEdges, List<Path> edges)
        {
            while (priority.Count > 0)
            {
                Path edge = priority.Min;
                priority.Remove(edge);

                if (!used[edge.EndNode])
                {
                    used[edge.EndNode] = true;
                    mpdEdges.Add(edge);
                    AddEdges(edge, edges, mpdEdges, priority, used);
                }
            }
        }

        private static void AddEdges(Path edge, List<Path> edges, List<Path> mpd, SortedSet<Path> priority, bool[] used)
        {
            for (int i = 0; i < edges.Count; i++)
            {
                if (!mpd.Contains(edges[i]))
                {
                    if (edge.EndNode == edges[i].StartNode && !used[edges[i].EndNode])
                    {
                        priority.Add(edges[i]);
                    }
                }
            }
        }

        private static void InitializeGraph(List<Path> edges)
        {
            edges.Add(new Path(1, 3, 5));
            edges.Add(new Path(1, 2, 4));
            edges.Add(new Path(1, 4, 9));
            edges.Add(new Path(4, 1, 9));
            edges.Add(new Path(2, 4, 2));
            edges.Add(new Path(3, 4, 20));
            edges.Add(new Path(3, 5, 7));
            edges.Add(new Path(4, 5, 8));
            edges.Add(new Path(5, 4, 8));
            edges.Add(new Path(5, 6, 12));
        }
    }
}
