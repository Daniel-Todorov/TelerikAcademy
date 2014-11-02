using System;
using System.Collections.Generic;
using System.Linq;

using Wintellect.PowerCollections;

public class BiDictionary<K, M, V>
{
    private OrderedMultiDictionary<K, V> firstStore;
    private OrderedMultiDictionary<M, V> secondStore;

    public BiDictionary()
    {
        this.firstStore = new OrderedMultiDictionary<K, V>(true);
        this.secondStore = new OrderedMultiDictionary<M, V>(true);
    }

    //public void Add(K key, V value)
    //{
    //    this.firstStore.Add(key, value);
    //}

    //public void Add(M key, V value)
    //{
    //    this.secondStore.Add(key, value);
    //}

    public void Add(K key1, M key2, V value)
    {
        this.firstStore.Add(key1, value);
        this.secondStore.Add(key2, value);
    }

    public List<V> Get(K key1, M key2)
    {
        List<V> result = new List<V>();

        var resultFromFirstKey = this.firstStore[key1];
        var resultFromSecondKey = this.secondStore[key2];

        result = resultFromFirstKey.Intersect(resultFromSecondKey).ToList();

        return result;
    }

    public List<V> Get(M key)
    {
        if (!this.secondStore.ContainsKey(key))
        {
            throw new InvalidOperationException("Key does not exist");
        }

        List<V> result = new List<V>();

        result = this.secondStore[key].ToList();

        return result;
    }

    public List<V> Get(K key)
    {
        if (!this.firstStore.ContainsKey(key))
        {
            throw new InvalidOperationException("Key does not exist");
        }

        List<V> result = new List<V>();

        result = this.firstStore[key].ToList();

        return result;
    }
}
