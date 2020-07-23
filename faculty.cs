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
    return true;
  }
}
  