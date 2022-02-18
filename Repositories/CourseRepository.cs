using System.ComponentModel;

using JambApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace JambApp.Repositories
{
    public class CourseRepository
    {
       public readonly    ApplicationContext _context;
        public readonly SchoolRepository schoolRepo;
            private readonly ApplicationContext _Connection;

            public  CourseRepository( ApplicationContext context)
            {
                _context = context;
            }
           
        public CourseRepository(ApplicationContext context,SchoolRepository schoolRepo,ApplicationContext context1)
        {
            _context =  context;
            this.schoolRepo = schoolRepo;
            _Connection = context1;
        }

            public void CreateCourse()
            {
            AdminRepository ad = new AdminRepository(_context);

               Console.WriteLine("enter staffID");
               var id = Console.ReadLine();
               var ck = ad._Connection.admins.Where(b => b.StaffCode == id).SingleOrDefault();
               if (ck != null)
               {
                     Console.WriteLine("enter course name");
                     var name = Console.ReadLine();
                     Console.WriteLine("enter courseID");
                     var course =    int.Parse(Console.ReadLine());
                     var c = new Course()
                     {
                         CourseName = name,
                         CourseID = course,
                     };
                     _context.courses.Add(c);
                     _context.SaveChanges();

               }
               else{
                   Console.WriteLine("invalid ID......only admin can create course");
               }
               
            }

                public void UpdateCourse()
                {
                   Console.WriteLine("Enter the Id of the course you want to update");
                    int id = int.Parse(Console.ReadLine());
                    var s = _context.courses.Find(id);
                    if(s == null)
                    {
                        Console.WriteLine("The subject id you entered does not exist");
                    }
                    else
                    {
                        System.Console.WriteLine("Enter new course name");
                        string name = Console.ReadLine();
                        Console.WriteLine("Enter new CourseID");
                        var iD = int.Parse(Console.ReadLine());

                        s.CourseName = name;
                        s.CourseID = iD;

                        _context.courses.Update(s);
                        _context.SaveChanges();
                    }    
              
                   
                }
                public void GetAllCourse()
                {
                    var courses = _context.courses;
                    foreach (var course in courses)
                    {
                        System.Console.WriteLine($"{course.CourseName}");
                    }
                }
                public void GetCourse()
                {
                    System.Console.WriteLine("Enter the Id of the course you want to get");
                    int Id = int.Parse(Console.ReadLine());
                    var s = _context.courses.Find(Id);
                    Console.WriteLine($"{s.CourseName}\t{s.CourseID}");            
                }


                public void DeleteCourse()
                {
                    Console.WriteLine("Enter the id of the course you want to delete");
                    int id = int.Parse(Console.ReadLine());
                    var s = _context.courses.Find(id);
                    if (s == null)
                    {
                        System.Console.WriteLine("The school with this ID does not exist");
                    }
                    else
                    {
                        _context.courses.Remove(s);
                        _context.SaveChanges();
                    }
                }    

               
    }
}