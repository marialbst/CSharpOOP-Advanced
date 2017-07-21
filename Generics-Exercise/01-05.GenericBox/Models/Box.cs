namespace _01_05.GenericBox.Models
{
    public class Box<T>
    {
        public Box(T val)
        {
            this.TValue = val;
        }

        public T TValue { get; private set;}

        public override string ToString()
        {
            return $"{this.TValue.GetType().FullName}: {this.TValue}";
        }
    }
}
