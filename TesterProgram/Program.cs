﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace TesterProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "CSF2 Homework Packet";

            Console.WriteLine("CSF2 Homework Packet for Data Type Classes");            

            Console.WriteLine("\n\nStudent Data Type Lab Set");

            Student s1 = new Student();
            s1.FirstName = "Han";
            s1.LastName = "Solo";
            s1.Id = "Millennium Falcon";
            s1.Gpa = 3.89f;

            Console.WriteLine($"{s1.FirstName} {s1.LastName} is our new student. His id is {s1.Id} and his GPA is {s1.Gpa}.");

            Console.WriteLine(s1);

            Console.WriteLine("\n\nVehicle Lab Set\n\n");

            Vehicle v1 = new Vehicle();
            v1.Make = "DeLorean";
            v1.Model = "DMC - 12";
            v1.Year = 1976;
            v1.Weight = 2743;

            Console.WriteLine($"Doc Brown made a time machine out of a { v1.Year}  { v1.Make} { v1.Model}.  " +
                $"He somehow got it to its speed of 88mph eventhough it weighed {v1.Weight:n0}lbs.");

            Console.WriteLine(v1);

            Console.WriteLine("\n\nLogin Lab Set\n\n");

            Login l1 = new Login();
            l1.Username = "Gollum";
            l1.Password = "My_Precious";

            Console.WriteLine($"Usrname: {l1.Username}\n" +
                $"Password: {l1.Password}");

            Console.WriteLine(l1);

            Console.WriteLine("\n\nContact Info Lab Set\n\n");

            ContactInfo c1 = new ContactInfo();
            c1.StreetAddress = "5858 Lucas Valley Road";
            c1.City = "Nicasio";
            c1.State = "CA";
            c1.Zip = "94946";
            c1.Phone = "(415) 662 - 1704";
            c1.Email = "info@skysound.com";

            Console.WriteLine($"I have plans to break into Skywalker Ranch which is located at {c1.StreetAddress}, {c1.City}, {c1.State} {c1.Zip}. If not I guess I could call them at {c1.Phone} or email at {c1.Email}.");

            Console.WriteLine(c1);

            Console.WriteLine("\n\nCustomer lab Set\n\n");

            Customer cu1 = new Customer();
            cu1.CustomerId = "Red 5";
            cu1.FirstName = "Luke";
            cu1.LastName = "Skywalker";
            cu1.ContactInformation = c1;

            Console.WriteLine($"{cu1.FirstName} {cu1.LastName}'s Id is {cu1.CustomerId} and he is standing by. If he is not standing by you can contact him here \n{cu1.ContactInformation}.\n");

            Console.WriteLine(cu1);

            Console.WriteLine("\n\nCredit Card Account Lab Set\n\n");

            CreditCardAccount cr1 = new CreditCardAccount();
            cr1.AccountNumber = 123456;
            cr1.CustomerInfo = cu1;
            cr1.Balance = 10500;
            cr1.IsPastDue = true;
            cr1.AnnualInterestRate = 50;

            Console.WriteLine($"{cu1}\nMr. Skywalker has account number {cr1.AccountNumber} with a balance of {cr1.Balance:c}. It is {cr1.IsPastDue} that his account is past due, probably because of the {cr1.AnnualInterestRate}% interest rate.\n");

            Console.WriteLine(cr1);
        }
    }
}
