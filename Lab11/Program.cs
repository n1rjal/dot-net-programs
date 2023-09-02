// Base class: Vehicle
public class Vehicle
{
    public int NumberOfWheels { get; set; }
    public string Color { get; set; }

    public Vehicle(int numberOfWheels, string color)
    {
        NumberOfWheels = numberOfWheels;
        Color = color;
    }

    public void Drive()
    {
        Console.WriteLine($"Driving a {Color} vehicle with {NumberOfWheels} wheels.");
    }
}

// Derived class: Car
public class Car : Vehicle
{
    public int NumberOfDoors { get; set; }

    public Car(int numberOfDoors, string color) : base(4, color) // Cars typically have 4 wheels
    {
        NumberOfDoors = numberOfDoors;
    }

    public void Honk()
    {
        Console.WriteLine("Car honk!");
    }
}

// Derived class: Bus
public class Bus : Vehicle
{
    public int SeatingCapacity { get; set; }

    public Bus(int seatingCapacity, string color) : base(6, color) // Buses typically have 6 wheels
    {
        SeatingCapacity = seatingCapacity;
    }

    public void StopAtBusStation()
    {
        Console.WriteLine("Stopping at bus station.");
    }
}

// Usage
public class Program
{
    public static void Main()
    {
        Car myCar = new Car(4, "red");
        myCar.Drive();
        myCar.Honk();

        Bus cityBus = new Bus(40, "blue");
        cityBus.Drive();
        cityBus.StopAtBusStation();

        Console.ReadKey();
    }
}
