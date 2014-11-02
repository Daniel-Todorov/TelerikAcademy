//* Define the data structure binary search tree with operations for "adding new element", "searching element" and "deleting elements". 
//It is not necessary to keep the tree balanced. 
//Implement the standard methods from – System.Object - ToString(), Equals(...), GetHashCode() and the operators for comparison == and !=. 
//Add and implement the IClonable interface for deep copy of the tree. 
//Remark: Use two types – structure BinarySearchTree (for the tree) and class TreeNode (for the tree elements). 
//Implement IEnumerable<T> to traverse the tree.

using System;
using System.Collections.Generic;

namespace _06.BinarySearchTree
{
    class Test
    {
        static void Main()
        {
            BinarySearchTree<string> testSubject = new BinarySearchTree<string>("Dani");
            Console.WriteLine(testSubject.Root.NodeValue);
            testSubject.AddElement("Ivan");
            testSubject.AddElement("Petar");
            testSubject.AddElement("Asen");
            testSubject.AddElement("Eve");

            TreeNode wantedItem = testSubject.SearchElement("Ivan");
            Console.WriteLine(wantedItem);

            //Deleting item proved to be too hard for me. IEnumerable<t> implementation too.
        }
    }
}
