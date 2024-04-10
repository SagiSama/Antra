namespace ConsoleApp1.Assignment1;

public class HackerName
{
    public static void Main()
    {
        Console.WriteLine("Hello let's create your hackername :)");
        Console.WriteLine("What nickname do you like?");
        var name = Console.ReadLine();
        Console.WriteLine("What is your zodiac sign?");
        var zodiac = Console.ReadLine();
        Console.WriteLine("What is color do you?");
        var color = Console.ReadLine();
        Console.WriteLine("Lucky number?");
        var num = Console.Read();

        Console.WriteLine($"Your evil hacker name is: {name + "@" + color + "_" + zodiac + "#" + num}");
    }
}