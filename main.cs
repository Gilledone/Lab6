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
Console.WriteLine("Checking tenure");


    faculty1.DateOfEmployment = new DateTime(2015, 7, 22, 0, 0, 0);
    faculty1.GrantTenure();
    Console.WriteLine(faculty1.Tenured);
        faculty1.DateOfEmployment = new DateTime(2020, 7, 22, 0, 0, 0);

    faculty1.GrantTenure();
    Console.WriteLine(faculty1.Tenured);

    faculty1.Title = "Instructor";
    faculty1.DateOfEmployment = new DateTime(2017, 7, 22, 0, 0, 0);

    faculty1.Promote();
    Console.WriteLine(faculty1.Title);
Console.WriteLine("-----------------");
    faculty1.Title = "Instructor";
    faculty1.DateOfEmployment = new DateTime(2019, 7, 22, 0, 0, 0);

    faculty1.Promote();
    Console.WriteLine(faculty1.Title);
  Console.WriteLine("Test Assistant Professor promotion");

      faculty1.Title = "Assistant Professor";
    faculty1.DateOfEmployment = new DateTime(2014, 7, 22, 0, 0, 0);

    faculty1.Promote();
    Console.WriteLine(faculty1.Title);
Console.WriteLine("-----------------");
    faculty1.Title = "Assistant Professor";
    faculty1.DateOfEmployment = new DateTime(2019, 7, 22, 0, 0, 0);

    faculty1.Promote();
    Console.WriteLine(faculty1.Title);
Console.WriteLine("-------------");
    faculty1.Title = "Associate Professor";
    faculty1.DateOfEmployment = new DateTime(2008, 7, 22, 0, 0, 0);

    faculty1.Promote();
    Console.WriteLine(faculty1.Title);

  faculty1.Title = "Associate Professor";
    faculty1.DateOfEmployment = new DateTime(2019, 7, 22, 0, 0, 0);

    faculty1.Promote();
    Console.WriteLine(faculty1.Title);
    Console.WriteLine("Testing professor");
    faculty1.Title = "Professor";

    faculty1.Promote();

    faculty1.Title = "Assistant professor";
    faculty1.Employer = "Tri-C";
    faculty1.DateOfEmployment = new DateTime(1997, 1, 1, 0, 0, 0);
    
    faculty1.Intro();

  }
}