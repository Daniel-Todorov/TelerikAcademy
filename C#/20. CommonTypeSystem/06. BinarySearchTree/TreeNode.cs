using System;
using System.Collections.Generic;

namespace _06.BinarySearchTree
{
    class TreeNode
    {
        //Fields.
        private IComparable nodeValue;
        private TreeNode parent;
        private TreeNode leftChild;
        private TreeNode rightChild;

        //Properties.
        public IComparable NodeValue
        {
            get { return this.nodeValue; }
            set { this.nodeValue = value; }
        }

        public TreeNode Parent
        {
            get { return this.parent; }
            set { this.parent = value; }
        }

        public TreeNode LeftChild
        {
            get { return this.leftChild; }
            set { this.leftChild = value; }
        }

        public TreeNode RightChild
        {
            get { return this.rightChild; }
            set { this.rightChild = value; }
        }

        //Methods.
        public override string ToString()
        {
            string result = "no value";

            if (this.nodeValue != null)
            {
                result = this.nodeValue.ToString();
            }

            return result;
        }

        //Constructors.
        public TreeNode(IComparable nodeValue)
        {
            this.nodeValue = nodeValue;
            this.parent = null;
            this.leftChild = null;
            this.rightChild = null;
        }
    }
}
