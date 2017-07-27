using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    public static void Main()
    {
        var inputCount = int.Parse(Console.ReadLine());
        var listOfBoxes = new List<double>();
        for (int i = 0; i < inputCount; i++)
        {
            Box<double> box = new Box<double>();
            var input = double.Parse(Console.ReadLine());
            box.Value = input;
            listOfBoxes.Add(box.Value);
        }
        var compareValue = double.Parse(Console.ReadLine());
        Console.WriteLine(Compare(listOfBoxes, compareValue));
    }

    public static void Swap(List<Box<int>> collection, int firstElement, int secondElement)
    {
        var temp = collection[firstElement];
        collection[firstElement] = collection[secondElement];
        collection[secondElement] = temp;
    }

    public static int Compare<T>(List<T> list, T element)
        where T : IComparable<T>
    {
        int counter = 0;
        foreach (var generic in list)
        {
            if (generic.CompareTo(element) > 0)
            {
                counter++;
            }
        }
        return counter;
    }
}

