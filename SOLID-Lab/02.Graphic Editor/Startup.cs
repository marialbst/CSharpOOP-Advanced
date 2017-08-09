namespace _02.Graphic_Editor
{
    using Core;
    using Interfaces;
    using Models;
    using Models.Shapes;

    public class Startup
    {
        public static void Main()
        {
            GraphicEditor editor = new GraphicEditor();
            IShape circle = new Circle();
            editor.DrawShape(circle);

            IShape rectangle = new Rectangle();
            editor.DrawShape(rectangle);

            IShape square = new Square();
            editor.DrawShape(square);
        }
    }
}
