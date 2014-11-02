//You are given a tree of N nodes represented as a set 
//of N-1 pairs of nodes (parent node, child node), each 
//in the range (0..N-1).

//Write a program to read 
//the tree and find:

//a) the root node
//b) all leaf nodes
//c) all middle nodes
//d) the longest path in the tree
//e) * all paths in the tree with given sum S of their nodes
//f) * all subtrees with given sum S of their nodes

//NOTE!!! To check the results, you can start the program in debug mode and see the values in the Main method.

namespace _01.TreeAndMethods
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class EntryPoint
    {
        static void Main()
        {
            Tree<int> tree = ParseIntTree();

            List<TreeNode<int>> leaves = GetAllLeaves(tree);

            List<TreeNode<int>> middleNodes = GetMiddleNodes(tree);

            List<TreeNode<int>> longestPath = GetLongestPath(tree);

            List<List<TreeNode<int>>> allPathsWithSum = GetAllPathsWithSum(tree, 8);

            List<Tree<int>> allSubtreesWithSum = GetAllSubtreesWithSum(tree, 6);
        }

        //f) * all subtrees with given sum S of their nodes
        public static List<Tree<int>> GetAllSubtreesWithSum(Tree<int> tree, int sum)
        {
            List<TreeNode<int>> allNodes = tree.TraverseDFS(tree.Root, new List<TreeNode<int>>());
            List<Tree<int>> allSubtreesWithSum = new List<Tree<int>>();

            foreach (var node in allNodes)
            {
                Tree<int> newTree = new Tree<int>(new TreeNode<int>(node.Value){Children = node.Children});
                List<TreeNode<int>> nodesInSubtree = newTree.TraverseDFS(newTree.Root, new List<TreeNode<int>>());

                if (nodesInSubtree.Sum(nextNode => nextNode.Value) == sum)
                {
                    allSubtreesWithSum.Add(newTree);
                }
            }

            return allSubtreesWithSum;
        }

        //e) * all paths in the tree with given sum S of their nodes
        public static List<List<TreeNode<int>>> GetAllPathsWithSum(Tree<int> tree, int sum)
        {
            List<TreeNode<int>> leaves = GetAllLeaves(tree);
            List<List<TreeNode<int>>> allPathsWithSum = new List<List<TreeNode<int>>>();
            List<TreeNode<int>> currentPath = new List<TreeNode<int>>();

            foreach (var leaf in leaves)
            {
                TreeNode<int> currentNode = leaf;

                while (currentNode.Parent != null)
                {
                    currentPath.Add(currentNode);

                    currentNode = currentNode.Parent;
                }

                currentPath.Add(tree.Root);

                if (currentPath.Sum(node => node.Value) == sum)
                {
                    allPathsWithSum.Add(currentPath);
                }

                currentPath = new List<TreeNode<int>>();
            }

            return allPathsWithSum;
        }

        //d) the longest path in the tree
        public static List<TreeNode<int>> GetLongestPath(Tree<int> tree)
        {
            List<TreeNode<int>> leaves = GetAllLeaves(tree);
            List<TreeNode<int>> longestPath = new List<TreeNode<int>>();
            List<TreeNode<int>> currentPath = new List<TreeNode<int>>();

            foreach (var leaf in leaves)
            {
                TreeNode<int> currentNode = leaf;

                while (currentNode.Parent != null)
                {
                    currentPath.Add(currentNode);

                    currentNode = currentNode.Parent;
                }

                currentPath.Add(tree.Root);

                if (longestPath.Count < currentPath.Count)
                {
                    longestPath = currentPath;
                }

                currentPath = new List<TreeNode<int>>();
            }

            return longestPath;
        }

        //c) all middle nodes
        public static List<TreeNode<int>> GetMiddleNodes(Tree<int> tree)
        {
            List<TreeNode<int>> allNodes = new List<TreeNode<int>>();

            allNodes = tree.TraverseDFS(tree.Root, allNodes);

            List<TreeNode<int>> allMiddleNodes = allNodes.Where(node => node.Children.Count > 0 && node.Parent != null).ToList();

            return allMiddleNodes;
        }

        //b) all leaf nodes
        public static List<TreeNode<int>> GetAllLeaves(Tree<int> tree)
        {
            List<TreeNode<int>> allNodes = new List<TreeNode<int>>();

            allNodes = tree.TraverseDFS(tree.Root, allNodes);

            List<TreeNode<int>> allLeaves = allNodes.Where(node => node.Children.Count == 0).ToList();

            return allLeaves;
        }

        /// <summary>
        /// Read a tree from the console and returns a new tree with root element.
        /// </summary>
        /// <returns>Returns an integer tree with root element</returns>
        public static Tree<int> ParseIntTree()
        {
            Console.Write("Please, enter the number N of the nodes: ");
            int N = int.Parse(Console.ReadLine());

            List<TreeNode<int>> pairs = new List<TreeNode<int>>();
            TreeNode<int> parentNode;
            TreeNode<int> childNode;

            for (int i = 0; i < N - 1; i++)
            {
                Console.Write("Enter a pair of nodes: ");
                string[] pairOfNodes = Console.ReadLine().Split(' ');
                int parentValue = int.Parse(pairOfNodes[0]);
                int childValue = int.Parse(pairOfNodes[1]);

                if (pairs.Any(node => node.Value == parentValue))
                {
                    parentNode = pairs.Where(node => node.Value == parentValue).First();
                }
                else
                {
                    parentNode = new TreeNode<int>(parentValue);
                    pairs.Add(parentNode);
                }

                if (pairs.Any(node => node.Value == childValue))
                {
                    childNode = pairs.Where(node => node.Value == childValue).First();
                    childNode.Parent = parentNode;
                }
                else
                {
                    childNode = new TreeNode<int>(childValue);
                    childNode.Parent = parentNode;
                    pairs.Add(childNode);
                }

                parentNode.Children.Add(childNode);
            }

            //a) the root node
            Tree<int> parsedTree = new Tree<int>(pairs.Where(node => node.Parent == null).First());

            return parsedTree;
        }
    }
}
