namespace Day2.Assignment3.Practice6.Service;

public interface ICourseService : IService<Course>
{
    bool Create(Course student);
    Course Read(int id);
    bool Update(Course obj);
    bool Delete(int id);
    List<Course> GetAll();
}