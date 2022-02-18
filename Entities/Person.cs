using System;

namespace JambApp.Entities
{
    public abstract class Person
    {
      public int ID {get;set;}
      public string FirstName {get; set; }
        public string Surname {get; set;}
        public string Email {get; set ; }
        public string PhoneNumber {get; set; }
        public string Address {get; set; }
        public DateTime  DateOFBirth {get;set;}
        public Gender Gender {get;set;}
        public int Age  {get;set;}
       
            

          
    }
}