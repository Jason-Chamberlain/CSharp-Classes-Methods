# Inheritance
This README presents an overview of a C# .NET solution that focuses on the application of the concept of inheritance. The solution includes practical examples and code that illustrate key concepts and skills acquired during the course.

## Solution Overview
### Inheritance and Class Hierarchy
In this C# .NET solution, a console application was created to demonstrate the concept of inheritance through the use of classes. Specifically, the following aspects are covered:

1. **Class Definition**: Two classes, namely `Person` and `Employee`, are defined.

1. **Property Declaration**: Properties for `FirstName` and `LastName` are defined within the `Person` class.

1. **Method Declaration**: The `Person` class also defines a method called `SayName`, used to print a person's full name.

1. **Inheritance**: The `Employee` class inherits from the `Person` class, establishing an inheritance relationship between the two.

1. **Property Addition**: A new property, `Id`, is introduced within the `Employee` class, a feature that is not present in the `Person` class.

1. **Method Invocation**: The `Main` method creates an instance of the `Employee` class, sets its `FirstName` and `LastName` properties, and invokes the `SayName` method to display the full name.

## Key Concepts Learned
### 1. Inheritance
- **Base and Derived Classes**: The concept of inheritance was learned, where one class (the derived class) can inherit properties and methods from another class (the base class). In this solution, `Employee` serves as the derived class, while `Person` is the base class.

- **Extending Functionality**: Understanding was gained regarding how inheritance enables the extension of functionality of base classes within derived classes. For instance, the `Employee` class adds the `Id` property while inheriting the `FirstName` and `LastName` properties, along with the `SayName` method, from the `Person` class.

### 2. Class Hierarchy
- **Creating Class Hierarchies**: This project demonstrated how to create class hierarchies, in which classes are organized in a parent-child relationship. In this instance, `Employee` is a specialized class that inherits from the more general `Person` class.
### 3. Property and Method Utilization
- **Declaring Properties and Methods**: Knowledge was gained about how to declare properties and methods within classes, providing a structured and organized manner to encapsulate data and behavior.

- **Method Invocation**: The solution illustrates how to create instances of classes and how to invoke methods on those instances.

## Conclusion
This C# .NET solution provides a practical demonstration of the concept of inheritance and class hierarchy. It illustrates how classes can be organized in a hierarchical structure, inheriting properties and methods from base classes, while also extending functionality as needed. Understanding inheritance is crucial for creating efficient and organized code in C# .NET, as it promotes code reuse and maintainability.