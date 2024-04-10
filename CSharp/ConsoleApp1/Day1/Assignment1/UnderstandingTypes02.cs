namespace ConsoleApp1.Assignment1;

public class UnderstandingTypes02
{
    // 1. number of bytes in memory: sbyte, byte, short, ushort, int, uint, long, ulong, float, double, and decimal
    public static void PrintNumberTypes()
    {
        Console.WriteLine("sbyte   = {0} to {1}", sbyte.MinValue, sbyte.MaxValue);
        Console.WriteLine("byte    = {0} to {1}", byte.MinValue, byte.MaxValue);
        Console.WriteLine("short   = {0} to {1}", short.MinValue, short.MaxValue);
        Console.WriteLine("ushort  = {0} to {1}", ushort.MinValue, ushort.MaxValue);
        Console.WriteLine("int     = {0} to {1}", int.MinValue, int.MaxValue);
        Console.WriteLine("uint    = {0} to {1}", uint.MinValue, uint.MaxValue);
        Console.WriteLine("long    = {0} to {1}", long.MinValue, long.MaxValue);
        Console.WriteLine("ulong   = {0} to {1}", ulong.MinValue, ulong.MaxValue);
        Console.WriteLine("float   = {0} to {1}", float.MinValue, float.MaxValue);
        Console.WriteLine("double  = {0} to {1}", double.MinValue, double.MaxValue);
        Console.WriteLine("decimal = {0} to {1}", decimal.MinValue, decimal.MaxValue);
    }

    // 2. enter an integer number of centuries and convert it to years, days, hours, minutes, seconds, milliseconds, microseconds, nanoseconds.
    //eg. centuries = 100 years = 36524 days = 876576 hours = 52594560 minute = 3155673600 seconds = 3155673600000 milliseconds = 3155673600000000 microseconds = 3155673600000000000 nanosecond
    public static void CenturiesToDate()
    {
        Console.WriteLine("Please enter century in int format from keyboard!");
        int centuries;
        var input = Console.ReadLine();
        if (!int.TryParse(input, out centuries))
        {
            Console.WriteLine("Invalid input number!");
            return;
        }

        var years = (uint)(centuries * 365.24);
        var days = years * 24;
        var hours = days * 60;
        ulong minutes = hours * 60;
        ulong seconds = hours * 60;
        var milliseconds = seconds * 1000;
        var microseconds = milliseconds * 1000;
        var nanosecond = microseconds * 1000;

        Console.WriteLine("{0,-10} {1,10} {2,10} {3,10} {4,10} {5,10} {6,20} {7,20} {8,20}\n",
            "Centuries", "Years", "Days", "hours", "minutes", "seconds", "milliseconds", "microseconds", "nanosecond");
        Console.WriteLine("{0,-10} {1,10} {2,10} {3,10} {4,10} {5,10} {6,20} {7,20} {8,20}\n",
            centuries, years, days, hours, minutes, seconds, milliseconds, microseconds, nanosecond);
        Console.WriteLine(
            $"centuries = {centuries} years = {years} days = {days} hours = {hours} minutes = {minutes} " +
            $"seconds = {seconds} milliseconds = {milliseconds} microseconds = {microseconds} nanosecond = {nanosecond}");
    }

    public static void Test()
    {
        var y = 1;
        var x = y++;
        Console.WriteLine(x);
        y = 1;
        x = ++y;
        Console.WriteLine(x);

        var i = x;
        for (; i < 10;)
        {
            i++;
            Console.WriteLine(i);
        }

        for (;;) ;
    }
}