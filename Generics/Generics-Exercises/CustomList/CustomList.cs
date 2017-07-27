using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class CustomList<T> : ICustomList<T>, IEnumerable<T> 
    where T : IComparable<T>
{
    private readonly List<T> data;

    public CustomList()
    {
        this.data = new List<T>();
    }

    public List<T> Data{ get; private set; }
    public void Add(T element)
    {
        this.data.Add(element);
    }

    public bool Contains(T element)
    {
        if (this.data.Contains(element))
        {
            return true;
        }
        return false;
    }

    public int CountGreaterThan(T element)
    {
        int counter = 0;
        foreach (var generic in data)
        {
            if (generic.CompareTo(element) > 0)
            {
                counter++;
            }
        }
        return counter;
    }

    public T Max()
    {
        return this.data.Max();
    }

    public T Min()
    {
        return this.data.Min();
    }

    public T Remove(int index)
    {
        var rem = this.data[index];
        this.data.RemoveAt(index);
        return rem;
    }

    public void Swap(int index1, int index2)
    {
        var temp = this.data[index1];
        this.data[index1] = this.data[index2];
        this.data[index2] = temp;
    }

    public void Sort()
    {
        this.data.Sort();
    }

    public IEnumerator<T> GetEnumerator()
    {
        return GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}

