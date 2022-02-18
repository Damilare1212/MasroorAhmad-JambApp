using System;
using System.Collections.Generic;

namespace JambApp.Entities
{
    public class Center{
        public int ID {get;set;}
        public string Name {get;set;}
        public string Adderess {get;set;}
        List<Student> students {get;set;} = new List<Student>();
        
    }
 
}