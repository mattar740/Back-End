﻿using System;

public interface IPerson
{
    string FirstName { get; set; }
    string LastName { get; set; }

    void Introduce();

    void Print();

    string To_String();

}

public interface ICommunicate
{
   
    void CallPhone();

    void SendEmail(string Title, string Body);

    void SendSMS(string Title, string Body);

    void SendFax(string Title, string Body);

}

public abstract class Person : IPerson, ICommunicate

{

    public string FirstName { get; set; }
    public string LastName { get; set; }

    public abstract void Introduce();

    public void SayGoodbye()
    {
        Console.WriteLine("Goodbye!");
    }

    public void Print()
    {
        Console.WriteLine("Hi I'm the print method");
    }

    public string To_String()
    {
        return "Hi this is the complete string....";

    }

    public void CallPhone()
    {
        Console.WriteLine("Calling Phone... :-)");

    }

    public void SendEmail(string Title, string Body)
    {
        Console.WriteLine("Email Sent :-)");

    }

    public void SendSMS(string Title, string Body)
    {
        Console.WriteLine("SMS Sent :-)");

    }

    public void SendFax(string Title, string Body)
    {
        Console.WriteLine("Fax Sent :-)");

    }

}

public class Employee : Person
{
    public int EmployeeId { get; set; }

    public override void Introduce()
    {
        Console.WriteLine($"Hi, my name is {FirstName} {LastName}, and my employee ID is {EmployeeId}.");
    }
}

public class Program
{
    public static void Main()
    {
        //You cannot create an object of an Interface, you can only Implement it.
       // IPerson Person1 = new IPerson();

        Employee employee = new Employee();
        employee.FirstName = "Mahmoud";
        employee.LastName = "Mattar";
        employee.EmployeeId = 123;
        employee.Introduce(); // Output: "Hi, my name is Mahmoud Mattar, and my employee ID is 123."
        employee.SayGoodbye(); // Output: "Goodbye!"
        employee.Print();
        employee.CallPhone();
        employee.SendEmail("hi","Body");
        employee.SendSMS("hi", "Body");
        employee.SendFax("hi", "Body");


        Console.ReadKey();

    }
}

   
// implementing multiple interfaces عن طريق multiple inheritance  هتلاقي مواقع كتير بتقول ان احنا نقدر نحقق ال multiple inheritance  مبتدعمش ال  c sharp ال 
// inheritance  وده غلط انت محققتش 
// الوراثة يعني الدرايفد كلاس يورث كل البيهيفيور والفيلدس الي في البيز كلاس 

// In C#, there's no direct support for something called "Multiple Inheritance." This means a class can't inherit from more than one class. However, there's a concept called "Implementing Interfaces" that is often used to achieve something similar.

// When we talk about inheritance, it means a child class inherits all the behaviors and properties of its parent class. However, with implementing interfaces, it's not exactly the same thing.

// When a class implements multiple interfaces, it means that class agrees to provide specific behaviors defined by those interfaces. It's like signing a contract – the class promises to have certain functionalities. But, keep in mind, this is not exactly the same as inheriting everything from another class.

// So, while implementing interfaces can give a class access to behaviors declared in those interfaces, it's not the same as the full-fledged inheritance you might expect.
