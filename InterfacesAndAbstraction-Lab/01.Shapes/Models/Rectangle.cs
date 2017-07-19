using System;

public class Rectangle : IDrawable
{
    public Rectangle(int width, int height)
    {
        this.Width = width;
        this.Height = height;
    }

    public int Width { get; set; }

    public int Height { get; set; }
    
    public void Draw()
    {
        DrawLine(this.Width, '*');
        for (int row = 1; row < this.Height-1; row++)
        {
            DrawLine(this.Width, ' ');
        }
        DrawLine(this.Width, '*');
    }

    private void DrawLine(int width, char innerSymbol)
    {
        Console.WriteLine($"*{new string(innerSymbol, width-2)}*");
    }
}

