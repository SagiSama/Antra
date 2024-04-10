namespace ConsoleApp1.Assignment3.four_principles;
// 4. use Inheritance
public class Practice4
{
    public static void Main()
    {
        Vehicle vehicle = new Vehicle(1, "vehicle");
        Vehicle car = new Car(2, "prius", "toyota");
        Vehicle plane = new Plane(3, "boyng");
        
        Console.WriteLine("vehicle" + vehicle.serial +" "+ vehicle.name);
        Console.WriteLine("car" + car.serial +" "+ car.name +" "+ ((Car) car).make);
        Console.WriteLine("plane" + plane.serial +" "+ plane.name);
        Plane p = (Plane) plane;
        p.feature();
    }
}

class Vehicle
{
    public int serial;
    public string name;

    public Vehicle(int serial, string name)
    {
        this.serial = serial;
        this.name = name;
    }
}

class Car : Vehicle
{
    public string make;
    public Car(int serial, string name, string make) : base(serial, name)
    {
        this.make = make; 
    }
}
class Plane : Vehicle
{
    public Plane(int serial, string name) : base(serial, name) { }
    public void feature() { Console.WriteLine("Can fly!"); }
}