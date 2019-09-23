using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatatypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1212121212;
            long j = 2323232323232323232;

            j = i; //implicit conversion
            //Console.WriteLine(j);

            string number = "3";
            i = Convert.ToInt32(number); //explicit conversion
            //Console.WriteLine(i);

            char c = 'u';
            i = c; //implicit conversion
            Console.WriteLine(i);

            char b = (char) 123; //explicit conversion

            //Console.WriteLine(b);

            Console.ReadKey();
        }
    }
}
