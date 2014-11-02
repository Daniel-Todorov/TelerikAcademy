using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ListItem<T>
{
    public T Value { get; set; }
    public ListItem<T> NextItem { get; set; }

    public ListItem(T value, ListItem<T> nextItem = null)
    {
        this.Value = value;
        this.NextItem = nextItem;
    }
}
