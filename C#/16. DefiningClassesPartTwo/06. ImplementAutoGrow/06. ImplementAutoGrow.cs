//Implement auto-grow functionality: when the internal array is full, 
//create a new array of double size and move all elements to it.

using System;
using System.Text;

class GenericList<T>
{
    T[] array;
    int arrayLength;
    int filledTo;

    //This is what we add to the code from task 5. 
    //I have also edited the other methods to fit the new implementation.
    private void AutoGrow()
    {
        int newLength = this.arrayLength * 2;
        T[] newArray = new T[newLength];
        this.array.CopyTo(newArray, 0);
        this.array = new T[newLength];
        newArray.CopyTo(this.array, 0);
        this.arrayLength = this.array.Length;
    }

    public override string ToString()
    {
        StringBuilder result = new StringBuilder();
        string line = null;

        for (int i = 0; i < this.array.Length; i++)
        {
            line = string.Format("Position {0} -> {1}\n", i, this.array[i]);
            result.Append(line);
        }

        return result.ToString();
    }

    public int FindElementByValue(T value)
    {
        int index = 0;

        index = Array.IndexOf(this.array, value);

        return index;
    }

    public void Clear()
    {
        int numberOfElements = this.array.Length;
        this.array = new T[numberOfElements];
    }

    public void InsertElement(T element, int index)
    {
        CheckIndex(index);

        int newArrayLength = this.filledTo + 1;
        T[] newArray = new T[newArrayLength];

        for (int i = 0, j = 0; i < newArrayLength; i++)
        {
            if (i == index)
            {
                newArray[i] = element;
                continue;
            }
            newArray[i] = this.array[j];
            j++;
        }

        if (this.arrayLength <= this.filledTo)
        {
            this.AutoGrow();
        }

        newArray.CopyTo(this.array, 0);
        filledTo++;
    }

    public void RemoveElement(int index)
    {
        CheckIndex(index);
        int newArrayLength = this.array.Length - 1;
        T[] newArray = new T[newArrayLength];

        for (int i = 0, j = 0; i < this.array.Length; i++)
        {
            if (i == index)
            {
                continue;
            }
            newArray[j] = this.array[i];
            j++;
        }
        this.array = new T[this.arrayLength];
        newArray.CopyTo(this.array, 0);
        this.filledTo--;
    }

    public T this[int index]
    {
        get
        {
            CheckIndex(index);
            return this.array[index];
        }
    }

    public void AddElement(T element)
    {
        if (this.arrayLength <= this.filledTo)
        {
            this.AutoGrow();
        }

        this.array[filledTo] = element;
        this.filledTo++;
    }

    private void CheckIndex(int index)
    {
        int maxPosibleIndex = this.array.Length - 1;

        if (index < 0 || index > maxPosibleIndex)
        {
            throw new IndexOutOfRangeException("The index you are trying to access is invalid");
        }
    }

    public GenericList(int capacity)
    {
        this.array = new T[capacity];
        this.arrayLength = capacity;
        this.filledTo = 0;
    }
}

class Test
{
    public static void Main()
    {
        GenericList<string> test = new GenericList<string>(5);
        test.AddElement("ddd");
        Console.WriteLine(test[0]);
        test.RemoveElement(0);
        Console.WriteLine(test[0]);
        test.AddElement("aaa");
        test.AddElement("bbb");
        test.AddElement("ccc");
        test.InsertElement("ddd", 2);
        Console.WriteLine(test[2]);
        test.AddElement("eee");
        test.AddElement("fff");
        Console.WriteLine(test.FindElementByValue("bbb"));
        Console.WriteLine(test.ToString());
    }
}