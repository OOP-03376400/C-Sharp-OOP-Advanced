﻿using System;
using System.Collections;
using System.Collections.Generic;


public class ListyIterator<T> : IEnumerable<T>
{
    private readonly List<T> data;
    private int currentIndex;

    public ListyIterator()
    {
        this.data = new List<T>();
        this.CurrentIndex = -1;
    }

    public ListyIterator(List<T> items)
    {
        this.data = items;
    }

    public int CurrentIndex
    {
        get { return this.currentIndex; }
        set { this.currentIndex = value; }
    }

    public bool Move()
    {
        if (this.data.Count > this.currentIndex)
        {
            this.currentIndex++;
            return true;
        }

        return false;
    }

    public T Print()
    {
        if (this.data.Count == 0)
        {
            throw new InvalidOperationException("Invalid Operation!");
        }

        return this.data[this.CurrentIndex];
    }

    public bool HasNext()
    {
        if (this.data.Count - 1 > this.currentIndex)
        {
            return true;
        }

        return false;
    }

    public string PrintAll()
    {   
        return string.Join(" ", this.data);
    }

    public IEnumerator<T> GetEnumerator()
    {
        for (int i = 0; i < this.data.Count; i++)
        {
            yield return this.data[currentIndex];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }
}
