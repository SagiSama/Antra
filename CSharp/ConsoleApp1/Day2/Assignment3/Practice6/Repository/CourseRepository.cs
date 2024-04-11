using System.Net.Sockets;
using Day2.Assignment3.Practice6.Service;

namespace Day2.Assignment3.Practice6.Repository;

public class CourseRepository : ICourseService
{
    private List<Course> courses = new List<Course>();

    public bool Create(Course course)
    {
        courses.Add(course);
        return true;
    }
    public Course Read(int id)
    {
        foreach(Course s in courses)
        {
            if (s.Id == id) return s;
        }
        return null;
    }
    public bool Update(Course obj)
    {
        Course s = Read(obj.Id);
        if (s == null) return false;
        s.Id = obj.Id;
        s.Name = obj.Name;
        return true;
    }
    public bool Delete(int id)
    {
        Course s = Read(id);
        if (s == null) return false;
        courses.Remove(s);
        return true;
    }
    public List<Course> GetAll()
    {
        return courses;
    }

    public List<Student> getEnrollment(Course course)
    {
        List<Student> res = new List<Student>();
        List<Student> students = new StudentRepository().GetAll();
        foreach(Student student in students)
        {
            if (student.Course == course)
            {
                res.Add(student);
            }
        }
        return res;
    }
}