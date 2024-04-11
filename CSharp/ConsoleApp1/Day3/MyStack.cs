namespace Day3;
// 1.
public class MyStack<T>
{
    private int len;
    private T[] arr;

    public MyStack()
    {
        len = 0;
        arr = new T[100];
    }

    public int Count()
    {
        return len;
    }

    public T Pop()
    {
        return arr[len-- - 1];
    }

    public void Push(T obj)
    {
        arr[len++] = obj;
    }
}