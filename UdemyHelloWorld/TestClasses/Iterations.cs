using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

        public static void randomIterationEx()
        {
            var random = new Random();

            const int stringLength = 10;
            var buffer = new char[stringLength];

            for (int i = 0; i < stringLength; i++)
            {
                //Console.Write((char)random.Next(0, 26));
                //buffer[i] = (char)random.Next(97, 122);   // ASCII mapping
                buffer[i] = (char)('a' + random.Next(0, 26));   // english alphabet, add to character 'a' to use english alphabet

            }

            // createing strings e.g. literal declaration var string = "" or use new string() method - see overloads
            var randomString = new string(buffer);
            Console.WriteLine(randomString);

        }

        public static void ex1()
        {
            const int length = 100;
            const int divisible = 3;
            var count = 0;

            for (int i = 0; i < length; i++)
            {
                if (i % divisible == 0)
                {
                    count++;
                }

            }

            Console.WriteLine("Total numbers with no remainder: " + count);

        }

        public static void ex2()
        {
            //  Console.WriteLine("Enter a number or press ok to exit");
            //  var userInput = Console.ReadLine();
            //  var isNumeric = int.TryParse(userInput, out int n);

            //  var rx = new Regex(@"\b(?<ok>\w+)\s+(\k<ok>)\b",
            //RegexOptions.Compiled | RegexOptions.IgnoreCase);


            //  while (!rx.IsMatch(userInput) || !isNumeric)
            //  {
            //      userInput = Console.ReadLine();
            //  }

            //  Console.WriteLine();

            Console.WriteLine("Enter a number");
            var userInput = Console.ReadLine();
            var isNumeric = double.TryParse(userInput, out double n); // if u need it to accept integers, doubles etc. just use the larger type!
            double total = 0.0;  // can't use var without initialising the variable
            //var isNumericNative = userInput.All(char.IsDigit); no work lolll

            while (isNumeric)
            {
                total += Convert.ToDouble(userInput);

                userInput = Console.ReadLine();
                if (userInput == "ok")
                {
                    Console.WriteLine("The sum of numbers entered is: " + total);
                    break;
                }

            }

        }

        public static void ex3()
        {
            Console.WriteLine("Please enter a number");
            var userNumber = Convert.ToInt32(Console.ReadLine());
            int factorial = userNumber;

            for (int i = userNumber - 1; i > 0; i--)
            {
                factorial = factorial * i;
            }

            Console.WriteLine(factorial);

        }

        public static void ex4()
        {

            var randomNum = new Random();
            var numToGuess = randomNum.Next(1, 10);

            Console.WriteLine("Guess a number");
            int userGuess = Convert.ToInt32(Console.ReadLine());
            const int numberOfGuesses = 3;
            int guessesRemaining = 3;
            Console.WriteLine(guessesRemaining);

            for (int i = numberOfGuesses; i > 0; i--)
            {
                if (userGuess == numToGuess)
                {
                    Console.WriteLine("You won");
                    break;
                }
                Console.WriteLine("Wrong!");
                userGuess = Convert.ToInt32(Console.ReadLine());
                guessesRemaining = i - 1;
                Console.WriteLine(guessesRemaining);

                if (guessesRemaining == 0)
                {
                    Console.WriteLine("You lost");
                }
            }

        }

        public static void ex5()
        {
            Console.WriteLine("Enter a series of numbers seperated by comma e.g. 1, 2, 3");
            //var input = Console.ReadLine();
            //var storeIntegers = new List<int>();

            //foreach (var character in input)
            //{

            //    int.TryParse(character, out int n);
            //}

            var numbers = Console.ReadLine().Split(',');
            var max = Convert.ToInt32(numbers[0]);

            foreach (var num in numbers)
            {
                var number = Convert.ToInt32(num);
                if (number > max)
                {
                    max = number;
                }
            }

            Console.WriteLine("Max is " + max);

        }

    }
}
