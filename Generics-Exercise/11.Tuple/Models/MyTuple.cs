namespace _11.Tuple.Models
{
    using Intefaces;

    public class MyTuple<T, U> : IMyTuple<T, U>
    {
        public MyTuple(T item1, U item2)
        {
            this.Item1 = item1;
            this.Item2 = item2;
        }

        public T Item1 { get; private set; }
        public U Item2 { get; private set; }

        public override string ToString()
        {
            return this.Item1.ToString() + " -> " + this.Item2.ToString();
        }
    }
}
