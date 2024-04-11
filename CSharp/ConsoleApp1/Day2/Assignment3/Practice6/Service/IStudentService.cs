namespace Day2.Assignment3.Practice6.Service;

public interface IStudentService : IService<Student>
{
    bool Create(Student student);
    Student Read(int id);
    bool Update(Student obj);
    bool Delete(int id);
    List<Student> GetAll();
}