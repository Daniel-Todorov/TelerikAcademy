using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class LinkedList<T>
{
    public ListItem<T> FirstElement;

    public LinkedList(T firstElementValue)
    {
        this.FirstElement = new ListItem<T>(firstElementValue);
    }

    public void RemoveLast()
    {
        int newLastPosition = this.Count() - 2;
        this.GetItemAt(newLastPosition).NextItem = null;
    }

    public void RemoveFirst()
    {
        this.FirstElement = this.FirstElement.NextItem;
    }

    public void AddAfter(T value, int position)
    {
        if (position == this.Count() - 1)
        {
            this.AddLast(value);
            return;
        }
        if (position >= this.Count())
        {
            throw new ArgumentOutOfRangeException("The position is beyond the number of elements in the list.");
        }

        ListItem<T> newListItem = new ListItem<T>(value, this.GetItemAt(position + 1));
        this.GetItemAt(position).NextItem = newListItem;
    }

    public void AddBefore(T value, int position)
    {
        if (position == 0)
        {
            this.AddFirst(value);
            return;
        }
        if (position >= this.Count())
        {
            throw new ArgumentOutOfRangeException("The position is beyond the number of elements in the list.");
        }

        ListItem<T> newListItem = new ListItem<T>(value, this.GetItemAt(position));
        this.GetItemAt(position - 1).NextItem = newListItem;
    }

    public ListItem<T> GetItemAt(int position)
    {
        int count = this.Count();

        if (count <= position)
        {
            throw new ArgumentException("The position can't be beyond the number of elements.");
        }

        ListItem<T> currentListItem = this.FirstElement;
        int currentCount = 0;

        while (currentCount != position)
        {
            currentListItem = currentListItem.NextItem;
            currentCount++;
        }

        return currentListItem;
    }

    public int Count()
    {
        int count = 1;
        ListItem<T> currentListItem = this.FirstElement;

        while (currentListItem.NextItem != null)
        {
            currentListItem = currentListItem.NextItem;
            count++;
        }

        return count;
    }

    public void AddFirst(T value)
    {
        ListItem<T> newListItem = new ListItem<T>(value, this.FirstElement);
        this.FirstElement = newListItem;
    }

    public void AddLast(T value)
    {
        ListItem<T> newListItem = new ListItem<T>(value);
        ListItem<T> currentListItem = this.FirstElement;

        while (true)
        {
            if (currentListItem.NextItem == null)
            {
                currentListItem.NextItem = newListItem;
                return;
            }
            else
            {
                currentListItem = currentListItem.NextItem;
            }
        }
    }


}
