using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace _06.BinarySearchTree
{
    struct BinarySearchTree<T>
    {
        //Fields.
        private TreeNode root;

        //Properties.
        public TreeNode Root
        {
            get { return this.root; }
            set { this.root = value; }
        }

        //Methods.
        public void AddElement(IComparable newValue)
        {
            TreeNode root = this.Root;
            TreeNode previousRoot = this.Root;

            while (root != null)
            {
                switch (root.NodeValue.CompareTo(newValue))
                {
                    case 1:
                        previousRoot = root;
                        root = root.LeftChild;
                        break;
                    case 0:
                        throw new NotSupportedException("Cannot add existing value in a binary search tree");
                    case -1:
                        previousRoot = root;
                        root = root.RightChild;
                        break;
                    default:
                        break;
                }
            }

            switch (previousRoot.NodeValue.CompareTo(newValue))
            {
                case 1:
                    previousRoot.LeftChild = new TreeNode(newValue);
                    previousRoot.LeftChild.Parent = previousRoot;
                    return;
                case 0:
                    throw new NotSupportedException("Cannot add existing value in a binary search tree");
                case -1:
                    previousRoot.RightChild = new TreeNode(newValue);
                    previousRoot.RightChild.Parent = previousRoot;
                    return;
                default:
                    return;
            }
        }

        public TreeNode SearchElement(IComparable value)
        {
            TreeNode root = this.Root;

            while (root != null)
            {
                switch (root.NodeValue.CompareTo(value))
                {
                    case 1:
                        root = root.LeftChild;
                        break;
                    case 0:
                        return root;
                    case -1:
                        root = root.RightChild;
                        break;
                    default:
                        break;
                }
            }

            return null;
        }

        //NOTE! Not workign properly. Hints will be appreciated!
        public void DeleteElement(IComparable value)
        {
            TreeNode root = this.Root;
            TreeNode nodeToChange = this.SearchElement(value);

            if (nodeToChange == null)
            {
                throw new NotSupportedException("The value does not exists in the tree.");
            }

            if (nodeToChange.LeftChild == null && nodeToChange.RightChild == null)
            {
                nodeToChange = null;
            }
            else if (nodeToChange.RightChild == null)
            {
                nodeToChange = nodeToChange.LeftChild;
            }
            else if (nodeToChange.RightChild.LeftChild == null && nodeToChange.RightChild.RightChild == null)
            {
                nodeToChange = nodeToChange.RightChild;
            }
            else
            {
                do
                {
                    root = nodeToChange.LeftChild;
                } while (root.LeftChild != null);

                nodeToChange = root;
            }

            return;
        }

        //Constructors
        public BinarySearchTree(IComparable rootValue)
        {
            this.root = new TreeNode(rootValue);
        }
    }
}
