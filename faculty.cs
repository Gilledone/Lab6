using System;

class Faculty: Person{

        public string Id { get; set; }
        public string Title { get; set; }
        public DateTime DateOfEmployment { get; set; }
        public string SocialSecurity { get; set; }
        public string Employer { get; set; }
        public decimal YearlySalary { get; set; }
        public bool Tenured { get; set; }

  public Faculty() : base()
  {
    Console.WriteLine("Faculty constructor");
    Title = "Instructor";
  }


  public Faculty(string fname, string lname) : base(fname, lname)
  {
    Console.WriteLine("Faculty constructor 2args");
    Title = "Instructor";
  }

  public bool GrantTenure() 
  {
    var FiveYearsAgo = DateTime.Now.AddYears(-5);
    if (DateTime.Compare(DateOfEmployment, FiveYearsAgo)<0){
      Tenured = true;
    }else{
      Tenured = false;
    }
    return Tenured;
    }

public bool Promote()
{
  if (Title == "Instructor"){
    Console.WriteLine("is instructor");
      var TwoYearsAgo = DateTime.Now.AddYears(-2);
      if (DateTime.Compare(DateOfEmployment,  TwoYearsAgo)<0){
        Title = "Assistant Professor";
        Console.WriteLine("Faculty promoted to Assistant Professor rank");
        return true;
      }else{
        Console.WriteLine("No promotion");      
    }
  }
  else if (Title == "Assistant Professor")
  {
    Console.WriteLine("is assistant Professor");
    var FiveYearsAgo = DateTime.Now.AddYears(-5);
    if (DateTime.Compare(DateOfEmployment, FiveYearsAgo)<0){
      Title = "Associate Professor";
      Console.WriteLine("Faculty promoted to Associate Professor rank");
      return true;
    }else{
      Console.WriteLine("No promotion");
    }
  }
  else if (Title == "Associate Professor")
  {
    Console.WriteLine("is associate professor");
    var TenYearsAgo = DateTime.Now.AddYears(-10);
    if (DateTime.Compare(DateOfEmployment, TenYearsAgo)<0){
      Title = "Professor";
      Console.WriteLine("Faculty promoted to Professor rank");
      return true;
    }else{
      Console.WriteLine("No promotion");
    }
    }else if (Title == "Professor")
    {
      Console.WriteLine("Is Professor");
      Console.WriteLine("No more promotions");
    }
  

  return false;      
  }
public override void Intro(){
  base.Intro();
Console.WriteLine($"I work as {Title} at {Employer} since {DateOfEmployment.Year}" );
}
}

  