using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

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

        public static void ex2()
        {

            try {
                
                Console.WriteLine("Enter a interger");
                var input1 = Convert.ToInt32(Console.ReadLine());

            while (input1.GetType() != typeof(int))
                {
                    Console.WriteLine("Input must be an interger!");
                    input1 = Convert.ToInt32(Console.ReadLine());
            }

                Console.WriteLine("Enter another interger");
                var input2 = Convert.ToInt32(Console.ReadLine());

            while (input2.GetType() != typeof(int))
                {
                    Console.WriteLine("Input must be an interger!");
                    input1 = Convert.ToInt32(Console.ReadLine());
            }

                Console.WriteLine(Math.Max(input1, input2).ToString() + " is the larger interger");

            }
            catch(Exception)
            {
                Console.WriteLine("One of the numbers entered is not a valid interger");

            }
        }

        public static void ex3()
        {
            // To 1.d.p
            Console.Write("Enter width: ");
            float width = Convert.ToInt16(Console.ReadLine());

            Console.Write("Enter height: ");
            float height = Convert.ToInt16(Console.ReadLine());

            if (width < height)
            {
                Console.WriteLine(ImageOrientation.Vertical);
            }
            else if (height < width)
            {
                Console.WriteLine(ImageOrientation.Horizontal);
            }
            else
            {
                Console.WriteLine("Image can be both landscape and portrait");
            }
        }

        public static void ex4()
        {
            Console.WriteLine("Please enter speed limit");
            int speedLimit = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter speed car is travelling");
            int carSpeed = Convert.ToInt32(Console.ReadLine());

            int demeritPoints;
            const int demeritThreshold = 5;

            if (carSpeed <= speedLimit)
            {
                Console.WriteLine("OK");
            }
            else if (carSpeed > speedLimit)
            {
                var difference = carSpeed - speedLimit;

                demeritPoints = difference / demeritThreshold;

                if (demeritPoints > 12)
                {
                    Console.WriteLine("License suspended");
                }
                else
                    Console.WriteLine("Number of demerit points: "+ demeritPoints.ToString());
                

            }
            else
            {
                Console.WriteLine("Invalid input");
            }

        }
    }
}
