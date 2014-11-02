namespace SortingHomework
{
    using System;
    using System.Collections.Generic;

    public class SortableCollection<T> where T : IComparable<T>
    {
        private readonly IList<T> items;

        public SortableCollection()
        {
            this.items = new List<T>();
        }

        public SortableCollection(IEnumerable<T> items)
        {
            this.items = new List<T>(items);
        }

        public IList<T> Items
        {
            get
            {
                return this.items;
            }
        }

        public void Sort(ISorter<T> sorter)
        {
            sorter.Sort(this.items);
        }

        public bool LinearSearch(T item)
        {
            int numberOfElements = this.items.Count;

            for (int i = 0; i < numberOfElements; i++)
            {
                if (this.items[i].CompareTo(item) == 0)
                {
                    return true;
                }
            }

            return false;
        }

        public bool BinarySearch(T item)
        {
            int minPosition = 0;
            int maxPosition = this.items.Count - 1;
            int searchPosition = minPosition + ((maxPosition - minPosition) / 2);

            while (maxPosition - minPosition > 1)
            {
                switch (this.items[searchPosition].CompareTo(item))
                {
                    case 1:
                        maxPosition = searchPosition;
                        break;
                    case -1:
                        minPosition = searchPosition;
                        break;
                    case 0:
                        return true;
                    default:
                        break;
                }

                searchPosition = minPosition + ((maxPosition - minPosition) / 2);
            }

            //Last check in case maxPosition - minPosition == 1 coz the loop can't handle this case correctly
            if (maxPosition - minPosition == 1)
            {
                if (this.items[minPosition].CompareTo(item) == 0)
                {
                    return true;
                }
                else if (this.items[maxPosition].CompareTo(item) == 0)
                {
                    return true;
                }
            }

            return false;
        }

        public void Shuffle()
        {
            //The complexity of the algorithm is O(n) -> We go through all n elements and for each of them do a few operations -> x*n which is stil O(n)
            Random randomGenerator = new Random();
            int numberOfItems = this.items.Count;

            for (int i = 0; i < numberOfItems; i++)
            {
                int randomPosition = i + randomGenerator.Next(0, numberOfItems - i);
                var swapHelper = this.items[i];
                this.items[i] = this.items[randomPosition];
                this.items[randomPosition] = swapHelper;
            }
        }

        public void PrintAllItemsOnConsole()
        {
            for (int i = 0; i < this.items.Count; i++)
            {
                if (i == 0)
                {
                    Console.Write(this.items[i]);
                }
                else
                {
                    Console.Write(" " + this.items[i]);
                }
            }

            Console.WriteLine();
        }
    }
}
