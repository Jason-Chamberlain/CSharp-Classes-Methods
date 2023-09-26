# Enum Parsing
This README presents an overview of a C# .NET solution that focuses on the application of the concept of parsing enumerations (enums). The solution demonstrates how enums are defined and utilized in C# to represent a set of named constant values. Below, the key concepts and skills that were acquired through the creation of this solution are explored.

## Solution Overview
### Enum Definition and Parsing
In this C# .NET solution, an enumeration named `DayOfWeek` is defined and utilized to showcase the parsing of user input into enum values. The solution includes the following components:

1. **"DayOfWeek" Enum**: An enumeration named `DayOfWeek` is defined, containing named constants representing days of the week, from "Monday" to "Sunday."

1. **"Program" Class**: The `Program` class contains the `Main` method, which demonstrates the parsing of user input into enum values. A `try-catch` block is employed to handle exceptions, specifically `ArgumentException`.

1. **User Input and Parsing**: The user is prompted to enter a day of the week as a string. The program attempts to parse the input string into a `DayOfWeek` enum value using the `Enum.Parse` method.

1. **Exception Handling**: In case the user enters an invalid or non-existent day of the week, the program catches the `ArgumentException` and displays an error message.

## Key Concepts Learned
### 1. Enumerations (Enums)
- **Enum Definition**: Understanding was gained regarding how enumerations are defined in C# to represent a set of named constant values. Enumerations are useful for defining and working with specific sets of related values.

- **Enum Usage**: The usage of enums to enhance code readability and maintainability by providing meaningful names for constant values was learned.

### 2. Parsing Enums
- **Enum Parsing**: The solution demonstrates how a string input is parsed into an enum value using the `Enum.Parse` method. This technique allows for user-friendly input and conversion into enum values.

- **Exception Handling**: Knowledge was acquired about how to utilize exception handling, specifically catching `ArgumentException`, to handle cases where the input string does not match any enum value.

## Conclusion
This C# .NET solution provides a practical demonstration of key concepts related to enum definition and parsing. It illustrates how enums can be used to represent named constant values and how user input can be parsed into enum values. Understanding these concepts is valuable for creating code that is both more readable and user-friendly, particularly when dealing with predefined sets of related values.