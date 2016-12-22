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
            // Long way of declaring an object
            var band = new Band();
            band.Bio = "Human, Female, 19, California";
            band.Name = "Anne";
            band.Member = new Member(band.Name);

            // Short way of declaring an object
            var band2 = new Band
            {
                Bio = "Human, Female, 19, California",
                Name = "May"
            };

            Console.WriteLine(band.Name);
            Console.WriteLine(band2.Name);
        }
    }
}