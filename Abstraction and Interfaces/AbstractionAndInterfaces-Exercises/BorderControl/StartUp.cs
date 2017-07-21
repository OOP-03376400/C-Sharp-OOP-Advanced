using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    public static void Main()
    {
        string input;
        var collection = new List<ITown>();
        var robot = new Robot();
        var citizen = new Citizen();

        var result = new List<string>();

        while ((input = Console.ReadLine()) != "End")
        {
            var inputParams = input.Split(' ');
            if (inputParams.Length == 2)
            {
                var id = inputParams[1];
                robot.Id = id;
                collection.Add(robot);
            }
            else
            {
                var id = inputParams[2];
                citizen.Id = id;

                collection.Add(citizen);
            }
        }
        var fakeId = Console.ReadLine();

        foreach (var towner in collection)
        {
            var townedId = towner.Id.Skip(towner.Id.Length - fakeId.Length).ToString();
            if (string.Equals(townedId,fakeId))
            {
                result.Add(towner.Id);
            }
            
        }
        foreach (var id in result)
        {
            Console.WriteLine(id);
        }
    }
}

