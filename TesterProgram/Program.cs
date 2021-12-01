using System;
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
        }
    }
}
