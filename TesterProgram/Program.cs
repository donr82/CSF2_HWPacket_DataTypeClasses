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

            Console.WriteLine("\n\nBook Lab Set\n\n");

            Book bk1 = new Book();
            bk1.Title = "Let Me Off at the Top!";
            bk1.Author = "Ron Burgandy";
            bk1.NumberOfPages = 223;

            Console.WriteLine($"{bk1.Title} is an autobiography written by {bk1.Author}. It is a pretty quick read with only {bk1.NumberOfPages} pages.\n");

            Console.WriteLine(bk1);

            Console.WriteLine("\n\nLibrary Lab Set\n\n");

            Book bk2 = new Book("How to Archer: The Ultimate Guide to Espionage and Style and Women and Also Cocktails Ever Written", "Sterling Archer", 192);

            List<Book> books = new List<Book>() { bk1, bk2 };



            Library lb1 = new Library();
            lb1.LibraryName = "Dons Book House";
            lb1.StreetAddress = "1234 Book Ave";
            lb1.City = "Kansas City";
            lb1.State = "MO";
            lb1.Zip = "54321";
            lb1.Books = books;

            Console.WriteLine($"What is available at this Library: \n" +
                $"{bk1}\n{bk2}\n" +
                $"Where is the Library located?:\n" +
                $"{lb1.LibraryName}\n" +
                $"{lb1.StreetAddress}\n" +
                $"{lb1.City}\n" +
                $"{lb1.State}\n" +
                $"{lb1.Zip}\n");

            Console.WriteLine(lb1);

            Console.WriteLine("\n\n Song Lab Set\n\n");

            Song sng1 = new Song();
            sng1.Artist = "Bing Crosby";
            sng1.Title = "White Christmas";
            sng1.LengthInSeconds = 184;

            Console.WriteLine($"{sng1.Artist} sang the song {sng1.Title} and it is {sng1.LengthInSeconds} seconds long.");

            Console.WriteLine(sng1);




        }
    }
}
