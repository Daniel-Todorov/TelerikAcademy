namespace SortingHomework
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class SelectionSorter<T> : ISorter<T> where T : IComparable<T>
    {
        public void Sort(IList<T> collection)
        {
            int indexOfFirstUnsortedElement = 0;
            int lengthOfCollection = collection.Count;

            while (indexOfFirstUnsortedElement <= lengthOfCollection - 1)
            {
                int indexOfSmallestUnsortedElement = this.FindIndexOfSmallestUnsortedElement(collection, indexOfFirstUnsortedElement);

                if (indexOfFirstUnsortedElement != indexOfSmallestUnsortedElement)
                {
                    this.Swap(collection, indexOfFirstUnsortedElement, indexOfSmallestUnsortedElement);
                }

                indexOfFirstUnsortedElement++;
            }
        }

        private int FindIndexOfSmallestUnsortedElement(IList<T> collection, int startIndex)
        {
            int lengthOfCollection = collection.Count;
            int indexOfSmallestElement = startIndex;

            for (int i = startIndex; i < lengthOfCollection; i++)
            {
                if (collection[i].CompareTo(collection[indexOfSmallestElement]) == -1)
                {
                    indexOfSmallestElement = i;
                }
            }

            return indexOfSmallestElement;
        }

        private void Swap(IList<T> collection, int firstIndexForSwapping, int secondIndexForSwapping)
        {
            T swapHelper = collection[firstIndexForSwapping];
            collection[firstIndexForSwapping] = collection[secondIndexForSwapping];
            collection[secondIndexForSwapping] = swapHelper;
        }
    }
}
