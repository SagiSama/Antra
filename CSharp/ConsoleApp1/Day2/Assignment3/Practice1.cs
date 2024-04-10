using System.Security.Authentication.ExtendedProtection;
// 1. use Abstraction/, /Encapsulation/, /Inheritance/ and /Polymorphism/
namespace ConsoleApp1.Assignment3.four_principles;

public class Practice1
{
    public static void Main()
    {
        //1. abstraction = hiding impl detail of animal
        //2. polymorphism calling overriden member varialbe 
        //3. encapsulated making member variable private and providing getter and setter
        //4. implemented inheritance
        Animal dog = new Dog(10);
        Animal pig = new Pig(4);
        
        dog.setName("Wolfy");
        dog.MakeNoise();
        Console.WriteLine(dog.toStringRep());

        pig.setName("Piggy");
        Pig p = (Pig) pig;
        p.Nickname = "FLower";
        pig.MakeNoise();
        Console.WriteLine(pig.toStringRep());
    }
}
abstract class Animal
{
    protected int age;
    protected String name;
    abstract public String toStringRep();
    public void setName(String name)
    {
        this.name = name;
    }

    public String getName(String name)
    {
        return name;
    }

    public virtual void MakeNoise()
    {
        Console.WriteLine("Animal makes noise");
    }
}
class Dog : Animal
{
    public Dog(int age)
    {
        this.age = age; 
    }
    private string Nickname
    {
        get
        {
            return Nickname;
        } 
        set
        {
            Nickname = value;
        }
    }
    public override string toStringRep()
    {
        return name + age;
    }
    public override void MakeNoise()
    {
        Console.WriteLine("Dog Barking");
    }
}

class Pig : Animal
{
    public Pig(int age)
    {
        this.age = age; 
    }
    public string Nickname { get; set; }
    public override string toStringRep()
    {
        return age + name +" "+ Nickname;
    }
    public override void MakeNoise()
    {
        Console.WriteLine("Pig Wee wee!");
    }
}