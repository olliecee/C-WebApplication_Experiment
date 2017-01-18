using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorial
{
    public class Person
    {
        private string _name = "Chris Hawkes";

        /* This constructor receives a parameter
         * 
         * 1. We are accepting only a string variable as a parameter
         * 2. After receiving the parameter, our method has an instruction
         * 3. The instruction tells us to place our parameter into a variable
         */
        public Person(string name)
        {
            _name = name;
        }

        // This method simply prints to the console
        public void GetName()
        {
            // Writing to the console the parameter received from the parent class
            Console.WriteLine(_name);
        }
    }
}
