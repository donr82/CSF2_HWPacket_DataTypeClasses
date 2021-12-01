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

            Console.WriteLine("\n\nVehicle Lab Set\n\n");

            Vehicle v1 = new Vehicle();
            v1.Make = "DeLorean";
            v1.Model = "DMC - 12";
            v1.Year = 1976;
            v1.Weight = 2743;

            Console.WriteLine($"Doc Brown made a time machine out of a { v1.Year}  { v1.Make} { v1.Model}.  " +
                $"He somehow got it to its speed of 88mph eventhough it weighed {v1.Weight:n0}lbs.");
        }
    }
}
