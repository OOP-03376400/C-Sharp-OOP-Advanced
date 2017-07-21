public class Tesla : ICar, IElectricCar
{
    public Tesla(string model, string color, int baterry)
    {
        this.Model = model;
        this.Color = color;
        this.Baterry = baterry;
    }
    public string Model { get; }
    public string Color { get; }
    public string Start()
    {
        return "Engine start";
    }

    public string Stop()
    {
        return "Breaaak!";
    }

    public int Baterry { get; }

    public override string ToString()
    {
        return base.ToString();
    }
}

