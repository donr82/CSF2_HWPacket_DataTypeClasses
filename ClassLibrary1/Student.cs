using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Student
    {
        /*
         * 1. Student
         *  a. firstName - string
         *  b. lastName - string
         *  c. id - string
         *  d. gpa - float
         *  
         *  Include all fields, properties, two constructors (default and fully  qualified),
         *  and a ToString() for each class. Then test the class you created in the TesterProgram
         *  project by creating objects using both constructors and writing them on the screen.
         *  
         *  Merge each completed branch back to the master branch and push master to the remote repo
         */

        private string _firstName;
        private string _lastName;
        private string _id;
        private float _gpa;

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }//end FirstName

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }//end LastName

        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }//end id

        public float Gpa
        {
            get { return _gpa; }
            set { _gpa = value; }
        }//end Gpa

        public Student(string firstName, string lastName, string id, float gpa)
        {
            FirstName = firstName;
            LastName = lastName;
            Id = id;
            Gpa = gpa;
        }//end fq ctor

        public Student() { }

        public override string ToString()
        {
            return string.Format($"FirstName: {FirstName}\n" +
                                 $"LastName: {LastName}\n" +
                                 $"Id: {Id}\n" +
                                 $"Gpa: {Gpa:n0}\n");
        }//end ToString

    }//end class
}//end namespace
