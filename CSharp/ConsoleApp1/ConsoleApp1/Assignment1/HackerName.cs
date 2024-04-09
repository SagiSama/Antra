namespace ConsoleApp1.Assignment1;

using System;
using System.Text;
    
public class HackerName
{
    public static void Main()
    {
        Console.WriteLine("Hello let's create your hackername :)");
        Console.WriteLine("What nickname do you like?");
        String name = Console.ReadLine();
        Console.WriteLine("What is your zodiac sign?");
        String zodiac = Console.ReadLine();
        Console.WriteLine("What is color do you?");
        String color = Console.ReadLine();
        Console.WriteLine("Lucky number?");
        int num = Console.Read();
        
        Console.WriteLine($"Your evil hacker name is: {name +"@"+ color +"_"+ zodiac +"#"+ num}");
    }
}