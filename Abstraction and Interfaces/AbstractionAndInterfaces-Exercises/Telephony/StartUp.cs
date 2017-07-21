using System;
using System.ComponentModel;
using System.Text.RegularExpressions;

public class StartUp
{
    public static void Main()
    {
        var numbers = Console.ReadLine().Split(' ');
        var sites = Console.ReadLine().Split(' ');
        var phone = new Smartphone();
        var nummberRegex = new Regex(@"^\d+$");
        var siteRegex = new Regex(@"^\D+$");

        for (int i = 0; i < numbers.Length; i++)
        {

            if (nummberRegex.IsMatch(numbers[i]))
            {
                Console.WriteLine($"{phone.Call()}{numbers[i]}");
            }
            else
            {
                Console.WriteLine("Invalid number!");
            }
        }
        for (int i = 0; i < sites.Length; i++)
        {
            if (siteRegex.IsMatch(sites[i]))
            {
                Console.WriteLine($"{phone.Browse()}{sites[i]}!");
            }
            else
            {
                Console.WriteLine("Invalid URL!");
            }
        }
    }
}

