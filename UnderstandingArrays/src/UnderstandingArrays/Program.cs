using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UnderstandingArrays
{
    public class Program
    {
        public void Main(string[] args)
        {
            int[] numbers = new int[5];
            /*
            numbers[0] = 4;
            numbers[1] = 8;
            numbers[2] = 15;
            numbers[3] = 16;
            numbers[4] = 23;
            numbers[5] = 42;
            */

            /*
            int[] numbers = new int[] { 4, 8, 15, 26, 23, 42 };

            Console.WriteLine(numbers[1].ToString());
            Console.ReadLine();
             */

            string[] names = new string[] { "Eddie"," Alex", "Michael", "David Lee" };

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();
                                



        }

    }
}
