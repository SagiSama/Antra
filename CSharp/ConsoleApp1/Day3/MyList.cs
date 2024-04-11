namespace Day3;
// 2.
public class MyList<T>
{
    private int len;
    private T[] list;

    public MyList()
    {
        len = 0;
        list = new T[100];
    }
    
    public void Add(T element)
    {
        list[len++] = element;
    }

    public T Remove(int index)
    {
        T tmp = list[index];
        Shink(index);
        return tmp;
    }

    public bool Contains(T element)
    {
        for(int i = 0; i < len; i++)
        {
            if (element.Equals(list[i]))
            {
                return true;
            }
        }
        return false;
    }

    public void Clear()
    {
        len = 0;
        list = new T[100];
    }

    public void InsertAt(T element, int index)
    {
        if (index < len)
        {
            list[index] = element;
        }
    }

    public void DeleteAt(int index)
    {
        Shink(index);
    }

    public T Find(int index)
    {
        return list[index];
    }

    private void Shink(int index)
    {
        for (int i = index; i < len - 1; i++)
        {
            list[i] = list[i + 1];
        }
        len--;
    }

    public int Size()
    {
        return len;
    }
}