namespace ConsoleApp1.Assignment3.four_principles;
// 5. use Polymorphism
public class Pratice5
{
    public static void Main()
    {
        Shape shape = new Shape();
        Shape ovel = new Oval();
        Shape traingle = new Traingle();

        List<Shape> shapes = new List<Shape>();
        shapes.Add(shape);
        shapes.Add(ovel);
        shapes.Add(traingle);

        foreach (Shape s in shapes)
        {
            s.draw();
        }
    }
}

class Shape
{
    public virtual void draw()
    {
        Console.WriteLine("drawing some shape");
    }
}
class Oval : Shape
{
    public override void draw()
    {
        Console.WriteLine("drawing Oval!");
    }
}
class Traingle : Shape
{
    public override void draw()
    {
        Console.WriteLine("drawing Traingle.");
    }
}