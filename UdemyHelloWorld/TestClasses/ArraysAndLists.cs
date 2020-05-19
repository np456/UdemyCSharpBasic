using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UdemyHelloWorld.TestClasses
{
    public class ArraysAndLists
    {
        public static void ArrayEx()
        {
            var numbers = new [] { 3, 1, 3, 4, 4 }; // replace by int[] by var for cleaner (resharper), also remove int before []
            //Console.WriteLine(numbers.Length);
            Console.WriteLine(Array.IndexOf(numbers, 1)); // 2nd parameter is object value looking for
            Array.Clear(numbers, 0, 2);
            Array.Sort(numbers);
            Array.Reverse(numbers);

            foreach (var item in numbers)
            {
                
                Console.WriteLine(item);
            }

            //var numbers2 = new int[] { }; // need int if declaring dynamic array won't work with copy need fixed declaration

            //Array.Copy(numbers, 0, numbers2, 0, 0);
            //foreach (var item in numbers2)
            //{
            //    Console.WriteLine(item);
            //}
            
        }

        public static void ListEx()
        {
            var numbers = new List<int>() {};   //defined in namespace System.Collections.Generic
            // no add method in array (since can't change size)
            // addrange - add more than one object to list
            // Ienumerable, any type prefixed with I stands for interface - if seen in C# intellisense can use an array or list there!
            // interface is implemented by different classes like the array or list, supply an instance of a class that implements Ienumerable
            numbers.Add(1);
            numbers.AddRange(new int[] { 3, 4, 5 });  // won't write like this in real world application
            // if objects known u want to store in list, initialise it ahead of time

            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Last index of: " + numbers.LastIndexOf(5)); // start search from end of list instead of beginning

            //etc.
        }

        public static void ex1()
        {
            Console.WriteLine("Please enter a number to store");
            var input = Console.ReadLine();
            var storeInput = new List<string>();

            while (!String.IsNullOrEmpty(input))
            {
                storeInput.Add(input);
                input = Console.ReadLine();
            }

            var totalNames = storeInput.Count;

            switch (totalNames)
            {
                case 0:
                    break;
                case 1:
                    Console.WriteLine($"{storeInput.SingleOrDefault()} likes your post.");
                    break;
                case 2:
                    Console.WriteLine($"{storeInput[0]} {storeInput[1]} like your post.");
                    break;
                default:
                    Console.WriteLine($"{storeInput[0]} {storeInput[1]} and {totalNames - 2} others like your post.");
                    break;
            }


        }

        public static void ex2()
        {

            Console.WriteLine("Please enter your name e.g. John Doe");
            var userName = Console.ReadLine().Split(' ');
            var reverseName = userName.Reverse();

            var fullName = String.Join(" ", reverseName);
            Console.WriteLine(fullName);

            // string non-primtives have their own methods for things

            //var formatName = new string[]{ };

            //Array.Copy(reverseName, 0, formatName, 0, userName.Length - 1);
        }

        public static void ex3()
        {
            Console.WriteLine("Enter 5 numbers");
            const int count = 5;
            var numbers = new List<int>();    // { } initialise (normally not needed for real case as usually initialised in the class constructor
            // use () for new list, as it isnew object of class that takes no params - see docs for example

            for (int i = 0; i < count; i++)
            {
                var temp = Convert.ToInt32(Console.ReadLine());

                while (numbers.Contains(temp))
                {
                    Console.WriteLine("Number entered already exists. Please enter another number.");
                    temp = Convert.ToInt32(Console.ReadLine());
                }

                numbers.Add(temp);
            }
            numbers.Sort();

            StringBuilder stringBuilder = new StringBuilder();

            foreach (var number in numbers)
            {
                stringBuilder.Append(number + ", ");
            }

            Console.WriteLine(stringBuilder.ToString());
            

        }

        /// <summary>
        /// TODO: fix this shit
        /// </summary>
        public static void ex4()
        {
            Console.WriteLine("Enter a number");
            var input = Console.ReadLine();
            string exitCommand = @"^quit$";
            var numbers = new List<int>();
            var isNumber = int.TryParse(input, out int _);

            Regex rx = new Regex(exitCommand, RegexOptions.IgnoreCase);
            MatchCollection matches = rx.Matches(exitCommand);
            
            while (isNumber && !rx.IsMatch(input))
            {

                Console.WriteLine("Enter another number or type quit to exit");
                //if(isNumber)
                numbers.Add(Convert.ToInt32(input));
                //if (isNumber)
                //{
                //    numbers.Add(Convert.ToInt32(input));
                //    //numbers.Add(n);
                //}
                //input = Console.ReadLine();
                input = Console.ReadLine();
                isNumber = int.TryParse(input, out int _);
            }

            //while (input.GetType() != typeof(int))
            //{
            //    Console.WriteLine("Enter another number or type quit to exit");
            //    input = Convert.ToInt32(Console.ReadLine());

            //    if(!rx.IsMatch(input))
            //}

            foreach (var item in numbers.Distinct())
            {
                if(numbers.Any())
                    Console.Write(item + ", ");
            }
  
        }

        public static void ex5()
        {
            Console.WriteLine("Enter list of comma seperated numbers e.g. 5,1,9,2,10");

            var input = Console.ReadLine();
            string pattern = "^[0-9]+(,[0-9]+)*$";

            Regex rx = new Regex(pattern, RegexOptions.IgnoreCase);
            MatchCollection matches = rx.Matches(pattern);

            int numberOfCommas = 0;

            if (rx.IsMatch(input))
            {
                foreach (var c in input)
                {
                    if (c == ',')
                    {
                        numberOfCommas++;
                    }
                    
                }

                if (numberOfCommas >= 4 && !String.IsNullOrWhiteSpace(input))
                {
                    var stringInput = input.Split(',');
                    var converted = (stringInput.Select(int.Parse)).OrderBy(n=>n);
                    //converted.OrderBy(n => n);

                    //int[] myInts = Array.ConvertAll(stringInput, s => int.Parse(s));
                    //myInts.OrderBy(n => n); doesernt work but no error because using too much var, NEED TO BE CAREFUL OF WORKING WITH ENUMERABLES VS ARRAYS!!


                    foreach (var item in stringInput)
                    {
                        //Int32.TryParse(stringInput[Convert.ToInt32(item)], out int _);
                        //Int32.Parse(item) = item;
                        //Convert.ToInt32(item);
                        //Console.WriteLine(item);
                        //Console.WriteLine(item.GetType());
                        //stringInput[item];

                        //var itemAsNumber = Convert.ToInt32(item);   //HAVE TO STORE IT IN VARIABLE OTHERWISE IT KEEPS STICKING AS STRING NO WONDER
                        // CANT USE INDEX BECAUSE FOREACH IS NOT THE SAME AS FOR LOOP!
                        

                        //dumbass, tryparse is not actually converting for you!!
                    }

                    //for (int i = 0; i < stringInput.Length; i++)
                    //{
                        //int num = Convert.ToInt32(stringInput[i]);
                        //stringInput[i] = num;
                    //}

                    
                    Console.WriteLine($"Smallest numbers in asc order: {converted.First()}, {converted.Skip(1).First()}, {converted.Skip(2).First()}");
                }
            }
            else
            {
                Console.WriteLine("Invalid list, please re-enter numbers");
            }


        }
        

    }
}
