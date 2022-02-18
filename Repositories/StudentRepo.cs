
using System.Runtime.CompilerServices;
using System.Data;
using JambApp.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using JambApp.Repositories;


namespace JambApp.Repositories

{
    public class StudentRepository
    {
      public  StudentRepository(ApplicationContext context)
      {
         _connect = context;
      }
        public readonly ApplicationContext _connect;
         public readonly SubjectRepo subjectRepo;
        public readonly  SchoolRepository schoolrepo;
          public readonly ApplicationContext  _cont;
          private readonly ApplicationContext _Connection;
           
         public readonly SchoolRepository   _connector;
         public readonly ApplicationContext _context;
         public readonly CenterRepository centerRepo;
         public readonly CourseRepository courseRepo;
        public StudentRepository(ApplicationContext context,ApplicationContext context4,ApplicationContext context3,ApplicationContext context2 ,SubjectRepo subjectRepo,SchoolRepository schoolRepo,CenterRepository centerRepo,CourseRepository courseRepo,ApplicationContext context1)
        {
           _context = context3;
            _connect = context;
         this.subjectRepo = subjectRepo;
          this. schoolrepo = schoolRepo;
          this.centerRepo = centerRepo;
          this.courseRepo = courseRepo;
          _cont = context1;
          _Connection = context2;
         // _connector = context4
          
          


        }
        public StudentRepository()
        {
          
        }
             
              // public  void StudentRegistration()
              // {
                
              
              //       Console.WriteLine("Enter Firstname");
              //     string name = Console.ReadLine();
              //     Console.WriteLine("enter Lastname");
              //     string lastname = Console.ReadLine();
              //     Console.WriteLine("enter phoneNumber");
              //     string phone = Console.ReadLine();
              //     Console.WriteLine("enter Email");
              //     string MAil = Console.ReadLine();
              //     Console.WriteLine("enter Address");
              //     string adderss = Console.ReadLine();
              //     Console.WriteLine("enter Age");
              //     int age = int.Parse(Console.ReadLine());
              //     Console.WriteLine("enter your gender");
              //     Console.WriteLine("1 for male\n2 for female\n3for Rather not Specify");
              //     var Response = (Gender)int.Parse(Console.ReadLine());
              //     Console.WriteLine("enter DateOfBirth//// year/month/day");
              //     var response= DateTime.Parse(Console.ReadLine());
              //      var profile = GeneratePRofileCode();
              //     var utme = GenerateUtmepin();
              //      var student = new Student()
              //      {
              //         FirstName = name,
              //         Surname = lastname,
              //         PhoneNumber = phone,
              //         Email = MAil,
              //         Address = adderss,
              //         Age = age,
              //         Gender = Response,
              //         DateOFBirth = response,
              //        PofileCode = profile,
              //        UtmePin = utme,

                    
              //      };
              //        Console.WriteLine($" dear {name} {lastname} your ProfileCode is {GeneratePRofileCode()}");
              //       Console.WriteLine($"  dear {name} {lastname} your UTMEPIN is {GeneratePRofileCode()}"); 
              //       _connect.students.Add(student);
              //       _connect.SaveChanges();
              //       StudentRegistration(); 
              
              // }

        public int GeneratePRofileCode()
        {
            Random rmd = new Random();
            
          return rmd.Next(100,5000);
            
        }

        
        public int GenerateUtmepin()
        {
            Random rmd = new Random();
            
          return rmd.Next(1000,50000);
        }  

