//Задача 5 – Приятелите на Пешо
//Пешо не обича да върви. 
//Не защото е мързелив, а по-скоро защото предпочита да подскача и да усеща как буйните му коси се веят наоколо. 
//Един ден в градчето на Пешо неочаквано завалял силен сняг, докато е на училище. 
//За нещастие на Пешо, той не бил подготвен за силния сняг и не бил правилно обут и облечен. 
//Докато се прибирал подскачайки Пешо се подхлъзнал и изкълчил крака си. 

//Тогава приятелите на Пешо започнали да се замислят – 
//"В коя болница да закараме Пешо, така че след това да се приберем максимално бързо по домовете си?" 
//Помогнете на приятелите на Пешо да решат проблема си преди Пешо да падне отново.

//Като входни данни получавате къщите на приятелите на пешо и болниците и разстоянията между тях. 
//Вашата задача е да намерите, в коя болница е най-добре да оставят ранения Пешо, 
//така че общото разстояние, което приятелите на Пешо трябва да изминат от тази болница до своите къщи е да е минимално.

//NOTE!!! To check the result => http://bgcoder.com/Contests/Practice/Index/118#4
//Make sure you include in one all the files in the prject, not just this one.

namespace _01.FriendsOfPesho
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class FriendsOfPesho
    {
        public static void DijkstraAlgorithm(Dictionary<Node, List<Connection>> graph, Node source)
        {
            var queue = new PriorityQueue<Node>();

            foreach (var node in graph)
            {
                node.Key.DijkstraDistance = double.PositiveInfinity;
            }

            source.DijkstraDistance = 0.0d;
            queue.Enqueue(source);

            while (queue.Count != 0)
            {
                var currentNode = queue.Dequeue();

                if (double.IsPositiveInfinity(currentNode.DijkstraDistance))
                {
                    break;
                }

                foreach (var neighbor in graph[currentNode])
                {
                    var potDistance = currentNode.DijkstraDistance + neighbor.Distance;
                    if (potDistance < neighbor.Node.DijkstraDistance)
                    {
                        neighbor.Node.DijkstraDistance = potDistance;
                        queue.Enqueue(neighbor.Node);
                    }
                }
            }
        }

        public static void Main()
        {
            //Get N, M and H
            string[] input = Console.ReadLine().Split(' ');
            int numberOfNodesN = int.Parse(input[0]);
            int numberOfconnectionsM = int.Parse(input[1]);
            int numberOfHospitalsH = int.Parse(input[2]);

            //Get all hospitals
            string[] hospitals = Console.ReadLine().Split(' ');

            //Populate the graph
            var graph = new Dictionary<Node, List<Connection>>();
            var nodes = new List<Node>();
            for (int i = 1; i <= numberOfNodesN; i++)
            {
                Node node = new Node(i);
                nodes.Add(node);
            }
            for (int i = 0; i < numberOfNodesN; i++)
            {
                graph[nodes[i]] = new List<Connection>();
            }

            //Fill connections
            for (int i = 0; i < numberOfconnectionsM; i++)
            {
                string[] connectionInfo = Console.ReadLine().Split(' ');
                Node firstNode = nodes[int.Parse(connectionInfo[0]) - 1];
                Node secondNode = nodes[int.Parse(connectionInfo[1]) - 1];
                int length = int.Parse(connectionInfo[2]);

                graph[firstNode].Add(new Connection(secondNode, length));

                graph[secondNode].Add(new Connection(firstNode, length));
            }

            double minTotalPath = double.MaxValue;
            double currentPath = 0;
            var houses = graph.Where(node => !hospitals.Contains(node.Key.Id.ToString())).ToList();
            foreach (var hospital in hospitals)
            {
                Node source = nodes[int.Parse(hospital) - 1];

                DijkstraAlgorithm(graph, source);

                currentPath = 0;

                foreach (var house in houses)
                {
                    currentPath += house.Key.DijkstraDistance;
                }

                if (minTotalPath > currentPath)
                {
                    minTotalPath = currentPath;
                }
            }

            Console.WriteLine(minTotalPath);
        }
    }
}
