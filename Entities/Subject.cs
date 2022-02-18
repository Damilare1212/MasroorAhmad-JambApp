using System.Collections.Generic;

namespace JambApp.Entities
{
    public class Subject
    {
        public int ID {get;set;}
        public string Name {get;set;}

       List<StudentSubject> CourseSubject {get;set;} = new List<StudentSubject>();
    }
}