namespace ConsoleApp1.Assignment2;

public class PracticeArrays
{
    // 1.
    public static void CopyingArray()
    {
        Console.WriteLine("copy");
        int[] origArr = new[] { 2, 3, 4, 1, 100, 3, 43, 1, 9, 0 };
        int[] copyArr = new int[origArr.Length];

        for (int i = 0; i < origArr.Length; i++)
        {
            copyArr[i] = origArr[i];
        }
        Console.Write("Original arr contents => ");
        for (int i = 0; i < origArr.Length; i++)
        {
            Console.Write(origArr[i] +", ");
        }
        Console.Write("\nCopy arr contents     => ");
        for (int i = 0; i < origArr.Length; i++)
        {
            Console.Write(copyArr[i] +", ");
        }
    }
}