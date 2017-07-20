using System;

public class Circle : IDrawable
{
    public Circle(int radius)
    {
        this.Radius = radius;
    }

    public int Radius { get; private set; }

    public void Draw()
    {
        double innerRadius = this.Radius - 0.4;
        double outerRadius = this.Radius + 0.4;

        for (double y = this.Radius; y >= -this.Radius; y--)
        {
            for (double x = -this.Radius; x < outerRadius; x+=0.5)
            {
                double val = x * x + y * y;

                if (val >= innerRadius * innerRadius && val <= outerRadius * outerRadius)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(" ");
                }
            }

            Console.WriteLine();
        }
    }
}