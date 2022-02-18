using System;
using JambApp.Entities;
using JambApp.Repositories;

namespace JambApp
{
    class Program
    {
        static void Main(string[] args)
    {
            Console.WriteLine("Hello World!");



             MENU.SUBMENU();



            ApplicationContext application = new ApplicationContext();
            AdminRepository aDmin = new AdminRepository(application);
           // aDmin.CreateAdmin();
           //  aDmin.DeleteAdmin();
           //  aDmin.GetAdmin();
           //  aDmin.GetAllAdmin();
            // aDmin.GetAdminFullDetails();
           //  aDmin.UpdateAdmin();

            ApplicationContext applicationn = new ApplicationContext();
            CourseRepository ck  = new CourseRepository(applicationn);
          //  ck.CreateCourse();
          //   ck.DeleteCourse();
          // ck.GetAllCourse();
          //   ck.GetCourse();
           //  ck.UpdateCourse();



            ApplicationContext applictionn = new ApplicationContext();
            SchoolRepository pk = new SchoolRepository( applictionn );
        //    pk.CreateSchool();
           //  pk.DeleteSchool();
           //  pk.GetAllSchools();
           //  pk.GetSchool();
          // pk.UpdateSchool();

            ApplicationContext apPlictionn = new ApplicationContext();
            SubjectRepo ps = new SubjectRepo( apPlictionn);
           //  ps.CreateSubject();
          //   ps.DeleteSubject();
          //   ps.GetAllSubject();
          //   ps.GetSubject();
           //  ps.UpdateSubject();


            ApplicationContext aapPlictionn = new ApplicationContext();
            CenterRepository ps2 = new CenterRepository( aapPlictionn);
          //   ps2.CreateCenter();
          //   ps2.DeleteCenter();
           //  ps2.GetAllCenters();
           //  ps2.GetCenter();
           //  ps2.UpdateCenter();


            ApplicationContext application1 = new ApplicationContext();
             StudentRepository a = new StudentRepository(application1);
            // a.ChangeOFcourseAndInstitution();
           //   a.DeleteStudent();
            //  a.GetAllStudents();
            //  a.GetCenterByStudent();
            //   a.GetParticularStudent();
            //  a.GetstudentByCenter();
           //   a.GetstudentBySubject();
            //  a.GetSubjectBystudent();
            //  a.JambREgistration();
            
             

             



                
        }
        
    }
}
