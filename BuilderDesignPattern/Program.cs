// See https://aka.ms/new-console-template for more information
// Initialize Director
using BuilderDesignPattern;

var director = new Director();

// Build a Car
var carBuilder = new CarBuilder();
director.SetBuilder(carBuilder);
Toy car = director.ConstructToy();
car.ShowDetails();

Console.WriteLine();

// Build a Bike
var bikeBuilder = new BikeBuilder();
director.SetBuilder(bikeBuilder);
Toy bike = director.ConstructToy();
bike.ShowDetails();
