namespace _09.TrafficLights
{
    using System;
    using System.Collections.Generic;
    using Models;

    class Startup
    {
        static void Main(string[] args)
        {
            string[] lights = Console.ReadLine().Split();
            List<TrafficLight> trafficLights = new List<TrafficLight>();

            foreach (var light in lights)
            {
                trafficLights.Add(new TrafficLight(light));
            }

            int loops = int.Parse(Console.ReadLine());

            for (int i = 0; i < loops; i++)
            {
                trafficLights.ForEach(l => l.Loop());
                Console.WriteLine(string.Join(" ", trafficLights));
            }
        }
    }
}
