namespace Day2.Assignment3.Practice7;

public class Color
{
    public String Type { get; set; }
    private short value = 255;
    public short Value { set; get; }

    public void setRed()
    {
        this.Value = 0;
        this.Type = "RED";
    }
    public void setGreen()
    {
        this.Value = 100;
        Type = "GREEN";
    }
    public void setBlue()
    {
        this.Value = 200;
        Type = "BLUE";
    }
}