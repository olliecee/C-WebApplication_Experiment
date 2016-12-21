using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            var member = new Member("George Orwell");

            member.HelloWorld();
            member.GetName();
        }
    }
}