using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first name: ");
            string firstName = Console.ReadLine();

            Console.Write("Enter the middle name: ");
            string middleName = Console.ReadLine();

            Console.Write("Enter the last name: ");
            string lastName = Console.ReadLine();

            string fullName = AddName(firstName, middleName, lastName);

            Console.WriteLine("The full name is: " + fullName);

            Console.ReadKey();
            
        }

        static string AddName(string firstName, string midName, string lastName)
        {
            string fName = firstName;
            string mName = midName;
            string lName = lastName;

            string fullName = fName + mName + lastName;

            return fullName;
        }
    }
}
