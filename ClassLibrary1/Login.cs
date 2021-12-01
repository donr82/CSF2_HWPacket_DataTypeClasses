using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Login
    {
        /*
         * 3. Login
         *  a. usertname - string
         *  b. password - string
         *  
         *  
         *  Include all fields, properties, two constructors (default and fully  qualified),
         *  and a ToString() for each class. Then test the class you created in the TesterProgram
         *  project by creating objects using both constructors and writing them on the screen.
         *  
         *  Merge each completed branch back to the master branch and push master to the remote repo
         */

        private string _username;
        private string _password;

        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }//end Username

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }//end Password

        public Login(string username, string password)
        {
            Username = username;
            Password = password;
        }//end fq ctor

        public Login() { }

        public override string ToString()
        {
            return string.Format($"Username: {Username}\n" +
                                 $"Password: {Password}\n");
        }//end ToString
    }//end class
}//end namespace
