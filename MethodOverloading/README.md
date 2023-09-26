# Method Overloading
This README provides an overview of a C# .NET solution that focuses on the application of the concept of method overloading. The solution demonstrates how method overloading allows the creation of multiple methods with the same name but different parameter types or counts. Below, the key concepts and skills that were acquired through the creation of this solution are explored.

## Solution Overview
### Method Overloading Utilization
In this C# .NET solution, a console application was created to illustrate the concept of method overloading within the context of a `MyMath` class. The solution encompasses the following components:

1. **MyMath Class**: A class named `MyMath` was defined, including three overloaded `Square` methods. Each version of the `Square` method accepts a different parameter type: `int`, `decimal`, and `string`. The methods calculate the `square` of the input and return the results.

1. **Program Class**: The `Program` class contains the `Main` method, where instances of the `MyMath` class are created. The program initializes parameters of various data types: `int`, `decimal`, and `string`. It then calls the `Square` method with these different data types as arguments and displays the results.

## Key Concepts Learned
### 1. Method Overloading
**Method Overloading Definition**: Understanding was gained regarding how to define multiple methods with the same name but different parameter types or counts. This enables the creation of versatile methods that can handle various input data types.

**Method Selection**: The course covered how C# determines which overloaded method to invoke based on the argument types provided when calling the method.

**Parameter Type Flexibility**: Method overloading allows for flexibility in accepting different data types as arguments, making code more adaptable to various input scenarios.

### 2. Data Type Conversion
**Data Type Conversion**: The solution demonstrates the conversion of data types using methods like `Convert.ToInt32`. Knowledge was acquired about how to convert between different data types to ensure compatibility with method parameters.

## Conclusion
This C# .NET solution provides a practical demonstration of the key concept of method overloading. It illustrates how method overloading allows for the creation of versatile methods capable of accepting different data types as arguments. Understanding this concept is essential for designing flexible and reusable code, particularly when dealing with methods that perform similar operations on various data types.