using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: /HelloWorld/
        /* Unsure if this public method is acting as a 'controller' for the routes
         * or acts as an action for the Class itself. Yet to be determined!
         * 
         * I believe this is an action, more precisely, a default action for this
         * specific Class
         */
        public string Index()
        {
            return "This is my default action...";
        }

        // Example 1, Controllers

        // GET: /HelloWorld/Welcome/ 
        // This is an action within this controller
        //public string Welcome(string name, int numTimes = 1)
        //{
        /* The code:
         ********************************************************************
         * HtmlEncoder.Default.Encode
         ********************************************************************
         * Protects the app from malicious input (namely JavaScript).
         * It also uses interpolated strings
         * (https://msdn.microsoft.com/en-us/library/dn961160.aspx)
         */
        //return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
        // http://localhost:xxxx/HelloWorld/Welcome?name=Rick&numtimes=4
        // Passed as query strings via Model Binding
        // (https://docs.microsoft.com/en-us/aspnet/core/mvc/models/model-binding)
        //}


        // Example 2, Controllers

        // GET: /HelloWorld/Welcome/
        public string Welcome(string name, int ID = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
        }
    }
}
