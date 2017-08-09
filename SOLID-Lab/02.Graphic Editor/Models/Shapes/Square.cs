namespace _02.Graphic_Editor.Models.Shapes
{
    using Interfaces;

    public class Square : IShape
    {
        public string Draw()
        {
            return "I'm Square";
        }
    }
}