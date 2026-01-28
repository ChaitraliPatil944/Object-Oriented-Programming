class Vehicle {
  start() {
    throw new Error("start() must be implemented"); // abstract method
  }
}

class Car extends Vehicle {
  start() {
    console.log("Car starts with key");
  }
}
class Bike extends Vehicle {
  start() {
    console.log("Bike starts with button");
  }
}

//Abstraction is the process of hiding implementation details and showing only essential features to the user