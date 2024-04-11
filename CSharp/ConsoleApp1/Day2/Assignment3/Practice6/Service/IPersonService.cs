namespace Day2.Assignment3.Practice6.Service;

public interface IPersonService : IService<Person>
{
    bool Create(Person student);
    Person Read(int id);
    bool Update(Person obj);
    bool Delete(int id);
    List<Person> GetAll();
}