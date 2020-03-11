using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyHelloWorld.TestClasses
{
    public class ControlFlow
    {

        public static void checkGoldCustomer()
        {
            bool isGoldCustomer = true;

            //float price;
            //if (isGoldCustomer)
            //{
            //    price = 19.99f;
            //}
            //else
            //{
            //    price = 29.99f;
            //}

            float price = isGoldCustomer ? 19.99f : 29.99f;
            Console.WriteLine(price);
        }

        public static void ex1()
        {

            Console.WriteLine("Enter a number between 1 and 10");
            var userInput = Convert.ToInt32(Console.ReadLine());


            while (userInput < 1 || userInput > 10)
            {
                Console.WriteLine("Invalid number, please input an integer between 1 and 10");

                userInput = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Valid");

        }

    }
}
