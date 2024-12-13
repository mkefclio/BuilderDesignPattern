# Builder Design Pattern - Toy Builder Console App
Welcome to the **Builder Design Pattern** example! This project demonstrates the implementation of the Builder Design Pattern in .NET Core with a simple and easy-to-understand example.

## **Overview**
This console application shows how the Builder Design Pattern can be used to construct different types of toys, such as Cars and Bikes, in a step-by-step manner. 

The purpose of this project is to provide a straightforward explanation of the Builder Design Pattern, making it accessible to developers at all levels.

I have also explained this pattern in more detail in my LinkedIn article: **[Let's Play With: Design Patterns - Builder Design Pattern](#)**. *(https://www.linkedin.com/pulse/lets-play-design-patterns-manos-kefalas-a4zif/)*

This project was created by **Manos Kefalas** to help developers learn and apply the Builder Design Pattern effectively.

## **How It Works**
The project is divided into the following components:
1. **Product (`Toy`)**: Represents the final toy being built.
2. **Builder Interface (`IToyBuilder`)**: Defines the steps required to build a toy.
3. **Concrete Builders (`CarBuilder`, `BikeBuilder`)**: Implement the specific building steps for each type of toy.
4. **Director (`Director`)**: Orchestrates the building process by instructing the builder on the steps to follow.

## **Code Structure**

### Step 1: Define the Product (`Toy`)
The `Toy` class represents the product, with methods to add parts and display details.

### Step 2: Create the Builder Interface (`IToyBuilder`)
Defines the methods that all builders must implement.

### Step 3: Implement Concrete Builders
- `CarBuilder`: Builds a toy car.
- `BikeBuilder`: Builds a toy bike.

### Step 4: Create the Director (`Director`)
Coordinates the construction process using the builder interface.

### Step 5: Use the Builder in the Program
The `Program` class demonstrates how to use the Director and Builders to create toys.

## **Getting Started**

### Prerequisites
- .NET Core SDK installed on your system.
- A code editor like Visual Studio.

### Run the Application
1. Clone the repository.
   git clone https://github.com/your-username/BuilderDesignPattern.git
   cd BuilderDesignPattern
   
2. Build and run the project using the .NET CLI or Visual Studio.
   dotnet run
   
### Expected Output
Toy Type: Car
Parts:
 - 4 Wheels
 - Car Body
 - Car Seat

Toy Type: Bike
Parts:
 - 2 Wheels
 - Bike Frame
 - Bike Seat

## **Explanation**

### Key Components
- **Product (`Toy`)**: Represents the final toy.
- **Builder (`IToyBuilder`)**: Outlines the steps to construct a toy.
- **Concrete Builders (`CarBuilder`, `BikeBuilder`)**: Provide specific implementations for different toys.
- **Director (`Director`)**: Manages the construction process.

This structure adheres to the Builder Design Pattern, ensuring flexibility and modularity.

## **Article Link**
Read my detailed article on LinkedIn: **[Let's Play With: Design Patterns - Builder Design Pattern](#)** *(https://www.linkedin.com/pulse/lets-play-design-patterns-manos-kefalas-a4zif/)*.

## **About the Author**
This project was created by **Manos Kefalas** as part of the series **"Let's Play With: Design Patterns"**, aiming to provide practical examples for developers to learn and apply design patterns effectively.

**Connect with me on LinkedIn:** [Manos Kefalas](https://www.linkedin.com/in/manos-kefalas-96b1a3121/)

## **License**
This project is licensed under the MIT License. Feel free to use and modify it for learning or other purposes.

Happy coding! 🎉
