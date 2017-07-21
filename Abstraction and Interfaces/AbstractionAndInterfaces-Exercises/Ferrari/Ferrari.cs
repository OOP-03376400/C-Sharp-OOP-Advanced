public class Ferrari : ICar
{
    public Ferrari()
    {

    }
    

    public string Driver { get; private set; }
    public string UseBrakes()
    {
        return "Brakes!";
    }

    public string GasPedal()
    {
        return "Zadu6avam sA!";
    }
}

