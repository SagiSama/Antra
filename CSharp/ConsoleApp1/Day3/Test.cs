using System.Runtime.InteropServices;
using Day3.Repository;

namespace Day3;

public class Test
{
    public static void Main()
    {
        // test 1.
        MyStack<int> stack = new MyStack<int>();
        stack.Push(11);
        stack.Push(20);
        stack.Push(37);
        
        
        Console.WriteLine(stack.Count());
        while (stack.Count() > 0)
        {
            Console.WriteLine(stack.Pop());
        }
        
        MyStack<string> stackStr = new MyStack<string>();
        stackStr.Push("test2");
        stackStr.Push("test1");
        stackStr.Push("test3");
        
        Console.WriteLine(stackStr.Count());
        while (stackStr.Count() > 0)
        {
            Console.WriteLine(stackStr.Pop());
        }
        
        // test 2.
        MyList<int> list = new MyList<int>();
        list.Add(1);
        list.Add(2);
        list.Add(1);

        Print<int>(list);
        list.Remove(1);
        Print<int>(list);
        list.DeleteAt(0);
        Print<int>(list);
        list.InsertAt(23, 0);
        Print<int>(list);
        
        Console.WriteLine(list.Contains(4));
        Console.WriteLine(list.Contains(23));
        
        list.Clear();
        Print<int>(list);
        
        // test 3.
        GenericRepository<string> genericRepository = new GenericRepository<string>();
        List<string> items = genericRepository.getAll();
        
        genericRepository.Add("item1");
        genericRepository.Add("item2");
        genericRepository.Add("item3");
        genericRepository.Add("item4");
        
        
        foreach(string item in items)
        {
            Console.Write(item +", ");
        }
        genericRepository.Remove("item1");
        genericRepository.Remove("item2");
        
        Console.WriteLine();
        foreach(string item in items)
        {
            Console.Write(item +", ");
        }
    }

    private static void Print<T>(MyList<T> list)
    {
        Console.WriteLine();
        for(int i = 0; i < list.Size(); i++)
        {
            Console.Write(list.Find(i) +", " as string);
        }
    }
}