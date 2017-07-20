namespace _03.Ferrari.Models
{
    using Interfaces;

    public abstract class Car : ICar
    {
        public Car(string model, string driver)
        {
            this.Model = model;
            this.Driver = driver;
        }

        public string Driver { get; private set; }

        public string Model { get; private set; }

        public string PushGas()
        {
            return "Zadu6avam sA!";
        }

        public string UseBrakes()
        {
            return "Brakes!";
        }

        public override string ToString()
        {
            return $"{this.Model}/{this.UseBrakes()}/{this.PushGas()}/{this.Driver}";
        }
    }
}