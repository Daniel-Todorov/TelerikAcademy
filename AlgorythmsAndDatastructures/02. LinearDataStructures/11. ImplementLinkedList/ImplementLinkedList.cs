//Implement the data structure linked list. Define a 
//class ListItem<T> that has two fields: value (of 
//type T) and NextItem (of type ListItem<T>). 
//Define additionally a class LinkedList<T> with a 
//single field FirstElement (of type ListItem<T>).

//NOTE!!! I have implemented the basic functonality mentioned in the presentation plus GetItemAt(position)

using System;

public class ImplementLinkedList
{
    static void Main()
    {
        LinkedList<int> ints = new LinkedList<int>(4);
        ints.AddFirst(3);
        ints.AddLast(5);
        ints.AddBefore(1, 1);
        ints.AddAfter(2, 0);
        ints.RemoveFirst();
        ints.RemoveLast();

        Console.WriteLine(ints.GetItemAt(0).Value);
    }
}
