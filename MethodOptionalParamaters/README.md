# Method Optional Parameters
This README provides an overview of a C# .NET solution created to demonstrate how to define methods with optional parameters and how to use them effectively. Below, we explore the key concepts and skills learned through the creation of this solution.

## Solution Overview
### Method Optional Parameters
This C# .NET solution is a console application that showcases the use of method optional parameters. The solution includes the following components:

1. **MyMath Class**: A class named `MyMath` is defined, which includes a method named `Addition`. This method allows for two integer parameters, `num1` and `num2`, with `num2` set as an optional parameter with a default value of 0.

1. **User Input**: The Main method of the program accepts user input for two integers, `input1` and `input2`. It provides the option for the user to skip entering the second number, in which case it defaults to 0.

1. **Method Calls**: The program calls the `Addition` method from the `MyMath` class multiple times with different sets of parameters: `input1` only, `input1` twice, and both `input1` and `input2`.

1. **Output**: The program displays the results of these method calls, showcasing how method optional parameters can be utilized to simplify method invocation.

## Key Concepts Learned
### 1. Method Optional Parameters
- **Optional Parameter Definition**: Knowledge was gained on how to define optional parameters in C# methods by assigning default values to them. In this case, `num2` is an optional parameter in the `Addition` method with a default value of 0.

- **Simplified Method Invocation**: This project demonstrated how optional parameters simplify method invocation by allowing users to omit arguments when calling the method. The method uses default values when necessary.

- **Enhanced Code Readability**: The use of optional parameters can improve code readability by reducing the number of overloaded methods and simplifying method calls.

### 2. User Input Handling
- **User Input Validation**: The solution includes input validation logic to handle cases where the user might skip entering a second number. This demonstrates techniques for validating and processing user input.

## Conclusion
This C# .NET solution provides a practical demonstration of key concepts related to method optional parameters. It showcases how to define methods with optional parameters and how they simplify method invocation. Understanding this concept is valuable for creating more flexible and readable code, particularly when dealing with methods that have numerous arguments or configurations.