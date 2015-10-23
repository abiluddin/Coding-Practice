using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelperMethods
{
    public class Program
    {
        public void Main(string[] args)
        {
            string myValue = superSecretFormula();
            Console.WriteLine(myValue);
            Console.ReadLine();


        }





        private string superSecretFormula()
        {
            // some cool stuff here
            return "HelloWorld";
        }
        private static string superSecretFormul(string name)
        {

            return String.Format("Hello, {0}!", name);

        }





    }


}
