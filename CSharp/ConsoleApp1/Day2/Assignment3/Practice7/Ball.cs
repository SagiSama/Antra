namespace Day2.Assignment3.Practice7;

public class Ball
{
    public int Size { set; get; }
    public Color Color { set; get; }
    public int ThrowCount = 0;

    public void Pop()
    {
        this.Size = 0;
    }

    public void Throw()
    {
        if (Size > 0)
        {
            this.ThrowCount += 1;
        }
    }
}