namespace _02.Graphic_Editor.Models.Shapes
{
    using Interfaces;

    public class Rectangle : IShape
    {
        public string Draw()
        {
            return "I'm Rectangle";
        }
    }
}