using System;
using System.Linq;

public class ResizableStack<T>
{
    private T[] stack;
    private int? pointer;

    public ResizableStack()
    {
        this.stack = new T[5];
        this.pointer = null;
    }

    public T Pop()
    {
        T result = this.Peek();

        if (this.pointer > 0)
        {
            this.pointer--;
        }
        else
        {
            this.pointer = null;
        }

        return result;
    }

    public void Push(T value)
    {
        if (pointer == null)
        {
            this.pointer = 0;
            this.stack[(int)this.pointer] = value;
            return;
        }
        else if (pointer == this.stack.Length - 1)
        {
            this.DoubleStack();
        }

        this.pointer++;
        this.stack[(int)this.pointer] = value;
    }

    public int Count()
    {
        if (this.pointer == null)
        {
            return 0;
        }

        return (int)this.pointer + 1;
    }

    public T Peek()
    {
        if (pointer == null)
        {
            throw new ArgumentNullException("Cannot peek from empty stack");
        }

        return this.stack[(int)this.pointer];
    }

    public void Clear()
    {
        this.stack = new T[5];
        this.pointer = null;
    }

    public bool Contains(T value)
    {
        return this.stack.Contains(value);
    }

    private void DoubleStack()
    {
        int currentStackSize = this.stack.Length;
        T[] newStack = new T[2 * currentStackSize];

        for (int i = 0; i < currentStackSize; i++)
        {
            newStack[i] = this.stack[i];
        }

        this.stack = newStack;
    }
}
