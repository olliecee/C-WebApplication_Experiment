using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* According to the creator + developer of C#,
 * by not 'using' references, it does not impede the performance
 * by calling it for no reason
 */

namespace CSharpTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            /* What I think this means is the following:
             * 1. Class
             * 2. Variable
             * 3. Declaring the Class is also a method?
             * 
             * This allows us to use methods in classes that aren't apart of this file?
             * Pressing F12 in VS2015Community allows us to access the method
             */
            Person person = new CSharpTutorial.Person();
            Animal species = new CSharpTutorial.Animal();

            // Human Names
            Console.WriteLine(person.NameAsk());
            Console.WriteLine("Your name is supposed to be " + person.NameFull());

            // Animal Names
            Console.WriteLine(species.NameAsk());
            Console.WriteLine("Your name is supposed to be " + species.NameFull());
        }
    }
}
