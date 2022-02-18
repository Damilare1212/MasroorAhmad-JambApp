using System;
using System.Collections.Generic;
using System.Linq;
using JambApp.Entities;
using Microsoft.EntityFrameworkCore;

namespace JambApp.Repositories
{
    public  class CenterRepository
    {
       public  CenterRepository(ApplicationContext context)
       {
           _Connect = context;
       }
        public  readonly ApplicationContext _Connect;
        public readonly AdminRepository Adminrepo;
         private readonly ApplicationContext _Connection;
        public  CenterRepository(ApplicationContext context,AdminRepository Adminrepo, ApplicationContext context1)
        { 
            _Connect = context;
           this.Adminrepo = Adminrepo;
           _Connection = context1;
           
        }
        public CenterRepository()
        {
            
        }
 
        public void CreateCenter()
        {
            AdminRepository ad = new AdminRepository(_Connect);
            Console.WriteLine("enter staffid ");
            string id = Console.ReadLine();
            var search = ad._Connection.admins.Where(it => it.StaffCode == id).SingleOrDefault();
            if (search != null)
            {

            
                Console.WriteLine("Enter the Center Name");
                string name = Console.ReadLine();      
                Console.WriteLine("Enter the Center Address");
                string address = Console.ReadLine();          
                var center = new Center()
                {
                    Name = name,
                    Adderess = address,
                };
                _Connect.centers.Add(center);
                _Connect.SaveChanges();
               //  CreateCenter();
            }
            else
            {
                Console.WriteLine("Sorry............only admin can create center");
            }    
        }

          public bool UpdateCenter()
        {
             Console.WriteLine("Enter center ID");
            var id = int.Parse(Console.ReadLine()); 
            var check = _Connect.centers.Find(id);
            if (check == null)
            {
                Console.WriteLine("The center with this ID does not exist");
            }
            else
            {
                System.Console.WriteLine("Enter the Center Name");
                string name = Console.ReadLine();      
                System.Console.WriteLine("Enter the Center Address");
                string address = Console.ReadLine();      
                check.Name = name;
                check.Adderess = address;                
                _Connect.centers.Update(check);
                _Connect.SaveChanges();             
            }
            return true;
        }
        public void GetCenter()
        {
            Console.WriteLine("Enter the Id of the center you want to get");
            int id = int.Parse(Console.ReadLine());  
            var c = _Connect.centers.Find(id);
            if(c == null)
            {
                Console.WriteLine("The center with this Id does not exist");
            } 
            else
            {
                Console.WriteLine($"First Name: {c.Name}\n Addersss: {c.Adderess}.");
            }    
        }
        public   bool GetAllCenters()
        {
            var centers = _Connect.centers;
            foreach (var center in centers)
            {
                Console.WriteLine($" {center.Name}   adderess = {center.Adderess}.");
            }
            return true;
        }

          public void DeleteCenter()
        {
            Console.WriteLine("Enter the ID of the center you want to delete");
            int id = int.Parse(Console.ReadLine());
            var check = _Connect.centers.Find(id);  
            if (check != null)
            {
                _Connect.centers.Remove(check);
                _Connect.SaveChanges(); 
            }
            else
            {
                System.Console.WriteLine("The center with this Id does not exist");
            } 
        }       

    }
}