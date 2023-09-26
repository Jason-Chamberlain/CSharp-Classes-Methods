using System;

namespace ClassAbstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the Employee class and set the firstName and lastName properties.
            Employee employee = new Employee() { firstName = "Sample", lastName = "Student" };
            employee.SayName();                 // Call the SayName method of the Employee instance.
            Console.ReadLine();                 // Read a line of text from the console.
        }
    }

    public abstract class Person                // Define an abstract class named "Person".
    {
        public string firstName { get; set; }   // Declare a property to store the first name.
        public string lastName { get; set; }    // Declare a property to store the last name.

        public virtual void SayName()           // Define a virtual method to print the person's name.
        {
            Console.WriteLine("Name: {0} {1}", firstName, lastName); // Display the full name.
        }
    }

    public class Employee : Person              // Define a class named "Employee" that inherits from "Person".
    {
        public override void SayName()          // Override the SayName method in the Employee class.
        {
            Console.WriteLine("Employee");      // Print "Employee".
            base.SayName();                     // Call the base class's SayName method.
        }
    }
}