using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyHelloWorld.TestClasses
{
    public class ValueVsReferenceTypes
    {

        public static void MemoryType()
        {
            var a = 10; // value type, intergers copy is stored in target b
            var b = a;  // reference type , references memory location with adress of object in heap
            b++;

            Console.WriteLine(string.Format("a: {0}, b: {1}", a, b));
            //Console.WriteLine(b);

            var array1 = new int[] { 1, 2, 3 };
            var array2 = array1;
            array2[0] = 0;
            Console.WriteLine(string.Format("array1[0]: {0}, array2[0]: {1}", array1[0], array2[0]));

        }
    }
}
