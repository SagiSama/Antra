namespace Day3.Repository;
// 3.
public class GenericRepository<T> : IRepository<T>
{
    private List<T> items = new List<T>();
    
    public void Add(T item)
    {
        items.Add(item);
    }

    public void Remove(T item)
    {
        items.Remove(item);
    }

    public List<T> getAll()
    {
        return items;
    }
}