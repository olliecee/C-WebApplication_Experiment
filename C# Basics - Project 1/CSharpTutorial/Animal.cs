using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorial
{
    class Animal
    {
        // Private variables are able to be accessed outside its scope?
        private string _nameFirst = "Winston";
        private string _nameLast = "McCree";

        // A method (explanation of method below)
        public string NameFull()
        {
            return _nameFirst + " " + _nameLast;
        }

        /* This is a method
         * 1. Delcaring the method as public allows anyone to access it?
         * 2. Delcaring the method as a string tells us we need to return the same type?
         * 3. Finally we name the method
         */
        public string NameAsk()
        {
            Console.WriteLine("What is your animal name?");
            var name = Console.ReadLine();
            var returnString = "Hello, " + name + "! Welcome to the safari!";
            return returnString;
        }
    }
}
