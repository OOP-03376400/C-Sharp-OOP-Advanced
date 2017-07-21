using System;
using System.Runtime.InteropServices.WindowsRuntime;

public class StartUp
{
    public static void Main()
    {
        var driverName = Console.ReadLine();
        var model = "488-Spider";
        ICar ferrari = new Ferrari();
        Console.WriteLine($"{model}/{ferrari.UseBrakes()}/{ferrari.GasPedal()}/{driverName}");

        string ferrariName = typeof(Ferrari).Name;
        string iCarInterfaceName = typeof(ICar).Name;

        bool isCreated = typeof(ICar).IsInterface;
        if (!isCreated)
        {
            throw new Exception("No interface ICar was created");
        }

    }
}

