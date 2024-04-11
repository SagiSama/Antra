namespace Day2.Assignment3.Practice6.Service;

public interface IInstructorService : IService<Instructor>
{
    bool Create(Instructor student);
    Instructor Read(int id);
    bool Update(Instructor obj);
    bool Delete(int id);
    List<Instructor> GetAll();
}