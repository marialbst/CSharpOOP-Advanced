namespace _02.Graphic_Editor.Models.Shapes
{
    using Interfaces;

    public class Circle : IShape
    {
        public string Draw()
        {
            return "I'm Circle";
        }
    }
}