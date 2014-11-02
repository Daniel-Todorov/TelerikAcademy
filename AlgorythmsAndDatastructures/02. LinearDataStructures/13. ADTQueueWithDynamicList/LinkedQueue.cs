using System;

public class LinkedQueue<T>
{
    private LinkedList<T> queue;

    public void Enqueue(T value)
    {
        if (this.queue == null)
        {
            this.queue = new LinkedList<T>(value);
        }
        else
        {
            this.queue.AddLast(value);
        }
    }

    public T Dequeue()
    {
        if (this.queue == null || this.queue.Count() == 0)
        {
            throw new InvalidOperationException("Cannot dequeue from empty queue.");
        }

        T result = this.queue.FirstElement.Value;
        this.queue.RemoveFirst();

        return result;
    }

    public T Peek()
    {
        return this.queue.FirstElement.Value;
    }

    public int Count()
    {
        if (this.queue == null)
        {
            return 0;
        }

        return this.queue.Count();
    }

    public void Clear()
    {
        this.queue = null;
    }

    public bool Contains(T value)
    {
        if (this.queue == null)
        {
            return false;
        }

        ListItem<T> currentItem = this.queue.FirstElement;

        while (true)
        {
            if (currentItem.Value.Equals(value))
            {
                return true;
            }

            if (currentItem.NextItem == null)
            {
                return false;
            }

            currentItem = currentItem.NextItem;
        }
    }
}