      public void JambREgistration()
      {
           AdminRepository add = new AdminRepository(_connect);
          Console.WriteLine("enter your staffID");
          string id = Console.ReadLine();
         var ck = add._Connection.admins.Where(b => b.StaffCode == id).SingleOrDefault();
          // var checks = add._cont.admins.Where(b => b.StaffCode == id).SingleOrDefault();
          if (ck != null)
          {

                Console.WriteLine("Enter Firstname");
              string name = Console.ReadLine();
              Console.WriteLine("enter Lastname");
              string lastname = Console.ReadLine();
              Console.WriteLine("enter phoneNumber");
              string phone = Console.ReadLine();
              Console.WriteLine("enter Email");
              string MAil = Console.ReadLine();
              Console.WriteLine("enter Address");
              string adderss = Console.ReadLine();
              Console.WriteLine("enter Age");
              int age = int.Parse(Console.ReadLine());
              Console.WriteLine("enter your gender");
              Console.WriteLine("1 for male\n2 for female\n3for Rather not Specify");
              var Response = (Gender)int.Parse(Console.ReadLine());
              Console.WriteLine("enter DateOfBirth//// year/month/day");
              var response= DateTime.Parse(Console.ReadLine());
               var profile = GeneratePRofileCode();
              var utme = GenerateUtmepin();
            

                      SchoolRepository sc = new SchoolRepository(_connect);
                         CourseRepository cc = new CourseRepository(_connect);
                    var first = "";
                    var Cfirst = "";
                    var second = "";
                    var Csecond = "";
                    var third = "";
                    var  Cthird = "";
                  while(true)
                  { 
                      sc.GetAllSchools();
                    Console.WriteLine("enter the name your first choice school from the list of schools above");
                     first = Console.ReadLine();
                    var check = sc._connector.schools.Where(item => item.Name == first).SingleOrDefault();
                    if (check == null)
                    {
                        Console.WriteLine("invalid school.....chose from the list below");
                        
                    }
                    else
                    {
                         
                        while(true)
                        {
                              cc.GetAllCourse();
                            Console.WriteLine("chose the name your first choice course from the list of course above");
                             Cfirst = Console.ReadLine();
                            var K = cc._context.courses.Where(item => item.CourseName == Cfirst).SingleOrDefault();
                            if (K == null)
                            {
                                  Console.WriteLine("invalid school.....chose from the list below");
                            }
                            else break;
                        }
                          break;
                    }
                  
                }  
                      
                      
                      while (true)
                      {
                              sc.GetAllSchools();
                            Console.WriteLine("enter the name your second choice school from the list of schools above");
                           second = Console.ReadLine();
                          var  c = sc._connector.schools.Where(item=> item.Name == second).SingleOrDefault();
                           if (c == null)
                           {
                                 Console.WriteLine("invalid school.....chose from the list below");
                           }
                           else{
                               while(true)
                               {
                                       cc.GetAllCourse();
                                     Console.WriteLine("chose the name your second choice course from the list of course above");
                                   Csecond = Console.ReadLine();
                                    var F = cc._context.courses.Where(item => item.CourseName == Csecond).SingleOrDefault();
                                    if (F == null)
                                    {
                                           Console.WriteLine("invalid course.....choose from the list of course below");
                                    }
                                    else break;
                               }
                               break;
                           }
                           
                      }
                              

                      while(true)
                      {
                            sc.GetAllSchools();
                            Console.WriteLine("enter the name your third choice school from the list of schools above");
                         third = Console.ReadLine();
                        var d = sc._connector.schools.Where(item => item.Name == third).SingleOrDefault();
                        if(d == null)
                        {
                              Console.WriteLine("invalid school.....chose from the list below");
                        }
                         else
                          {
                            while(true)
                            {
                                    cc.GetAllCourse();
                                  Console.WriteLine("chose the name your third choice course from the list of course above");
                                 Cthird = Console.ReadLine();
                                    var T = cc._context.courses.Where(item => item.CourseName == Cthird).SingleOrDefault();
                                    if (T == null)
                                    {
                                      Console.WriteLine("invalid course.....choose from the list of course below");
                                    }
                                    else break;
                          }
                          break;
                        }
                      }

                      var choose = "";
                    CenterRepository fr = new CenterRepository(_connect);
                  
                   
                    while(true)
                    {
                         fr.GetAllCenters();
                        Console.WriteLine("chose the name your prefered Examination centers from the list of centers above");               
                        choose = Console.ReadLine();
                        var H = fr._Connect.centers.Where(item => item.Name == choose).SingleOrDefault();
                       
                      if (H == null)
                      {
                          Console.WriteLine("Center does not exist.... choose from the list of centers below");
                      }
                      else if (H != null)
                      {
                             break;
                      }
                    }  
                    
                    
                  var exam = GenerateExaminationDate();
                  var studenT = new Student()
                  {
                    FirstName = name,
                      Surname = lastname,
                      PhoneNumber = phone,
                      Email = MAil,
                      Address = adderss,
                      Age = age,
                      Gender = Response,
                      DateOFBirth = response,
                      PofileCode = profile,
                      UtmePin = utme,
                        SchoolFirstChioce = first,
                      SchoolSecondChoice = second,
                      SchoolThirdchoice = third,
                      CourseFirstChioce = Cfirst,
                      CourseSecondChoice = Csecond,
                      CourseThirdchoice = Cthird,
                      CenterNAme = choose,
                      ExamDate = exam,
                      CourseSubject = new List<StudentSubject>(),
                    
                  };
            
                  

              SubjectRepo sub = new SubjectRepo(_connect);
                  var choice ="";
                while(true)
                {
                    sub.GetAllSubject();
                    for (int i = 0; i< 4; i++)
                    {
                            Console.WriteLine("chose your subjects from the available subjects above");
                           choice = Console.ReadLine();
                    }
               
                    var  checck =   sub._cont.subjects.Where(s => s.Name == choice).SingleOrDefault();
                    if (checck != null)
                   {
                         var stud = new StudentSubject()
                         {
                                StudentID = studenT.ID,
                                SubjectName = checck.Name,
                         };
                         break;
                   }
                   else if (checck == null)
                   {
                      Console.WriteLine("invalid subject...... choose from the list below");
                   }
                    
                  
                }             


               _connect.students.Add(studenT);
              _connect.SaveChanges();
              Console.WriteLine("Congratulation Registration Successfull");
               Console.WriteLine($" dear {name} {lastname} your ProfileCode is {GeneratePRofileCode()}");
              Console.WriteLine($"  dear {name} {lastname} your UTMEPIN is {GeneratePRofileCode()}"); 
             Console.WriteLine($" your Examination date is { GenerateExaminationDate()}");
         
           
         } 
        else
        {
          Console.WriteLine("Sorry............... only staff can register student");
        }
      
       
      }

