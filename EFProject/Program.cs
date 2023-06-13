using EFProject.Context;
using EFProject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EFProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            MyContext db = new MyContext();
            //db.Customers.Add(new Customer { FirstName = "Manar" ,LastName="Ahmed", Address="Mansoura"});
            //db.Customers.Add(new Customer { FirstName = "Ali", LastName = "Emad", BirthDate=new(2000,2,2)});
            //db.Customers.Add(new Customer { FirstName = "Osama", BirthDate = new(2002, 3, 12), PhoneNumber = 1234567891 });
            //db.SaveChanges();

            //Producer p1 = new() { Country="USA"};
            //Producer p2 = new() { Country = "France" };
            //Producer p3 = new() { Country = "Canada", CompanyName = "Disney" };
            //db.Producers.AddRange(p1,p2,p3);
            //db.SaveChanges();

            //Movie m1 = new() { Title = "Avengers",ProducerId=2, Duration = 2, Rating = 'B' };
            //Movie m2 = new() { Title = "Twilight",ProducerId=2, Duration = 1, Rating = 'C' };
            //Movie m3 = new() { Title = "Power Rangers",ProducerId=3, Duration = 3, Rating = 'A' };
            //Movie m4 = new() { Title = "Ted",ProducerId=1, Duration = 2, Rating = 'C' };
            //Movie m5 = new() { Title = "Game Night",ProducerId=1, Duration = 2, Rating = 'A' };
            //Movie m6 = new() { Title = "The Hunger Games",ProducerId=2, Duration = 3, Rating = 'B' };
            //Movie m7 = new() { Title = "Anna",ProducerId=2, Duration = 2, Rating = 'B' };
            //db.Movies.AddRange(m1, m2, m3, m4, m5, m6, m7);
            //db.SaveChanges();

            //Customer_Movie r1 = new() { CustomerId = 1, MovieId = 2 };
            //Customer_Movie r2 = new() { CustomerId = 2, MovieId = 3 };
            //Customer_Movie r3 = new() { CustomerId = 3, MovieId = 6 };
            //db.Customer_Movies.AddRange(r1,r2,r3);
            //db.SaveChanges();
            //Customer_Movie r4 = new() { CustomerId = 1, MovieId = 4 };
            //Customer_Movie r5 = new() { CustomerId = 2, MovieId = 5 };
            //Customer_Movie r6 = new() { CustomerId = 3, MovieId = 7 };
            //Customer_Movie r7 = new() { CustomerId = 4, MovieId = 8 };
            //Customer_Movie r8 = new() { CustomerId = 1, MovieId = 5 };
            //db.Customer_Movies.AddRange(r4, r5, r6,r7,r8);
            //db.SaveChanges();
            Customer_Movie r9 = new() { CustomerId = 1, MovieId = 3 };
            Customer_Movie r10 = new() { CustomerId = 2, MovieId = 2 };
            Customer_Movie r11 = new() { CustomerId = 4, MovieId = 5 };
            db.Customer_Movies.AddRange(r9, r10, r11);
            db.SaveChanges();


        }
    }
}
