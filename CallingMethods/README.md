# Calling Methods
This README presents an overview of a C# .NET solution that focuses on the concept of calling methods and handling exceptions. The solution demonstrates how methods are created and called in C# and how exceptions are managed gracefully. Below, the key concepts and skills that were acquired through the creation of this solution are explored.
## Solution Overview
### Method Calling
In this C# .NET solution, a console application is used to showcase the creation and calling of methods. The solution includes the following components:

1. **MyMath Class**: Three public methods, namely `Add`, `Subtract`, and `Multiply`, are defined in the `MyMath` class. Each method takes an integer parameter, performs a specific mathematical operation, and returns the result.

1. **Program Class**: The `Program` class houses the `Main` method, which demonstrates the creation of an instance of the `MyMath` class, the retrieval of user input, method invocation, and result display.

1. **User Input**: Users are prompted to enter an integer, which is subsequently utilized as a parameter for the mathematical operations.

1. **Exception Handling**: The solution employs try-catch blocks to manage exceptions. Specifically, a `FormatException` is handled by a catch block when user input cannot be converted to an integer, while a generic `Exception` catch block addresses other types of exceptions.

## Key Concepts Learned
### 1. Method Creation and Invocation
- **Method Declaration**: The course covered the creation and definition of public methods in C# classes. Each method in the `MyMath` class carries out a specific mathematical operation and returns a result.

- **Method Invocation**: Understanding was acquired regarding the process of creating an instance of a class and invoking its methods. In this solution, methods such as `Add`, `Subtract`, and `Multiply` are invoked on an instance of the `MyMath` class.

### 2. Exception Handling
- **Try-Catch Blocks**: Knowledge was gained on how to employ try-catch blocks to gracefully manage potential exceptions. The try block permits the execution of code segments that might give rise to exceptions, while catch blocks are responsible for handling exceptions when they occur.

- **Specific Exception Handling**: The course emphasized the identification and handling of specific types of exceptions, including `FormatException`, which arises when users input non-integer values.

- **Generic Exception Handling**: The solution includes a catch block featuring a generic `Exception` type for the capture and management of unexpected exceptions, ensuring the program's stability.

## Conclusion
This C# .NET solution provides a practical demonstration of key concepts related to method creation, method invocation, and exception handling. It illustrates how methods can be defined in C# classes to execute specific tasks and how user input can serve as method parameters. Additionally, it underscores the significance of handling exceptions gracefully to maintain program stability, especially when dealing with user inputs that may not adhere to expected formats. A comprehensive understanding of these concepts is fundamental for the development of reliable and robust C# applications.