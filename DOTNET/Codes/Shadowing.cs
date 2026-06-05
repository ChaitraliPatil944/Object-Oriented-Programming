public class Vehicle{
  public String fuelType;
  int numberOfWheels;

    public Vehicle(String fuelType, int numberOfWheels){
        this.fuelType = fuelType;
        this.numberOfWheels = numberOfWheels;
    }
  public void Drive(){
    Console.WriteLine("The vehicle is driving.");
   
  }

}

public class Car : Vehicle{
  String EngineType;
  int numberOfDoors;

  public Car(String EngineType, int numberofDooers): base("Petrol", 4){
    this.EngineType = EngineType;
    this.numberOfDoors = numberofDooers;
  }

  public new void Drive(){
    Console.WriteLine("The car is driving.");

  }

}
public class SUV : Car{
  String Name;
  String Color;

  public SUV(String Name, String Color) : base("v6", 0){
    this.Name = Name;
    this.Color = Color;
  }

  public new void Drive(){
    Console.WriteLine(base.fuelType); // Accessing the fuelType from the Vehicle class using base keyword
    Console.WriteLine("The SUV is driving.");
    
  }
}
public class MainClass{
  public static void Main(String[] args){
    // Vehicle vehicle = new Vehicle("Petrol", 4);
    // Car car = new Car("V6", 4);
    SUV suv = new SUV("Toyota", "Red");

    //car.Drive(); // Output: The car is driving.
    suv.Drive(); // Output: The SUV is driving.
  }
}