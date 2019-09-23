using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodApp_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first number: ");
            int firstNumber =Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the third number: ");
            int thirdNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the fourth number: ");
            int fourthNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the fifth number: ");
            int fifthNumber = Convert.ToInt32(Console.ReadLine());

            int average = FindAverage(firstNumber, secondNumber, thirdNumber, fourthNumber, fifthNumber);

            Console.WriteLine("The average is: " + average);
            Console.ReadKey();
        }

        static int FindAverage(int firstNumber, int secondNumber, int thirdNumber, int fourthNumber, int fifthNumber)
        {
            int number1 = firstNumber;
            int number2 = secondNumber;
            int number3 = thirdNumber;
            int number4 = fourthNumber;
            int number5 = fifthNumber;

            int average = (number1 + number2 + number3 + number4 + number5) / 5;

            return average;
        }
    }
}
