using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the Employee class and set the FirstName and LastName properties.
            Employee employee = new Employee() { FirstName = "Sample", LastName = "Student" };
            employee.SayName();                 // Call the SayName method of the Employee instance.
            Console.ReadLine();                 // Read a line of text from the console.
        }
    }

    public class Person                         // Define a class named "Person".
    {
        public string FirstName { get; set; }   // Declare a property to store the first name.
        public string LastName { get; set; }    // Declare a property to store the last name.

        public void SayName()                   // Define a method to print the person's name.
        {
            Console.WriteLine("Name: {0} {1}", FirstName, LastName); // Display the full name.
        }
    }

    public class Employee : Person              // Define a class named "Employee" that inherits from "Person".
    {
        public int Id { get; set; }             // Declare a property to store the employee's ID.
    }
}