          public string GenerateExaminationDate()
          {
              var d = DateTime.Now;
              var year = d.Year;
              string month = "April";
            string [] days = {"Monday","Tuesday","Wednessday","Thursday","Friday","Saturday"};
            Random rmd = new Random();
            int c = rmd.Next(1,32);
            var day = days[rmd.Next(0,6)];

            string[] time = {"9Am to 11Am", "11Am to 1Am", "1Am to 3Am"};
            var rand = time[rmd.Next(0,3)];


             
            
                  return $" your Examination Date is {c} {day} {month} {year} from {rand}";
            // }

          }

          public void GetstudentBySubject()
          {
             Console.WriteLine("Enter the subject of the student you want to get");
               var sub = Console.ReadLine();
                var check = _connect.studentSubjects.Include(s => s.student).Where(a => a.SubjectName == sub).ToList();
                if (check == null)
                {
                    Console.WriteLine("student with this subject  does not exist");
                }
                else
                {
                    foreach (var st in check)
                    {
                        Console.WriteLine($"{st.student.FirstName}\t{st.student.Surname}");
                    }            
                } 
          }

          public void GetSubjectBystudent()
          {
              Console.WriteLine("enter the student id to get subject ");
              var id = int.Parse(Console.ReadLine());
              var check = _connect.studentSubjects.Include(item => item.subject).Where(items => items.StudentID == id).ToList();
              if (check == null)
              {
                Console.WriteLine("student with subject does not exist ");
              }
              else{
                foreach(var items in check)
                {
                  Console.WriteLine($"{items.SubjectName}");
                }
              }
          }

        public void GetstudentByCenter()
        {
            System.Console.WriteLine("Enter the name of the center to get student");
            var centername = Console.ReadLine();            
            var studentbycenter = _connect.students.Where(item => item.CenterNAme == centername).ToList();
            if (studentbycenter == null)
            {
                System.Console.WriteLine("No student with this center");
            } 
            else
            {
                foreach (var st in studentbycenter)
                {
                    System.Console.WriteLine($" {st.FirstName}  {st.Surname}");
                }
            }
        }

