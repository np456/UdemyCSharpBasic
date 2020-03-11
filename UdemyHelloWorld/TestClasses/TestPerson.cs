using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyHelloWorld.TestClasses
{
    public class TestPerson
    {
        public string FirstName;
        public string LastName;
        public int Age;

        public void Introduce()
        {
            Console.WriteLine("My name is " + FirstName + " " + LastName);
        }

        public static void Ageing(int Age)
        {
            Age += 5;
            Console.WriteLine(Age);
        }

        public static void GetOld(TestPerson testPerson)
        {
            testPerson.Age += 50;
            Console.WriteLine(testPerson.Age);
        }
    }
}
