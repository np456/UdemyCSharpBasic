using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyHelloWorld.TestClasses
{
    public class Iterations
    {
        public static void stringIterEx()
        {
            var name = "John Doe"; // iterate over enumerable object, sequence of characters

            foreach (var letter in name)
            {
                Console.WriteLine(letter);
            }
        }

        public static void whileLoop()
        {
            var i = 0; // better used in for loop because we know fixed number of iterations
            // while/do while when don't know number of iterations
            while (i <= 10)
            { 
            
            }
        }
    }
}
