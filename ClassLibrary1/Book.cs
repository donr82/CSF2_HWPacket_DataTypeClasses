using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Book
    {
        /*
         * 7. Book
         *  a. title - string
         *  b. author - string
         *  c. numberOfPages - int
         *  
         *  Include all fields, properties, two constructors (default and fully  qualified),
         *  and a ToString() for each class. Then test the class you created in the TesterProgram
         *  project by creating objects using both constructors and writing them on the screen.
         *  
         *  Merge each completed branch back to the master branch and push master to the remote repo
         */

        private string _title;
        private string _author;
        private int _numberOfPages;

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        public string Author
        {
            get { return _author; }
            set { _author = value; }
        }

        public int NumberOfPages
        {
            get { return _numberOfPages; }
            set { _numberOfPages = value; }
        }

        public Book(string title, string author, int numberOfPages)
        {
            Title = title;
            Author = author;
            NumberOfPages = numberOfPages;
        }

        public Book() { }

        public override string ToString()
        {
            return string.Format($"Title: {Title}\n" +
                $"Author: {Author}\n" +
                $"Number of Pages: {NumberOfPages:n0}");
        }
    }
}
