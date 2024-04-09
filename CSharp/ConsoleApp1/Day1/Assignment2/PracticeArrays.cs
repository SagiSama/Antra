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
    
    // 2.
    public static void TodoList()
    {
        List<string> list = new List<string>();
        
        // for (int i = 0; true; i++) - infinite loop if not enter enter other command
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Enter command (+ item, - item, or -- to clear)):");
            string item = Console.ReadLine();

            if (item.StartsWith("--")) list.Clear();
            else if (item.StartsWith("-")) list.Remove(item.Substring(2));
            else if (item.StartsWith("+")) list.Add(item.Substring(2));
            else break;
            
            Console.WriteLine("===========================");
            Console.WriteLine(list.Count);
            foreach (string l in list) {
                Console.WriteLine(l);
            }
        }
    }
    
    // 3.
    public static void primes()
    {
        Console.WriteLine("Please enter start num");
        int startNum = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter end number to get primes");
        int endNum = int.Parse(Console.ReadLine());
        
        int[] primes = FindPrimesInRange(startNum, endNum);
        Console.WriteLine("number of primes: "+primes.Length);
        foreach(int prime in primes)
        {
            Console.Write(prime+", ");
        }
    }

    static int[] FindPrimesInRange(int startNum, int endNum)
    {
        List<int> list = new List<int>();
        for (int i = startNum; i <= endNum; i++)
        {
            if (isPrime(i))
            {
                list.Add(i);
            }
        }
        int[] res = new int[list.Count];
        for (int i = 0; i < list.Count; i++) res[i] = list[i];
        return res;
    }

    static bool isPrime(int num)
    {
        bool isPrime = true;
        int n = 2;
        while (n < num)
        {
            if (num % n == 0) isPrime = false;
            n++;
        }
        return isPrime;
    }
    
    // 4.
    public static void rotate()
    {
        Console.WriteLine("please enter array as space seperated format etc: 1 3 4");
        string str = Console.ReadLine();
        Console.WriteLine("please enter rotation num");
        int k = int.Parse(Console.ReadLine());
        
        List<string> arrStr = str.Split(' ').ToList();
        int n = arrStr.Count;
        int[] res = new int[n];
        int[] arr = new int[n];
        for (int i = 0; i < n; i++) arr[i] = int.Parse(arrStr[i]);
    
        for (int i = 0; i < k; i++)
        {
            int rem1 = 0, rem2 = res[0];
            for (int j = 1; j <= n + 1; j++)
            {
                rem1 = arr[j % n];
                arr[j % n] = rem2;
                rem2 = rem1;
            }

            for (int j = 0; j < n; j++)
            {
                res[j] += arr[j];
            }
        }
        Console.WriteLine("result is: ");
        foreach (var a in res) Console.Write(a +", ");
    }

    // 5.
    public static void longestSequence()
    {
        Console.WriteLine("please enter array to get longes sequence etc: 1 3 3 4 (comma seperated)");
        string str = Console.ReadLine();
        List<string> strArr = str.Split(' ').ToList();
        
        List<string> res = new List<string>();
        List<string> list = new List<string>();
        string tmp = "";

        for (int i = 0; i < strArr.Count; i++)
        {
            if (strArr[i] != tmp)
            {
                list.Clear();
                tmp = strArr[i];
            }
            list.Add(strArr[i]);
            if (list.Count > res.Count) res = new List<string>(list);
        }
        Console.WriteLine("Result is: ");
        foreach (var e in res) Console.Write(e + ", ");
    }
    
    // 7.
    public static void mostFrequent()
    {
        Console.WriteLine("please enter array to get most frequent num etc: 1 3 3 4 (comma seperated)");
        string str = Console.ReadLine();
        List<string> strArr = str.Split(' ').ToList();

        Dictionary<string, int> dict = new Dictionary<string, int>();
        foreach (string s in strArr)
        {
            if (dict.ContainsKey(s)) dict[s] += 1;
            else dict.Add(s, 1);
        }

        int res = 0, cnt = 0;
        foreach (KeyValuePair<string, int> entry in dict)
        {
            //Console.Write(entry + ", ");
            if (entry.Value > cnt)
            {
                res = int.Parse(entry.Key);
                cnt = entry.Value;
            }
        }

        Console.WriteLine("The answer is: " + res);
    }
}