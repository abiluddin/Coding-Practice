using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Decisions
{
    public class Program
    {
        public void Main(string[] args)
        {
            //Console.WriteLine("Please type something and press the Enter key.");
            //string userValue;
            //userValue = Console.ReadLine();
            //Console.WriteLine("You typed:" + userValue);
            //Console.ReadLine();


            Console.WriteLine("Would you prefer what is behind door number 1, 2, or 3?");
            string userValue = Console.ReadLine();

            // string message ="";

            // if (userValue == "1")
            //   message = "You won a new car!";
            //   else if (userValue == "2")
            //  message = "You won a new boat!";
            // else if (userValue == "3")
            //   message = "You won a new dog";
            //else
            //  message = "Sorry, we didn't understand. You lose!";


            // Console.WriteLine(message);

            string message = (userValue == "1") ? "boat" : "stranf of lint";
            Console.WriteLine("You won a {0}", message);






            Console.ReadLine();

        }

    }





}


