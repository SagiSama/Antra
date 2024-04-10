namespace ConsoleApp1.Assignment3.four_principles;
// 3. encapsulation

public class Practice3
{
    public static void Main()
    {
        Computer c1 = new Computer(001);
        c1.Cpu = "8GB Intel RGT";
        c1.Ram = "16GB Core X GTI";
        
        Computer c2 = new Computer(020);
        c2.Cpu = "32GB RGT DELL";
        c2.Ram = "160GB HP Core X";
        
        Console.WriteLine(c1 +" => "+ c1.Cpu +" "+ c1.Ram);
        Console.WriteLine(c2 +" => "+ c2.Cpu +" "+ c2.Ram);
    }
}

class Computer
{
    private int serial;
    private string cpu;
    private string ram;
    public Computer(int serial)
    {
        this.serial = serial; 
    }
    public string Cpu { get; set; }
    public string Ram { get; set; }
}