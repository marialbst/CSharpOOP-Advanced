namespace _09.TrafficLights.Models
{
    using System;
    using Enums;

    public class TrafficLight
    {
        public TrafficLight(string color)
        {
            this.Color = (LightColor)Enum.Parse(typeof(LightColor), color);
        }
        public LightColor Color { get; set; }

        public void Loop()
        {
            this.Color = (LightColor) (((int) this.Color + 1) % Enum.GetNames(typeof(LightColor)).Length);
        }

        public override string ToString()
        {
            return $"{this.Color}";
        }
    }
}
