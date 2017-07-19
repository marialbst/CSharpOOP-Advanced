using System.Text;

public abstract class Car : ICar
{
    public Car(string model, string color)
    {
        this.Color = color;
        this.Model = model;
    }

    public string Color { get; protected set; }
    
    public string Model { get; protected set; }

    public string Start()
    {
        return "Engine start";
    }

    public string Stop()
    {
        return "Breaaak!";
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine(this.Start())
          .Append(this.Stop());

        return sb.ToString();
    }
}
