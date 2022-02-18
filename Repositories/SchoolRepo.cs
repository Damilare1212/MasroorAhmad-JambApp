using JambApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using JambApp.Repositories;

namespace JambApp.Repositories
{    
    public class SchoolRepository
    {
        public readonly ApplicationContext _connector;
           private readonly ApplicationContext _Connection;
        
        public  SchoolRepository(ApplicationContext context)
        {
            _connector = context;
        }
        public SchoolRepository(ApplicationContext context, ApplicationContext context1)
        {
            _connector = context;
            _Connection = context1;
        }

          public SchoolRepository()
          {
              
          }
        public void CreateSchool()
        {
            AdminRepository ad = new AdminRepository(_connector);
           Console.WriteLine("Enter staffid");
           string id = Console.ReadLine();
           var check = ad._Connection.admins.Where(item => item.StaffCode == id).SingleOrDefault();
           if (check != null)
           {

            
                Console.WriteLine("Enter the School name");
                var name = Console.ReadLine();
                Console.WriteLine("Enter the Address of the School");
                var address = Console.ReadLine(); 
                var school = new School()
                {
                    Name = name,
                   Adderess  = address,
                };
                _connector.schools.Add(school);
                _connector.SaveChanges(); 
            }               
            else{
                Console.WriteLine($"admin with {id} not found\nonly admin can create school");
            }
        }
        public bool UpdateSchool()
        {
            Console.WriteLine("Enter the the id of the school you want to update");
            var id = int.Parse(Console.ReadLine());
            var school = _connector.schools.Find(id);
            if (school == null)
            {
                Console.WriteLine("The school with this ID does not exist");
            } 
            else
            {
                System.Console.WriteLine("Enter the name of the school");
                var name = Console.ReadLine();                
                System.Console.WriteLine("Enter the Address of the school");
                var address = Console.ReadLine();
                school.Name = name;           
                school.Adderess = address;
                 _connector.schools.Update(school);
                _connector.SaveChanges();         
            } 
            return true;          
        }
        public bool GetAllSchools()
        {
            var schools = _connector.schools;
            foreach (var school in schools)
            {
                Console.WriteLine($"{school.Name}\t{school.Adderess}");
            }
            return true;
        }
        public void GetSchool()
        {
            System.Console.WriteLine("Enter the Id of the school you wsnt to get");
            int Id = int.Parse(Console.ReadLine());
            var s = _connector.schools.Find(Id);
            Console.WriteLine($"{s.Name}\t{s.Adderess}");            
        }
        public void DeleteSchool()
        {
            Console.WriteLine("Enter the id of the school you want to delete");
            int id = int.Parse(Console.ReadLine());
            var s = _connector.schools.Find(id);
            if (s == null)
            {
                System.Console.WriteLine("The school with this ID does not exist");
            }
            else
            {
                _connector.schools.Remove(s);
                _connector.SaveChanges();
            }
        }    

    }
}