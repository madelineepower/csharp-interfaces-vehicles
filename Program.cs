using System;
using System.Linq;
using System.Collections.Generic;


public interface IVehicle
{
    int PassengerCapacity { get; set; }
    string TransmissionType { get; set; }
    double EngineVolume { get; set; }
    void Start();
    void Stop();
    void Drive();
}
public interface IWaterBased
{
    double MaxWaterSpeed { get; set; }
}

public interface IGroundBased
{
    double MaxLandSpeed { get; set; }
}

public interface IAirBased
{
    double MaxAirSpeed { get; set; }
    void Fly();
}

public interface IDoors 
{
   int Doors { get; set; }
}

public interface IWheels
{
    int Wheels { get; set; }
} 

public interface IWings
{
   bool Winged { get; set; } 
}


public class JetSki : IVehicle, IWaterBased 
{
    public int PassengerCapacity { get; set; }
    public string TransmissionType { get; set; }
    public double EngineVolume { get; set; }
    public double MaxWaterSpeed { get; set; }

    public void Drive()
    {
        Console.WriteLine("The jetski zips through the waves with the greatest of ease");
    }

    public void Start()
    {
        throw new NotImplementedException();
    }

    public void Stop()
    {
        throw new NotImplementedException();
    }
}

public class Pontoon : IVehicle, IWaterBased, IDoors 
{
    public int Doors { get; set; } = 2;
    public int PassengerCapacity { get; set; }
    public string TransmissionType { get; set; }
    public double EngineVolume { get; set; }
    public double MaxWaterSpeed { get; set; }

    public void Drive()
    {
        Console.WriteLine("The pontoon slowly glides over the waves with the greatest of ease");
    }

    public void Start()
    {
        throw new NotImplementedException();
    }

    public void Stop()
    {
        throw new NotImplementedException();
    }
}

public class PickupTruck : IVehicle, IGroundBased, IWheels, IDoors
{
    public int Doors { get; set; } = 4;
    public int Wheels { get; set; } = 4;
    public int PassengerCapacity { get; set; }
    public string TransmissionType { get; set; } = "Automatic";
    public double EngineVolume { get; set; } = 4.2;
    public double MaxLandSpeed { get; set; } = 160.4;

    public void Drive()
    {
        Console.WriteLine("The truck drives down the highway");
    }

    public void Start()
    {
        Console.WriteLine("The truck is starting");
    }

    public void Stop()
    {
        Console.WriteLine("The truck is stopping");
    }
}

public class Motorcycle : IVehicle, IGroundBased, IWheels
{
    public int Wheels { get; set; } = 2;
    public int PassengerCapacity { get; set; }
    public string TransmissionType { get; set; } = "Manual";
    public double EngineVolume { get; set; } = 1.3;
    public double MaxLandSpeed { get; set; } = 160.4;

    public void Drive()
    {
        Console.WriteLine("The motorcycle screams down the highway");
    }

    public void Start()
    {
        Console.WriteLine("The motorcycle is starting");
    }

    public void Stop()
    {
        Console.WriteLine("The motorcycle is stopping");
    }
}

public class Blimp : IVehicle, IAirBased, IWheels, IDoors
{
  public int Wheels { get; set; } = 4;
  public int Doors { get; set; } = 4;
  public int PassengerCapacity { get; set; } = 200;
  public string TransmissionType { get; set; } = "None";
  public double EngineVolume { get; set; } = 31.1;
  public double MaxAirSpeed { get; set; } = 100.0;

  public void Fly()
  {
    Console.WriteLine("The Blimp is flying");
  }

  public void Drive()
  {
      Console.WriteLine("Getting ready for takeoff");
  }

  public void Start()
  {
    Console.WriteLine("The Blimp is STARTING");
  }
  

  public void Stop()
  {
    Console.WriteLine("The Blimp is STOPPING"); 
  }
}


public class Cessna : IVehicle, IAirBased, IWheels, IDoors, IWings
{
  public int Wheels { get; set; } = 3;
  public int Doors { get; set; } = 3;
  public int PassengerCapacity { get; set; } = 113;
  public bool Winged { get; set; } = true;
  public string TransmissionType { get; set; } = "None";
  public double EngineVolume { get; set; } = 31.1;
  public double MaxAirSpeed { get; set; } = 309.0;

  public void Fly()
  {
    Console.WriteLine("The Cessna effortlessly glides through the clouds like a gleaming god of the Sun");
  }
  public void Drive()
  {
      Console.WriteLine("Getting ready for takeoff");
  }

  public void Start()
  {
    Console.WriteLine("The Cessna is STARTING");
  }

  public void Stop()
  {
    Console.WriteLine("The Cessna is STOPPING"); 
  }
}


public class Program
{

    public static void Main() {

        // Build a collection of all vehicles that fly

        // With a single `foreach`, have each vehicle Fly()

        Blimp blimp1 = new Blimp();
        Cessna cessna1 = new Cessna();

        List<IAirBased> thingsThatFly = new List<IAirBased>();
        thingsThatFly.Add(blimp1);
        thingsThatFly.Add(cessna1);

        foreach (IAirBased thing in thingsThatFly)
        {
            thing.Fly();
        }

        // Build a collection of all vehicles that operate on roads

        // With a single `foreach`, have each road vehicle Drive()
        Motorcycle motorcycle1 = new Motorcycle();
        PickupTruck truck1 = new PickupTruck();

        List<IVehicle> thingsOnRoad = new List<IVehicle>();
        thingsOnRoad.Add(motorcycle1);
        thingsOnRoad.Add(truck1);

        foreach (IVehicle thing in thingsOnRoad)
        {
            thing.Drive();
        }


        // Build a collection of all vehicles that operate on water
        
        // With a single `foreach`, have each water vehicle Drive()
        JetSki jet1 = new JetSki();
        Pontoon pon1 = new Pontoon();

        List<IVehicle> thingsOnWater = new List<IVehicle>();
        thingsOnWater.Add(jet1);
        thingsOnWater.Add(pon1);

        foreach (IVehicle thing in thingsOnWater)
        {
            thing.Drive();
        }
    }

}