namespace Day2.Assignment3.Practice7;

public class Test
{
    public static void Main()
    {
        Color red = new Color();
        red.setRed();
        Color green = new Color();
        green.setGreen();
        Color blue = new Color();
        blue.setBlue();

        Ball ball1 = new Ball();
        ball1.Size = 10;
        ball1.Color = red;
        ball1.Throw();
        ball1.Throw();
        ball1.Throw();
        
        Console.WriteLine(ball1 +" "+ ball1.Size +" "+ ball1.Color.Type +" "+ ball1.ThrowCount);
        
        Ball ball2 = new Ball();
        ball2.Size = 30;
        ball2.Color = blue;
        ball2.Throw();
        ball2.Pop();
        ball2.Throw();
        Console.WriteLine(ball2 +" "+ ball2.Size +" "+ ball2.Color.Type +" "+ ball2.ThrowCount);
    }
}