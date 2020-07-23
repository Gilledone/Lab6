using System;
using System.Diagnostics;

class MainClass {
  public static void Main (string[] args) {

     Console.WriteLine("Testing Faculty no args");
    Faculty faculty = new Faculty();   
    
    Console.WriteLine(faculty.Id);  
    
    Console.WriteLine(faculty.Title);  

    Console.WriteLine(faculty.DateOfEmployment); 
    
    Console.WriteLine(faculty.Employer);  
    
    Console.WriteLine(faculty.YearlySalary);

    Console.WriteLine(faculty.Tenured); 

    Console.WriteLine("Testing Faculty 2 args");
    Faculty faculty1 = new Faculty("Andrew", "Peggman");   
    
    Console.WriteLine(faculty1.Id);  
    
    Console.WriteLine(faculty1.Title);

    Console.WriteLine(faculty1.DateOfEmployment); 
    
    Console.WriteLine(faculty1.Employer);  
    
    Console.WriteLine(faculty1.YearlySalary);

    Console.WriteLine(faculty1.Tenured); 

    faculty1.DateOfEmployment = new DateTime(2009, 8, 1, 0, 0, 0);

    faculty1.GrantTenure();

  }
}