namespace ConsoleApp1.Assignment3;

public class Fibbanoci
{
    public static void Main()
    {
        Console.WriteLine("enter fibbanoci sequence number");
        int num = int.Parse(Console.ReadLine());
        int res = rec(num);
        Console.WriteLine("result is: "+res);
    }

    private static int rec(int num)
    {
        if (num <= 1) return num;
        return rec(num - 1) + rec(num - 2);
    }
}