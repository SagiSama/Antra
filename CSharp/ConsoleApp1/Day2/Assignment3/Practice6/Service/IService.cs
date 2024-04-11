namespace Day2.Assignment3.Practice6.Service;

public interface IService<T>
{
    bool Create(T o);
    T Read(int id);
    bool Update(T o);
    bool Delete(int id);
    List<T> GetAll();
}