namespace ConsoleApp1.Assignment2;

public class PracticeString
{
    // 1.
    public static void reverses()
    {
        Console.WriteLine("please enter a string to reverse it");
        string str = Console.ReadLine();
        char[] arr = str.ToCharArray();
        
        int l = 0, r = str.Length - 1;
        while (l < r)
        {
            char c = arr[l];
            arr[l++] = arr[r];
            arr[r--] = c;
        }
        string reversed = new string(arr);
        Console.WriteLine("The reversed answer is: " + str + " => " + reversed);
    }
    
    // 2.
    public static void reverseSentence()
    {
        char[] delimiterChars = { ' ', ',', ':', ';', '=', '(', ')', '&', '[', ']', '"', '\\', '/', '!', '?', '\'' };
        //  , : ; = ( ) & [ ] " ' \ / ! ? (space)
        Console.WriteLine("please enter a string to reverse it");
        string str = Console.ReadLine();
        string[] arr =  str.Split(delimiterChars);
        int n = arr.Length;
        
        for (int i = 0; i < n / 2; i++)
        {
            string tmp = arr[i];
            arr[i] = arr[n - 1 - i];
            arr[n - 1 - i] = tmp;
        }
        foreach(string ss in arr) Console.Write(ss +" ");
    }

    static char[] delimiterChars = { ' ', ',', ':', ';', '=', '(', ')', '&', '[', ']', '"', '\\', '/', '!', '?', '\'', '.' };
    // 3. pali
    public static void palindromes()
    {
        Console.WriteLine("please enter a string to reverse it");
        string str = Console.ReadLine();
        string[] arr =  str.Split(delimiterChars);

        for(int i = 0; i < arr.Length; i++)
        {
            if(isPali(arr[i])) Console.Write(arr[i]+", ");
        }
    }

    private static bool isPali(string str)
    {
        if (str == null || str == "") return false;
        int l = 0, r = str.Length - 1;
        while (l < r)
        {
            if (str[l++] != str[r--]) return false;
        }

        return true;
    }
    
    // 4.
    public static void URL()
    {
        Console.WriteLine("please enter a string to reverse it");
        string str = Console.ReadLine();
        string protocol = "";
        string server = "";
        string resource = "";

        int idx1 = str.IndexOf("//");
        if (idx1 != -1)
        {
            protocol = str.Substring(0, idx1 - 1);
            str = str.Substring(idx1 + 2);
        }
        int idx2 = str.IndexOf("/");
        if (idx2 != -1)
        {
            server = str.Substring(0, idx2);
            resource = str.Substring(idx2 + 1);
        }
        else
        {
            server = str;
        }
        Console.WriteLine($"[protocol] = {protocol} \n [server] = {server} \n [resource] = {resource}");
    }
}