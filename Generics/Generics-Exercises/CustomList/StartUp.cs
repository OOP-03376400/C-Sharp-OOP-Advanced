using System;
using System.Linq;

public class StartUp
{
    public static void Main()
    {
        CustomList<string> myCustomList = new CustomList<string>();
        string input;
        while ((input = Console.ReadLine()) != "END")
        {
            var inputParams = input.Split(' ');

            var command = inputParams[0];

            switch (command)
            {
                case "Add":
                    myCustomList.Add(inputParams[1]);
                    break;
                case "Remove":
                    Console.WriteLine(myCustomList.Remove(int.Parse(inputParams[1])));
                    break;
                case "Contains":
                    Console.WriteLine(myCustomList.Contains(inputParams[1]));
                    break;
                case "Swap":
                    myCustomList.Swap(int.Parse(inputParams[1]),int.Parse(inputParams[2]));
                    break;
                case "Greater":
                    Console.WriteLine(myCustomList.CountGreaterThan(inputParams[1]));
                    break;
                case "Max":
                    Console.WriteLine(myCustomList.Max());
                    break;
                case "Min":
                    Console.WriteLine(myCustomList.Min());
                    break;
                case "Sort":
                    myCustomList.Sort();
                    break;
                case "Print":
                    var temp = myCustomList.ToList();
                    Console.WriteLine(string.Join("\n",temp));
                    break;
            }
        }
    }   
}

