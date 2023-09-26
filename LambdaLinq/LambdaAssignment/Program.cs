using System;
using System.Collections.Generic;
using System.Linq; 

namespace LambdaAssignment 
{
    class Program 
    {
        static void Main(string[] args) 
        {
            // Create a list of Employee objects, each with different properties.
            List<Employee> employees = new List<Employee>
            {
                new Employee { Id = 1, FirstName = "Joe", LastName = "Smith" },
                new Employee { Id = 2, FirstName = "John", LastName = "Doe" },
                new Employee { Id = 3, FirstName = "Jane", LastName = "Johnson" },
                new Employee { Id = 4, FirstName = "Jake", LastName = "Brown" },
                new Employee { Id = 5, FirstName = "Joe", LastName = "Williams" },
                new Employee { Id = 6, FirstName = "Sarah", LastName = "Miller" },
                new Employee { Id = 7, FirstName = "Emily", LastName = "Taylor" },
                new Employee { Id = 8, FirstName = "Mike", LastName = "Jones" },
                new Employee { Id = 9, FirstName = "Daniel", LastName = "Davis" },
                new Employee { Id = 10, FirstName = "Joe", LastName = "Wilson" }
            };

            List<Employee> joesForeach = new List<Employee>();
            
            // Loop through each employee using a foreach loop.
            foreach (Employee employee in employees) 
            {
                if (employee.FirstName == "Joe")            // Check if the employee's first name is "Joe".
                {
                    joesForeach.Add(employee);              // Add the employee to the joesForeach list.
                }
            }

            // Use LINQ's Where method with a lambda expression to filter employees named "Joe".
            List<Employee> joesLambda = employees.Where(employee => employee.FirstName == "Joe").ToList();

            // Use LINQ's Where method with a lambda expression to filter employees with Id greater than 5.
            List<Employee> idGreaterThan5 = employees.Where(employee => employee.Id > 5).ToList();

            Console.ReadLine(); 
        }
    }
    
    // Define a class named "Employee".
    public class Employee 
    {
        public int Id { get; set; }                     // Declare a property to store the employee's ID.
        public string FirstName { get; set; }           // Declare a property to store the employee's first name.
        public string LastName { get; set; }            // Declare a property to store the employee's last name.
    }
}