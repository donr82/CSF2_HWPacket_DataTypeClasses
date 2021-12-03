using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Song
    {
        /*
         * 9. Song
         *  a. artist - string
         *  b. title - string
         *  c. lengthInSeconds - int
         *  
         *  Include all fields, properties, two constructors (default and fully  qualified),
         *  and a ToString() for each class. Then test the class you created in the TesterProgram
         *  project by creating objects using both constructors and writing them on the screen.
         *  
         *  Merge each completed branch back to the master branch and push master to the remote repo
         */

        private string _artist;
        private string _title;
        private int _lengthInSeconds;

        public string Artist
        {
            get { return _artist; }
            set { _artist = value; }
        }//end Artist

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }//end Title

        public int LengthInSeconds
        {
            get { return _lengthInSeconds; }
            set { _lengthInSeconds = value; }
        }//end LengthInSeconds

        public Song(string artist, string title, int lengthInSeconds)
        {
            Artist = artist;
            Title = title;
            LengthInSeconds = lengthInSeconds;
        }

        public Song() { }

        public override string ToString()
        {
            return string.Format($"Artist: {Artist}\n" +
                $"Title: {Title}\n" +
                $"Length of song in seconds: {LengthInSeconds}");
        }

    }//end class
}//end namespace
