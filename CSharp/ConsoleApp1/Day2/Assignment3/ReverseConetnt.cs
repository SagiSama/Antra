namespace ConsoleApp1.Assignment3;

public class ReverseConetnt
{
    public static void Main()
    {
        int[] numbers = GenerateNumbers();
        Reverse(numbers);
        PrintNumbers(numbers);
    }
    private static void Reverse(int[] nums)
    {
        int l = 0, r = nums.Length - 1;
        while (l < r)
        {
            int tmp = nums[l];
            nums[l++] = nums[r];
            nums[r--] = tmp;
        }
    }
    private static int[] GenerateNumbers()
    {
        Console.WriteLine("enter numbers comma separated");
        string str = Console.ReadLine();
        List<string> arr = str.Split(' ').ToList();
        int[] res = new int[arr.Count];
        for (int i = 0; i < arr.Count; i++) res[i] = int.Parse(arr[i]);
        return res;
    }
    private static void PrintNumbers(int[] nums)
    {
        for(int i = 0; i < nums.Length; i++) Console.Write(nums[i]+", ");
    }
}