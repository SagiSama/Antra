namespace ConsoleApp1.Assignment3.four_principles;
// 2. Abstraction
public class PracticeAbstraction
{
    public static void Main()
    {
        Person stu = new Student();
        Person ins = new Instructor();
        
        stu.watchMovie();
        ins.watchMovie();
    }
}

class Person
{
    private string name;
    private int age;

    public virtual void watchMovie()
    {
        Console.WriteLine("Person watches movies!");
    }
}

class Student : Person
{
    public void doLesson()
    {
        Console.WriteLine("Student study their lesson");
    }
    public override void watchMovie()
    {
        Console.WriteLine("Student watch a movie!");
    }
}

class Instructor : Person
{
    public void doTeach()
    {
        Console.WriteLine("Instructor teaches good lessons!");
    }
    public override void watchMovie()
    {
        Console.WriteLine("Teacher watching movie!");
    }
}