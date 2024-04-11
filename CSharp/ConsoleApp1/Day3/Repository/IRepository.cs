namespace Day3.Repository;
// 3.
public interface IRepository<T>
{
    void Add(T item);
    void Remove(T item);
}