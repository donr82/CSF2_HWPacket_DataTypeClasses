using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Customer
    {
        /*
         * 5. Customer
         *  a. customerId - string
         *  b. firstName - string
         *  c. lastName - string
         *  d. contactInformation - ContactInfo
         *  
         *  Include all fields, properties, two constructors (default and fully  qualified),
         *  and a ToString() for each class. Then test the class you created in the TesterProgram
         *  project by creating objects using both constructors and writing them on the screen.
         *  
         *  Merge each completed branch back to the master branch and push master to the remote repo
         */

        private string _customerId;
        private string _firstName;
        private string _lastName;
        private ContactInfo _contactInformation;

        public string CustomerId
        {
            get { return _customerId; }
            set { _customerId = value; }
        }//end CustomerId

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

        public ContactInfo ContactInformation
        {
            get { return _contactInformation; }
            set { _contactInformation = value; }
        }//end Contactinformation

        public Customer(string customerId, string firstName, string lastName, ContactInfo contactInformation)
        {
            CustomerId = customerId;
            FirstName = firstName;
            LastName = lastName;
            ContactInformation = contactInformation;
        }//end fq ctor

        public Customer() { }

        public override string ToString()
        {
            return string.Format($"Customer Id: {CustomerId}\n" +
                $"First Name: {FirstName}\n" +
                $"Last Name: {LastName}\n" +
                $"Contact Information: {ContactInformation}\n");
        }//end ToString


    }
}
