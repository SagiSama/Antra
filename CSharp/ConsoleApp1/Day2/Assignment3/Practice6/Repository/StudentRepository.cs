using Day2.Assignment3.Practice6.Service;

namespace Day2.Assignment3.Practice6.Repository;

public class StudentRepository : IStudentService
{
    private List<Student> students = new List<Student>();

    public bool Create(Student student)
    {
        students.Add(student);
        return true;
    }
    public Student Read(int id)
    {
        foreach(Student s in students)
        {
            if (s.Id == id) return s;
        }
        return null;
    }
    public bool Update(Student obj)
    {
        Student s = Read(obj.Id);
        if (s == null) return false;
        s.Id = obj.Id;
        s.Name = obj.Name;
        return true;
    }
    public bool Delete(int id)
    {
        Student s = Read(id);
        if (s == null) return false;
        students.Remove(s);
        return true;
    }
    public List<Student> GetAll()
    {
        return students;
    }

    public float getGpa()
    {
        return 4.0f;
    }
}