using System;

namespace InterfaceAbstractAssignment
{   
    class Program
    {
        static void Main(string[] args)
        {  
            // Use polymorphism to create an object of type IQuittable            
            IQuittable quittableEmployee = new Employee { FirstName = "Sample", LastName = "Student" };
            // Call the Quit method on the quittableEmployee object            
            quittableEmployee.Quit();                     
            Console.ReadLine();
        }
    } 
    
    // Create an interface called IQuittable
    interface IQuittable                                    
    {
        void Quit();
    }
    
    // Create an abstract class called Person
    abstract class Person                                   
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual void SayName()
        {
            Console.WriteLine($"Name: {FirstName} {LastName}");
        }
    }

    // Create a class called Employee that inherits from Person and implements IQuittable
    class Employee : Person, IQuittable         
    {
        public override void SayName()
        {
            Console.WriteLine("Employee");
            base.SayName();
        }

        // Implement the Quit method from the IQuittable interface        
        public void Quit()                      
        {
            Console.WriteLine($"{FirstName} {LastName} has quit.");
        }
    }    
}