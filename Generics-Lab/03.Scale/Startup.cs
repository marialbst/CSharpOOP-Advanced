using System;

class Startup
{
    static void Main(string[] args)
    {
        Scale<int> scale = new Scale<int>(5,10);
        Console.WriteLine(scale.GetHavier());

        Scale<string> scale1 = new Scale<string>("pe", "pes");
        Console.WriteLine(scale1.GetHavier());
    }
}