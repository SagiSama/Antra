namespace ConsoleApp1.Assignment1;
using System;

public class Exercise03
{
    // 1.
    public static void FizzBuzz()
    {
        for (int i = 0; i < 100; i++)
        {
            String s = "";
            if (i % 3 == 0) s = "fizz";
            if (i % 5 == 0) s += "buzz";
            
            Console.WriteLine($"{s} {i}");
        }
    }
    
    // 1 - 2
    // infinite loop because byte type will not be reach 500 and it will never stop
    // to fix need to change byte to int or lower the max int to 254
    public static void Test()
    {
        int max = 500;
        for (byte i = 0; i < max; i++)
        {
            WriteLine(i);
        }
    }

    private static void WriteLine(int i)
    {
        Console.WriteLine(i);
    }

    // 2.
    public static void PrintPyramid()
    {
        int level = 5;
        for (int i = 1; i <= 5; i++)
        {
            for(int j = 1; j <= level - i; j++) Console.Write(" ");
            for(int j = 1; j < i * 2; j++) Console.Write("*");
            Console.WriteLine();
        }
    }
    
    // 3 guess number
    public static void GuessNumber()
    {
        int correctNumber = new Random().Next(3) + 1;
        //Console.WriteLine(correctNumber);   
        Console.WriteLine("guess number between 1 and 3");  
        int guessedNumber = int.Parse(Console.ReadLine());
        
        if(guessedNumber > 3 || guessedNumber <= 0) Console.WriteLine("invalid! less than 1 or more than 3");
        if(guessedNumber < correctNumber) Console.WriteLine("guess number is lower than correct number");
        else if(guessedNumber > correctNumber) Console.WriteLine("guess number is greater than correct number");
        else Console.WriteLine("Correct");
    }
    
    // 4 anniversary
    public static void BirthDate()
    {
        Console.WriteLine("Please enter year");
        int year = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter month");
        int month = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter day");
        int day = int.Parse(Console.ReadLine());
        
        DateTime today = DateTime.Today;
        int days;
        year = today.Year - year;
        days = year * 365;
        days -= month * 30;
        days += today.Month * 30 + today.Day;
        
        Console.WriteLine($"Happy {days}'th day");
        Console.WriteLine($"Next birthday is {10000 - (days % 10000)}");
    }
    
    // 5.
    public static void Greeting()
    {
        DateTime today = DateTime.Now;
        
        if(6 <= today.Hour && today.Hour <= 12) Console.WriteLine("Good Morning");
        if(12 <= today.Hour && today.Hour <= 18) Console.WriteLine("Good Afternoon");
        if(18 <= today.Hour && today.Hour <= 24) Console.WriteLine("Good Evening");
        if(24 <= today.Hour && today.Hour <= 6) Console.WriteLine("Good Night");
    }
    
    // 6
    public static void up24()
    {
        for(int i = 0; i < 4; i++)
        {
            String comma = "";
            for (int j = 0; j < 25; j += i + 1)
            {
                Console.Write($"{comma + j}");
                comma = ", ";
            }
            Console.WriteLine("\n");
        }
    }
}