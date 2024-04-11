using Day2.Assignment3.Practice6.Service;

namespace Day2.Assignment3.Practice6.Repository;

public class PersonRepository : IPersonService
{
    private List<Person> persons = new List<Person>();

    public bool Create(Person person)
    {
        persons.Add(person);
        return true;
    }
    public Person Read(int id)
    {
        foreach(Person s in persons)
        {
            if (s.Id == id) return s;
        }
        return null;
    }
    public bool Update(Person obj)
    {
        Person s = Read(obj.Id);
        if (s == null) return false;
        s.Id = obj.Id;
        s.Name = obj.Name;
        return true;
    }
    public bool Delete(int id)
    {
        Person s = Read(id);
        if (s == null) return false;
        persons.Remove(s);
        return true;
    }
    public List<Person> GetAll()
    {
        return persons;
    }

    public int CalculateSalary()
    {
        return 10;
    }
}