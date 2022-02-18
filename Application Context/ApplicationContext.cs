using System;
using Microsoft.EntityFrameworkCore;

namespace JambApp.Entities
{
    public class ApplicationContext : DbContext
    {
        protected override void  OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
             optionsBuilder.UseMySQL
           ("server=localhost;user=root;database=JambApp;port=3306;password=DamilarePassoneword1212");
        }

        public DbSet<Student> students {get;set;}
        public DbSet<Admin> admins {get;set;}

        public DbSet<Center> centers {get;set;}

        public DbSet<School> schools  {get;set;}
        public DbSet<Subject> subjects {get;set;}
        public DbSet<Course> courses {get;set;}
        public DbSet<StudentSubject> studentSubjects {get;set;}

        


    }

    
}