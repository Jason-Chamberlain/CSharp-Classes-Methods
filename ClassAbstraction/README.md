# Class Abstraction
This repository contains a C# .NET solution focusing on the concept of class abstraction and its application. This README delves into the key concepts and skills learned through the creation of this solution.

## Solution Overview
### Abstract Class and Inheritance
The solution comprises a console application that demonstrates the use of an abstract class named `Person` and its derived class, `Employee`. Here's a brief overview of the concepts learned:

1. **Abstract Class (Person)**: An abstract class named `Person` was defined, which serves as a blueprint for creating person-related classes. It includes properties for first name and last name and a virtual method called `SayName`.

1. **Inheritance**: The `Employee` class inherits from the `Person` class, illustrating the principle of inheritance in object-oriented programming (OOP).

1. **Method Override**: The `Employee` class overrides the `SayName` method, providing a unique implementation while also invoking the base class's method.

## Key Concepts Learned
### 1. Abstract Classes
- **Definition**: The course introduced the concept of abstract classes, which cannot be instantiated and are designed to be base classes for other classes.

- **Purpose**: The course conveyed the purpose of abstract classes in defining shared properties and methods among derived classes.

### 2. Inheritance
- **Inheriting Base Properties**: Through this project, comprehension was gained on how derived classes inherit properties and methods from their base (abstract) class.

### 3. Method Override
- **Method Overriding**: The course emphasized the process of overriding methods from the base class in derived classes to supply specialized implementations.

- **Base Class Invocation**: Knowledge was acquired concerning the invocation of overridden methods from the base class within the derived class using the `base` keyword.

## Conclusion
This C# .NET solution serves as a practical illustration of fundamental concepts in object-oriented programming, with a particular emphasis on class abstraction, inheritance, and method override. Through this project, valuable insights were gained into the design of class hierarchies and the creation of specialized implementations in derived classes. These fundamental skills are essential for the development of maintainable and extensible software in C# .NET.