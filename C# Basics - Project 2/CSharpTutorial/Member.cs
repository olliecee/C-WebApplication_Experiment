using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorial
{
    /* This inherets from the "Person" class
     * all methods in the inherited class is available in the
     * main program and here. You may also override them!
     */
    public class Member : Person
    {
        /* CONSTRUCTOR
         * 
         * This is a constructor. It looks like a class.
         * This has the ability to pass parameters from the main class to
         * this class, and then to the base class.
         * 
         * 1. It accepts 1 parameter from the user (string in this case)
         * 2. The parameter is sent to this class
         * 3. The constructor points to another class
         * 4. The parameter is sent from this class, to the other class
         * 
         * We don't do anything with that parameter here but transfer it.
         * This is because our constructor has no instructions!
         * After passing it to the base class, the program will continue below
         */
        public Member(string name) : base(name)
        {
        }

        public void HelloWorld()
        {
            Console.WriteLine("Hello World");
        }

        /* This overrides the method that was inherited
         * due to "Person" class being a slave to this class
         
        public void GetName()
        {
            Console.WriteLine("George Kennedy");
        }
        */
    }
}
