using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.TreeAndMethods
{
    public class Tree<T>
    {
        public Tree(TreeNode<T> root)
        {
            this.Root = root;
        }

        public TreeNode<T> Root { get; set; }

        public List<TreeNode<T>> TraverseDFS(TreeNode<T> root, List<TreeNode<T>> listOfNodes)
        {
            listOfNodes.Add(root);

            foreach (var child in root.Children)
            {
                this.TraverseDFS(child, listOfNodes);
            }
            
            return listOfNodes;
        }
    }
}
