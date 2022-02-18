using JambApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace JambApp.Repositories
{
    public class AdminRepository
    {  
        public readonly ApplicationContext _Connection;
         public readonly ApplicationContext  _cont;
        public AdminRepository(ApplicationContext context)
        {
            _Connection = context;
        }
       
        public AdminRepository(ApplicationContext context, ApplicationContext context1)
        {
          
            _cont = context1;
              _Connection = context;
        }


        public void CreateAdmin()
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
            var StaffCode =  GenerateAdminStaffCode();
            Console.WriteLine($"your ID is {StaffCode}");
           var admin = new Admin()
           {
               FirstName = name,
               Surname = lastname,
               PhoneNumber = phone,
               Email = MAil,
               Address = adderss,
               Age = age,
               DateOFBirth = response,
               Gender = Response,
               StaffCode = StaffCode,
           };
            _Connection.admins.Add(admin);
            _Connection.SaveChanges();

        }
        public  string GenerateAdminStaffCode()
        {
            return $"Admin//{Guid.NewGuid().ToString().Substring(0,5)}/"; 
        }
 
        public void GetAdmin()
        {
           Console.WriteLine("Enter the id of admin to get");
            int id = int.Parse(Console.ReadLine());
            var pub = _Connection.admins.Find(id);
          //  var pub3 = _Connection.admins.Where(x=> x.ID==id).singleoedefault();
          //  var pub2 = from x in _Connection.admins where x.ID== id select x;
            if(pub != null)
            {
                Console.WriteLine($"{pub.FirstName}\t{pub.Surname}\t{pub.StaffCode}");
            }
            else
            {
                Console.WriteLine($"publisher with the id {id} doesnt exist: ");
            }

        }

        public void UpdateAdmin()
        {
              Console.WriteLine("Enter the id of the admin to update");
            int id = int.Parse(Console.ReadLine());
            var check = _Connection.admins.Find(id);
            if (check == null)
            {
                Console.WriteLine($"admin with {id} does not exist");
            }
            else
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
            var staffcode = GenerateAdminStaffCode();
          
           
            check.FirstName = name;
             check.Surname = lastname;
            check.PhoneNumber = phone;
            check.Email = MAil;
           check.Address = adderss;
         check.Age = age;
          check.Gender = Response;
           check.DateOFBirth = response;
           check.StaffCode = staffcode;


             _Connection.admins.Update(check);
             _Connection.SaveChanges(); 
               Console.WriteLine($"your new ID is {staffcode}");
               
              
            }
           
        }

        public void DeleteAdmin()
        {
            Console.WriteLine("Enter the id of the admin to delete");
            int id = int.Parse(Console.ReadLine());
            var check = _Connection.admins.Find(id);
            if (check == null)
            {
                Console.WriteLine($"publisher with {id} could not exist");
            }
            else
            {
                _Connection.admins.Remove(check);
                _Connection.SaveChanges();
               
            }
        }

        public void GetAdminFullDetails()
        {
            Console.WriteLine("enter the id of the admin you want to delete");
            var id = int.Parse(Console.ReadLine());

            var check = _Connection.admins.Find(id);
            {
                if (check != null)
                {
                    Console.WriteLine($"{check.FirstName}\n{check.Surname}\n{check.Age}\n{check.Address}\n{check.DateOFBirth}\n{check.Email}\n{check.PhoneNumber}\n{check.StaffCode}\n{check.Gender}\n{check.Gender}");
                }
                else{
                    Console.WriteLine($"Admin with {id} does not exist");
                }
            }
        }

        public void GetAllAdmin()
        {
           // _Connection.admins.ToList().ForEach(x => Console.WriteLine($"{x.FirstName} {x.Surname} {x.Age} {x.Address} {x.DateOFBirth} {x.Email} {x.PhoneNumber} {x.StaffCode}"));

            var checK = _Connection.admins.ToList();
            foreach(var check in checK)
            {
                Console.WriteLine($"{check.FirstName} {check.Surname} {check.Age} {check.Address}");
            }

        }

    }
}