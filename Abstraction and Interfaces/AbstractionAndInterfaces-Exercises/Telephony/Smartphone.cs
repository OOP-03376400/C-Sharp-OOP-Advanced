using System.Text.RegularExpressions;

public class Smartphone : IBrowsable,ICallable
{
    public string Browse()
    {
        return $"Browsing: ";
    }

    public string Call()
    {
        return $"Calling... ";
    }
}

