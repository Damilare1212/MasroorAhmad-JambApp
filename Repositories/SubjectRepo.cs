using JambApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;


namespace JambApp.Repositories
{
    public class SubjectRepo
    {
        public readonly ApplicationContext  _cont;
         private readonly ApplicationContext _Connection;
         
         public SubjectRepo(ApplicationContext context)
         {
              _cont = context;
         }
        public SubjectRepo(ApplicationContext context,ApplicationContext context1)
        {
            _cont = context;
            _Connection = context1;
            
            
        }
        public SubjectRepo()
        {
            
        }
        
            
        public void CreateSubject()
        {
            AdminRepository ad = new AdminRepository(_cont);
               Console.WriteLine("enter staffID");
               string id = Console.ReadLine();
               var check = ad._Connection.admins.Where(it => it.StaffCode == id).SingleOrDefault();
               if ( check != null )
                 {

            
                Console.WriteLine("Enter the subject name");
                string name = Console.ReadLine();
                var subject = new Subject()
                {
                    Name = name,
                };
                _cont.subjects.Add(subject);
                _cont.SaveChanges(); 
              //  CreateSubject();
          }
               else{
                  Console.WriteLine($"invalid ID admin with {id } not found\n sorry only admin can register subject");
               }             
        }

        public bool UpdateSubject()
        {
            System.Console.WriteLine("Enter the Id of the subject you want to update");
            int id = int.Parse(Console.ReadLine());
            var s = _cont.subjects.Find(id);
            if(s == null)
            {
                System.Console.WriteLine("The subject id you entered does not exist");
            }
            else
            {
                System.Console.WriteLine("Enter the subject name");
                string name = Console.ReadLine();
                s.Name = name;
                _cont.subjects.Update(s);
                _cont.SaveChanges();
            }  
            return true;          
        }
        public bool GetAllSubject()
        {
            var subjects = _cont.subjects;
            foreach (var subject in subjects)
            {
                System.Console.WriteLine($"{subject.Name}");
            }
            return true;
        }
        public void GetSubject()
        {
            
            System.Console.WriteLine("Enter the Id of the school you wsnt to get");
            int Id = int.Parse(Console.ReadLine());
            var s = _cont.subjects.Find(Id);
            System.Console.WriteLine($"{s.Name}");            
        }
        public void DeleteSubject()
        {
            System.Console.WriteLine("Enter the id of the subject you want to delete");
            int id = int.Parse(Console.ReadLine());
            var s = _cont.subjects.Find(id);
            if (s == null)
            {
                System.Console.WriteLine("The school with this ID does not exist");
            }
            else
            {
                _cont.subjects.Remove(s);
                _cont.SaveChanges();
            }
        }
    }
}