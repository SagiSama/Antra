using System.Runtime.InteropServices;
using Day2.Assignment3.Practice6.Repository;

namespace Day2.Assignment3.Practice6;

public class Test
{
    public static void Main()
    {
        Course course1 = new Course();
        course1.Id = 1;
        course1.Name = "ALgo";
        
        Student student1 = new Student();
        student1.Id = 1;
        student1.Name = "one";
        Student student2 = new Student();
        student2.Id = 2;
        student2.Name = "two";
        Student student3 = new Student();
        student3.Id = 2;
        student3.Name = "tree";
        student3.Course = course1;

        StudentRepository studentRepository = new StudentRepository();
        studentRepository.Create(student1);
        studentRepository.Create(student2);
        List<Student> students = studentRepository.GetAll();
        
        foreach (Student s in students) Console.WriteLine(s +" "+ s.Id +" "+ s.Name);

        studentRepository.Delete(student1.Id);
        foreach (Student s in students) Console.WriteLine(s +" "+ s.Id +" "+ s.Name);

        studentRepository.Update(student3);
        foreach (Student s in students) Console.WriteLine(s +" "+ s.Id +" "+ s.Name);
        
        Console.WriteLine(student3.Course);
    }
}