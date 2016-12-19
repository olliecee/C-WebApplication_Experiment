using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorial
{
    public class Person
    {
        private string _nameFirst = "Kato";
        private string _nameLast = "Kii";

        public string NameFull()
        {
            NameOverride();
            return _nameFirst + " " + _nameLast;
        }

        private void NameOverride()
        {
            _nameFirst = "Katokiri";
        }

        public string NameAsk()
        {
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();
            var returnString = "Hello, " + name + "! Welcome to Canada!";
            return returnString;
        }
    }
}
