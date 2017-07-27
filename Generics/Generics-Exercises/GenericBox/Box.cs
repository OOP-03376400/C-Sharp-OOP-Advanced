using System;
using System.Collections.Generic;

public class Box<T> 
{
    public T Value { get; set; }

    public Box()
    {
        this.Value = default(T);
    }

    public override string ToString()
    {
        return $"{this.Value.GetType().FullName}: {this.Value}";
    }   
}

