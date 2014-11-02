//Write a generic class GenericList <T> that keeps a list of elements of some parametric type T.
//Keep the elements of the list in an array with fixed capacity which is given as parameter in the class constructor.
//Implement methods for adding element, accessing element by index, removing element by index, 
//inserting element at given position, clearing the list, find the element by its value and ToString().
//Check all input parameters to avoid accessing elements at invalid positions.

using System;
using System.Text;

class GenericList<T>
{
    T[] array;

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
        int newArrayLength = this.array.Length + 1;
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

        this.array = new T[newArrayLength];
        newArray.CopyTo(this.array, 0);
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
        this.array = new T[newArrayLength];
        newArray.CopyTo(this.array, 0);
    }

    public T this[int index]
    {
        get
        {
            CheckIndex(index);
            return this.array[index];
        }
        set
        {
            CheckIndex(index);
            this.array[index] = value;
        }
    }

    public void AddElement(T element)
    {
        int newArrayLength = this.array.Length + 1;
        T[] newArray = new T[newArrayLength];
        this.array.CopyTo(newArray, 0);
        newArray[newArray.Length - 1] = element;
        this.array = new T[newArrayLength];
        newArray.CopyTo(this.array, 0);
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
    }
}

class Test
{
    public static void Main()
    {
        GenericList<string> test = new GenericList<string>(5);
        test.AddElement("ddd");
        Console.WriteLine(test[5]);
        test[0] = "aaaa";
        Console.WriteLine(test[0]);
        test.RemoveElement(0);
        Console.WriteLine(test[0]);
        test.InsertElement("bbb", 2);
        Console.WriteLine(test[2]);
        Console.WriteLine(test.FindElementByValue("bbb"));
        Console.WriteLine(test.ToString());
    }
}