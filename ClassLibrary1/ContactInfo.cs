using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class ContactInfo
    {
        /*
         * 4. Contact Info
         *  a. streetaddress - string
         *  b. city - string
         *  c. state - string
         *  d. zip - string
         *  e. phone - string
         *  f. email - string
         *  
         *  
         *  Include all fields, properties, two constructors (default and fully  qualified),
         *  and a ToString() for each class. Then test the class you created in the TesterProgram
         *  project by creating objects using both constructors and writing them on the screen.
         *  
         *  Merge each completed branch back to the master branch and push master to the remote repo
         */

        private string _streetAddress;
        private string _city;
        private string _state;
        private string _zip;
        private string _phone;
        private string _email;

        public string StreetAddress
        {
            get { return _streetAddress; }
            set { _streetAddress = value; }
        }//end StreetAddress
        public string City
        {
            get { return _city; }
            set { _city = value; }
        }//end City
        public string State
        {
            get { return _state; }
            set { _state = value; }
        }//end State
        public string Zip
        {
            get { return _zip; }
            set { _zip = value; }
        }//end Zip
        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }//end Phone
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }//end Email

        public ContactInfo(string streetAddress, string city, string state, string zip, string phone, string email)
        {
            StreetAddress = streetAddress;
            City = city;
            State = state;
            Zip = zip;
            Phone = phone;
            Email = email;
        }

        public ContactInfo() { }

        public override string ToString()
        {
            return string.Format($"Street Address: {StreetAddress}\n" +
                                 $"City: {City}\n" +
                                 $"State: {State}\n" +
                                 $"Zip: {Zip}\n" +
                                 $"Phone: {Phone}\n" +
                                 $"Email: {Email}");
        }
    }//end class
}//end namespace
