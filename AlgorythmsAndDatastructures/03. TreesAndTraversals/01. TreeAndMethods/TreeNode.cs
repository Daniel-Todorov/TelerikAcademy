using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.TreeAndMethods
{
    public class TreeNode<T>
    {
        public TreeNode(T value)
        {
            this.Value = value;
            this.Children = new List<TreeNode<T>>();
        }

        public TreeNode<T> Parent { get; set; }
        public T Value { get; set; }
        public List<TreeNode<T>> Children { get; set; }
    }
}