        public void GetCenterByStudent()
        {
          Console.WriteLine("Enter the Firstname of the Student to get center");
          var cent = Console.ReadLine();
          var check = _connect.students.Where(item => item.FirstName == cent).ToList();
          if (check != null)
          {
             foreach(var it in check)
             {
               Console.WriteLine($"{it.CenterNAme}");
             }
          }
        }

        public void GetAllStudents()
        {
           var check = _connect.students;
           foreach(var stud in check)
           {
              Console.WriteLine($"{stud.FirstName} {stud.Surname} {stud.Age}");
           }
        }

        public void ViewStudentDetails()
        {
           Console.WriteLine("enter your ID");
           var code = int.Parse(Console.ReadLine());
           var ck =  _connect.students.Find(code);
           if (ck != null)
           {
                Console.WriteLine($"your name is {ck.FirstName} {ck.Surname} \nAGE = {ck.Age}\n DateOfBirth = {ck.DateOFBirth}\n Email = {ck.Email}\n Phonenumber = {ck.PhoneNumber}\nAddress =  {ck.Address}\n schools = {ck.SchoolFirstChioce} {ck.SchoolSecondChoice} {ck.SchoolThirdchoice}\n Courses = {ck.CourseFirstChioce} {ck.CourseSecondChoice} {ck.CourseThirdchoice}");
           }
           else
           {
              Console.WriteLine("student does not exist");
           }
        }

        public void GetParticularStudent()
        {
           Console.WriteLine("Enter the Id of the student you want to get");
            int id = int.Parse(Console.ReadLine());  
            var s = _connect.students.Find(id);
            if(s == null)
            {
                Console.WriteLine("The student with this Id does not exist");
            } 
            else
            {
                Console.WriteLine($" {s.FirstName} {s.Surname} {s.Age}");
            }    
        }

        public void DeleteStudent()
        {
           Console.WriteLine("Enter the ID of the student to delete");
            int id = int.Parse(Console.ReadLine());
            var s = _connect.students.Find(id);  
            if (s != null)
            {
                _connect.students.Remove(s);
                _connect.SaveChanges();
            }
            else
            {
              Console.WriteLine($" student with  {id} does not exist");
            }
             DeleteStudent();
        }

        public void ChangeOFcourseAndInstitution()
        {
           Console.WriteLine("enter the Profilecode of the student to Update");
           var id = int.Parse(Console.ReadLine());
           var check = _connect.students.Where(item => item.PofileCode == id).SingleOrDefault();
           if (check != null)
           {
              
            ///    schoolRepo.GetAllSchools();
             Console.WriteLine("enter your first choice school from the list of schools above");
             var first = Console.ReadLine();
               Console.WriteLine("enter your second choice school from the list of schools above");
             var second = Console.ReadLine();
               Console.WriteLine("enter your third choice school from the list of schools above");
             var third = Console.ReadLine();
             //courseRepo.GetAllCourse();
             Console.WriteLine("chose your first choice course from the list of course above");
             string Cfirst = Console.ReadLine();
              Console.WriteLine("chose your second choice course from the list of course above");
             string Csecond = Console.ReadLine();
              Console.WriteLine("chose your third choice course from the list of course above");
             string Cthird = Console.ReadLine();

              check.SchoolFirstChioce = first;
              check.SchoolSecondChoice  = second;
              check.SchoolThirdchoice = third;
              check.CourseFirstChioce = Cfirst;
              check.CourseSecondChoice = Csecond;
              check.CourseThirdchoice = Cthird;

              _connect.students.Update(check);
              _connect.SaveChanges();

           }
           else{
             Console.WriteLine("invalid ProfileCode\nstudent does not exist");
           }
        }
        
            // public void GetCourseBySyudent()
            // {
            //    Console.WriteLine("Enter the ID  of the student to get course");
            //    var course = int.Parse(Console.ReadLine());
            //     var check =  _context.courses.Include(it => it.CourseName).Where(items => items)
            //     if (check != null)
            //     {
            //       foreach(var btc in check)
            //       {
            //         Console.WriteLine($"{btc.CourseName} {btc.CourseID} ");
            //       }
            //     }
            //     else{
            //       Console.WriteLine($"Student with {course} does not exist");
            //     }
            // }
            
    }
}