
                // using System.Collections;
                // using JambApp;
                // using System.Runtime.InteropServices.ComTypes;
                // using System.Runtime.CompilerServices;
                // using System.Data;
                // using JambApp.Entities;
                // using Microsoft.EntityFrameworkCore;
                // using System;
                // using System.Collections.Generic;
                // using System.Linq;
                // using JambApp.Repositories;


                // namespace JambApp.Repositories
                // {
                //     public class MENU
                //     {
                //           public readonly ApplicationContext _Connection;
                //           public readonly ApplicationContext   ad;
                //           public MENU(ApplicationContext context,ApplicationContext context1)
                //           {
                //               _Connection = context;
                //               _Connection = context1;
                //           }
                        
                //         public static void Submenu()
                //         {
                //             Console.WriteLine("WELCOME TO JAMB PORTAL");
                //             Console.WriteLine("ENTER 1 FOR ADMIN LOGIN\n2 FOR STUDENT LOGIN");
                //             var ans = int.Parse(Console.ReadLine());

                //              ApplicationContext application = new ApplicationContext();
                //             AdminRepository ad = new AdminRepository(application);

                            
                //              ApplicationContext applictionn = new ApplicationContext();
                //             SchoolRepository ss = new SchoolRepository( applictionn );
                            
                //             ApplicationContext applicationn = new ApplicationContext();
                //             CourseRepository cc  = new CourseRepository(applicationn);

                        
                //             ApplicationContext apPlictionn = new ApplicationContext();
                //             SubjectRepo sb = new SubjectRepo( apPlictionn);

                //              ApplicationContext aapPlictionn = new ApplicationContext();
                //             CenterRepository ct = new CenterRepository( aapPlictionn);

                //               ApplicationContext application1 = new ApplicationContext();
                //              StudentRepository st = new StudentRepository(application1);

                //             if (ans == 1)
                //             {
                            

                //                 Console.WriteLine("ARE YOU A SUPERIOR ADMIN OR SURBODINATE ADMIN\n ENTER 1 FOR SUPERIOR\n ENTER 2 FOR SURBURDINATE");
                //                 var opton = int.Parse(Console.ReadLine());

                //                if (opton == 1)
                //                {
                                
                //                     Console.WriteLine("Enter your STaffID");
                //                     var id = Console.ReadLine();

                //                     if (id == "Admin//99eb2/")
                //                     {
                //                         Console.WriteLine("wELCOME \nTO REGISTER SUBURDINATE ADMINS ENTER 1\nTO GET A ADMIN ENTER 2\nTO UPDATE ADMIN ENTER 3\nTO GET ALL ADMIN ENTER 4\nTO DELETE ADMIN ENTER 5\nTO GET FULL DETAILS OF AN ADMIN ENTER 6");
                //                         var option = int.Parse(Console.ReadLine());

                //                         if (option == 1)
                //                         {
                //                             ad.CreateAdmin();
                //                         }         
                //                         if (option == 2)
                //                         {
                //                             ad.GetAdmin();
                //                         }       
                //                         if (option == 3)
                //                         {
                //                             ad.UpdateAdmin();
                //                         }
                //                         if (option == 4)
                //                         {
                //                             ad.GetAllAdmin();
                //                         }
                //                         if (option == 5)
                //                         {
                //                             ad.DeleteAdmin();
                //                         }
                //                         if (option == 6)
                //                         {
                //                             ad.GetAdminFullDetails();
                //                         }
                                        
                                    

                //                 } 
                //                         var Ans = 0;
                //                         var reply = 0;
                //                         var REp = 0;
                //                         var solution =0;
                //                         var Reply = 0;
                //                         var Solution = 0;
                                    
                //                 Console.WriteLine("WELCOME \nENTER 1 TO ACCES THE COURSE MENU\nENTER 2 TO ACCESS THE SCHOOL MENU\nENTER 3 TO ACCES THE SUBJECT MENU\n ENTER 4 TO ACCES THE CENTER MENU\nENTER 5 TO ACCES THE STUDENT MENU");
                                
                //                     Ans =  int.Parse(Console.ReadLine()); 
                //                 }
                //                 if (Ans == 1)
                //                 {
                //                     Console.WriteLine("WELCOME\n TO CREATE COURSE ENTER 1\n TO UPDATE COURSE ENTER 2\nTO GET ALL COURSE ENTER 3\nTO GET A COURSE ENTER 4\nTO DELETE A COURSE ENTER 5");
                //                     reply = int.Parse(Console.ReadLine());
                //                 }
                //                 if  (reply  == 1)
                //                 {
                //                     cc.CreateCourse();
                //                 }
                //                 if ( reply  == 2)
                //                 {
                //                     cc.UpdateCourse();
                //                 }
                //                 if ( reply  == 3)
                //                 {
                //                     cc.GetAllCourse();
                //                 }
                //                 if ( reply  == 4)
                //                 {
                //                     cc.GetCourse();
                //                 }
                //                 if ( reply == 5)
                //                 {
                //                     cc.DeleteCourse();
                //                 }
                //                 else if (Ans ==2)
                //                 {
                //                     Console.WriteLine("WELCOME\n TO CREATE SCHOOL ENTER 1\n TO UPDATE SCHOOL ENTER 2\nTO GET ALL SCHOOL ENTER 3\nTO GET A SCHOOL ENTER 4\nTO DELETE A SCHOOL ENTER 5");
                //                     REp = int.Parse(Console.ReadLine());
                //                 }
                //                 if (REp == 1)
                //                 {
                //                     ss.CreateSchool();
                //                 }
                //                 if (REp == 2)
                //                 {
                //                     ss.UpdateSchool();
                //                 }
                //                 if (REp == 3)
                //                 {
                //                     ss.GetAllSchools();
                //                 }
                //                 if (REp == 4)
                //                 {
                //                     ss.GetSchool();
                //                 }
                //                 if (REp == 5)
                //                 {
                //                     ss.DeleteSchool();
                //                 }
                //                 if (Ans == 3)
                //                    {
                //                         Console.WriteLine("WELCOME\n TO CREATE SUBJECT ENTER 1\n TO UPDATE SUBJECT ENTER 2\nTO GET ALL SUBJECT ENTER 3\nTO GET A SUBJECT ENTER 4\nTO DELETE A SUBJECT ENTER 5");
                //                         solution = int.Parse(Console.ReadLine());
                //                    }
                //                    if (solution == 1)
                //                    {
                //                         sb.CreateSubject();
                //                    }
                //                    if (solution == 2)
                //                    {
                //                        sb.UpdateSubject();
                //                    }
                //                    if (solution == 3)
                //                    {
                //                        sb.GetAllSubject();
                //                    }
                //                    if (solution ==4)
                //                    {
                //                         sb.GetSubject();
                //                    }
                //                    if (solution == 5)
                //                    {
                //                         sb.DeleteSubject();
                //                    }
                //                    if (Ans == 4)
                //                    {
                //                         Console.WriteLine("WELCOME\n TO CREATE CENTER ENTER 1\n TO UPDATE CENTER ENTER 2\nTO GET ALL CENTER ENTER 3\nTO GET A CENTER ENTER 4\nTO DELETE A CENTER ENTER 5");
                //                         Solution = int.Parse(Console.ReadLine());
                //                    }
                //                   if (  Solution == 1)
                //                   {
                //                       ct.CreateCenter();
                //                   }
                //                   if (  Solution ==2)
                //                   {
                //                       ct.UpdateCenter();
                //                   }
                //                   if (  Solution ==3)
                //                   {
                //                       ct.GetAllCenters();
                //                   }
                //                   if (  Solution ==4)
                //                   {
                //                       ct.GetCenter();
                //                   }
                //                   if (  Solution == 5)
                //                   {
                //                       ct.DeleteCenter();
                //                   }
                //                   if (Ans == 5)
                //                   {
                //                     Console.WriteLine("WELCOME\nTO REGISTER STUDENT ENTER 1\nTO GET STUDENT BY SUBJECT ENTER 2\nTO GET SUBJECT BY STUDENT ENTER 3\nTO GET STUDENT BY CENTER ENTER 4\nTO GET CENTER BY STUDENT ENTER 5\nTO GET ALL STUDENT ENTER 6\nTO GET A PARTICULAR STUDENT ENTER 7\nTO DELETE STUDENT ENTER 8");
                //                       Reply =  int.Parse(Console.ReadLine());
                //                   }
                //                   if ( Reply == 1)
                //                   {
                //                         st.JambREgistration();
                //                   }
                //                   if ( Reply  == 2)
                //                   {
                //                       st.GetstudentBySubject();
                //                   }
                //                   if ( Reply  == 3)
                //                   {
                //                       st.GetSubjectBystudent();
                //                   }
                //                   if ( Reply  == 4)
                //                   {
                //                       st.GetstudentByCenter();
                //                   }
                //                   if ( Reply  ==5)
                //                   {
                //                       st.GetCenterByStudent();
                //                   }
                //                   if ( Reply == 6)
                //                   {
                //                       st.GetAllStudents();
                //                   }
                //                   if ( Reply == 7)
                //                   {
                //                       st.GetParticularStudent();
                //                   }
                //                   if( Reply == 8)
                //                   {
                //                       st.DeleteStudent();
                //                   }
                //                 }
                //                 // else{
                //                 //     Console.WriteLine("ACCESS DENIED................... \nYOU ARE NOT A SUPERIOR ADMIN");
                //                 // }
                            
                //             }
                //             else if (ans == 2)
                //             {
                //                 //   var sol = 0
                //                 Console.WriteLine("WELCOME\nTO APPLY FOR CHANGE OF COURSE AND INSTITUTION ENTER 1\nENTER 2 TO VIEW PERSONAL DETAILS");
                //                var sol = int.Parse(Console.ReadLine());
                            
                //                if (sol == 1)
                //                {
                //                    st.ChangeOFcourseAndInstitution();
                //                }
                //                if (sol == 2)
                //                {
                //                    st.ViewStudentDetails();
                //                }
                //             }
                //             // else if (ans == 3)
                //             // {
                //             //     break;
                //             // }
                            
                            


//         }
    
//     }
// }