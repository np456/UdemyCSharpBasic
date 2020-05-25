using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyHelloWorld.TestClasses
{
    public class Strings
    {
        public static void stringDemo()
        {
            var sentence = "The quick brown fox jumped over the log";
            Console.WriteLine("Trim: '{0}'", sentence.Trim()); //placeholder enclose string with ' '  to see how trim works
            // can chain the methods, because each of these methods will return a new string object, not modify origianl string - immutable
            Console.WriteLine("Trim: '{0}'", sentence.Trim().ToUpper());
            // seperate substrings
            var index = sentence.IndexOf(' ');
            var substring = sentence.Substring(0, index);
            var substring2 = sentence.Substring(index + 1);
            Console.WriteLine($"{index}, {substring}, {substring2}");
            // easier way - using split
            var words = sentence.Split(' ');
            Console.WriteLine(words[0]);
            // use index of and substring method for more complex string split tasks
            sentence.Replace("quick", "slow"); // don't need to save to var, can also use a char
            // all these methods return new strings, original string now affected!

            // empty strings/null - user input validation, what about white spaces as input " "?
            if (String.IsNullOrEmpty("") || String.IsNullOrEmpty(null) || String.IsNullOrEmpty(" ".Trim()))
            {
                Console.WriteLine("error");
            }
            // always trim string first then pass it to isnull or empty method - old way above for " ", see new below
            if(string.IsNullOrWhiteSpace(" "))
            {

            }
            // convert between numbers and string
            // use convert or parse
            float price = 29.95f;
            price.ToString("C0");
        }

        public static void summarisingText()
        {
            var sentence = @"VERY Vvery very very long text
                bla bla bla bla.";
            var summary = SummeriseText(sentence);
            Console.WriteLine(summary);
            var summary2 = SummeriseText(sentence, 30);
            Console.WriteLine(summary2);
            /// code here moved to below method
        }

        static string SummeriseText(string sentence, int MAX_LENGTH = 20)
        {

            //const int MAX_LENGTH = 20; //remove the hard coded literal and parse as a 2nd param
            // set a default value in case caller of the method does not wish to specify max length argument

            //check if sentence length
            if (sentence.Length < MAX_LENGTH)
            {
                //Console.WriteLine(sentence.Length);
                return sentence;
            }
            // summarise sentence
            // removed else statement (not needed)
            // don't need to store return value as a var

            //sentence.Substring(0, MAX_LENGTH); // not good because cut off words as result of substring
            // take into account word boundaries instead of above, count words to fix 20 characters
            var words = sentence.Split(' ');
            var totalChars = 0;
            var summaryWords = new List<string>();

            foreach (var word in words)
            {
                summaryWords.Add(word);

                totalChars += word.Length + 1; // for spacing
                if (totalChars > MAX_LENGTH)
                {
                    break;
                }
            }

            //var summary = string.Join(" ", summaryWords) + "...";
            //return summary;

            return string.Join(" ", summaryWords) + "...";

            // all this logic should be moved to a seperate method or function - real world for re-use - done
        }

        public static void StringBuilderEx()
        {
            // situations involving a lot of string manipulation operations
            // class defined in system.text namespace, representing a mutable string
            // unlike string class, it's not optimised for searching i.e. missing methods e.g. indexOf(), contains()...
            // instead has methods for manipulating strings e.g. append(), insert(), clear() etc.

            StringBuilder stringBuilder = new StringBuilder("Hello World!");

            // easy to manipulate, but no string searching methods
            stringBuilder.Append('-', 10) // see overloads
            //stringBuilder.AppendLine();
            .AppendLine(); // ----> all these methods return stringBuilder object, hence can chain methods easily
            stringBuilder.Append("Header");
            stringBuilder.AppendLine();
            stringBuilder.Append('-', 10); // see overloads

            stringBuilder.Replace('-', '+');
            stringBuilder.Remove(0, 10);
            stringBuilder.Insert(0, new string('-', 10));

            // faster than using string and its manipulation options - keep creating new string ojbects in memory and returns it
            // large number of these can cause issues
            // stringbuilder is hence, much better

            Console.WriteLine(stringBuilder);

            Console.WriteLine(stringBuilder[0]);

            // append() signature returns a stringbuilder, it is not void method
            // can change append method() - see above

        }
        
        public static void Ex1()
        {
            Console.WriteLine("Enter numbers seperated by hyphen e.g. 5-6-7-8-9");
            var input = Console.ReadLine();

            var chars = input.Split('-');
            bool isConsecutive = true;

            for (int i = 1; i < chars.Length; i++)
            {
                
                if (Convert.ToInt32(chars[i]) != Convert.ToInt32(chars[i-1]) + 1)
                {
                    isConsecutive = false;
                    Console.WriteLine("Not consecutive");
                    break;
                }
            }

            if (isConsecutive == true)
            {
                Console.WriteLine("Consecutive");
            }
            //int previous = Convert.ToInt32(chars.First());
            //int current;
            //bool consecutive = true;

            //foreach (var item in chars)
            //{
            //    current = Convert.ToInt32(item);

            //    if (    current - 1)
            //    {
            //        consecutive = false;
            //        Console.WriteLine("Not consecutive");
            //        break;
            //    }

            //    previous = current;
            //}
            
            //if(consecutive)
            //    Console.WriteLine("Consecutive");

        }

    }
}
