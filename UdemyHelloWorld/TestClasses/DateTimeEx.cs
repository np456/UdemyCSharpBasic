using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyHelloWorld.TestClasses
{
    public class DateTimeEx
    {
        public static void Notes()
        {
            var dateTime = new DateTime(2015, 1, 1);  //constructor multiple overloads
            var now = DateTime.Now; // static property of datetime structure
            var today = DateTime.Today;

            Console.WriteLine(now.Hour);
            Console.WriteLine(now.Minute);
            // datetime objects are immutable, if want to modify need to use methods e.g. add

            var tomorrow = now.AddDays(1);
            var yesterday = now.AddDays(-1);

            //formatting datetime objects to string
            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(now.ToShortTimeString());
            Console.WriteLine(now.ToString()); //display time and date

            //format specifiers
            Console.WriteLine(now.ToString("")); // e.g. parseing in XML/JSON need dates as dd-mm-yyyy HH:mm search custom date and date format strings ms docs

            
            var timeSpan = new TimeSpan(1, 2, 3);
            var timeSpan1 = new TimeSpan(1, 0, 0);  // to make this more readable, use static methods on timespan structure instead of using 0's for empty values
            var timeSpan2 = TimeSpan.FromHours(1); //more readable then row above

            // another way to represent above example
            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);
            var duration = end - start;

            //timespan properties coming in pairs
            Console.WriteLine(timeSpan.Minutes); //return minutes property of object
            Console.WriteLine(timeSpan.TotalMinutes); // converts all time values into total minutes

            //similar to DT object, timespan is immutable need methods to modify its values, returning a new timeSpan object
            Console.WriteLine(timeSpan.Add(new TimeSpan(8)));  //either takes a new object or use existing one
            Console.WriteLine(timeSpan.Add(TimeSpan.FromMinutes(8)));
            Console.WriteLine(timeSpan.Subtract(TimeSpan.FromMinutes(2))); // subtracts from our timespawn object

            //convert from timespan to and from string
            Console.WriteLine(timeSpan.ToString()); //greyed out methods by default mean it already has peformed that method by default
            Console.WriteLine(TimeSpan.Parse("01:02:03")); //return timespawn object from string

        }
    }
}
