using System;
using System.Collections.Generic;

namespace JambApp.Entities
{
    public  class Student : Person
    {
        public int PofileCode {get;  set;}
        public int UtmePin {get;  set;}
        public string SchoolFirstChioce {get;set;}
        public string SchoolSecondChoice {get;set;}
        public string  SchoolThirdchoice {get;set;}
        public string CourseFirstChioce {get;set;}
        public string CourseSecondChoice {get;set;}
        public string  CourseThirdchoice {get;set;}
        public string CenterNAme {get;set;}
        public string ExamDate {get; set;}
      
           public Center center {get;set;}
        
        
       public virtual List<StudentSubject> CourseSubject { get; set; } = new List<StudentSubject>();

       
    }
}