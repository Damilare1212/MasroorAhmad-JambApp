using System;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace JambApp.Entities
{
    public class StudentSubject
    {
        public int ID {get;set;}
        public string SubjectName {get;set;}
        public int StudentID  {get;set;}

        public Subject subject {get;set;}
        public Student student {get;set;}

    }
}