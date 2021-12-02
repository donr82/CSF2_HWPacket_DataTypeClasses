using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Library
    {
        /*
        * 5. Library
        *  a. books - List<Book>
        *  b. libraryName - string
        *  c. streetAddress - string
        *  d. city - string
        *  e. state - string
        *  f. zip - string
        *  
        *  Include all fields, properties, two constructors (default and fully  qualified),
        *  and a ToString() for each class. Then test the class you created in the TesterProgram
        *  project by creating objects using both constructors and writing them on the screen.
        *  
        *  Merge each completed branch back to the master branch and push master to the remote repo
        */

        private List<Book> _books;
        private string _libraryName;
        private string _streetAddress;
        private string _city;
        private string _state;
        private string _zip;

        public List<Book> Books
        {
            get { return _books; }
            set { _books = value; }
        }//end Books

        public string LibraryName
        {
            get { return _libraryName; }
            set { _libraryName = value; }
        }//end LibraryName

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

        public Library() { }

        public Library(List<Book> books, string libraryName, string streetAddress, string city, string state, string zip)
        {
            Books = books;
            LibraryName = libraryName;
            StreetAddress = streetAddress;
            City = city;
            State = state;
            Zip = zip;
        }


        public override string ToString()
        {
            string booksAvailable = "";

            foreach (Book b in Books)
            {
                booksAvailable += b.Title + "\n";
            }

            return $"Library Name: {LibraryName}\n" +
                $"Street Address: {StreetAddress}\n" +
                $"City: {City}\n" +
                $"State: {State}\n" +
                $"Zip: {Zip}.\n" +
                $"What is available: \n{booksAvailable}";
        }


    }
}
