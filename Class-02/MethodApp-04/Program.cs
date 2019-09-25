using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodApp_04
{
    class Program
    {
        static void Main(string[] args)
        {
            string status = "";

            do {
                Console.Write("Enter First Name: ");
                string firstName = Console.ReadLine();

                Console.Write("Enter Last Name: ");
                string lastName = Console.ReadLine();

                Console.Write("Enter Subject: ");
                string subject = Console.ReadLine();

                Console.Write("Enter Mark: ");
                int mark = Convert.ToInt32(Console.ReadLine());

                string fullName = GetFullName(firstName, lastName);

                string grade = GetGrade(mark);

                bool isPassed = GetResultStatus(mark);

                if (isPassed)
                {
                    Console.WriteLine("Hello! " + fullName + " Congratulation! You have passed in " + subject + ".\nAnd your grade is: " + grade);
                }
                else
                {
                    Console.WriteLine("Sorry you have failed!");
                }

                Console.WriteLine("Do you want to continue (y/n)?");
                status = Console.ReadLine();
            }
            while (status == "y");

            Console.ReadKey();
        }

        private static bool GetResultStatus(int mark)
        {
            return (mark >= 33);
        }

        private static string GetFullName(string firstName, string lastName)
        {
            string fName = firstName;
            string lName = lastName;

            string fullName = fName + " " + lastName;

            return fullName;
        }

        private static string GetGrade(int mark)
        {
            int Mark = mark;
            string grade = "";

            if (Mark >= 80 && Mark <= 100)
            {
                grade = "A+";
            }
            else if (Mark >= 70 && Mark < 80)
            {
                grade = "A";
            }
            else if (Mark >= 60 && Mark < 70)
            {
                grade = "A-";
            }
            else if (Mark >= 50 && Mark < 60)
            {
                grade = "B";
            }
            else if (Mark >= 40 && Mark < 50)
            {
                grade = "C";
            }
            else if (Mark >= 33 && Mark < 40)
            {
                grade = "D";
            }
            else
            {
                grade = "F";
            }

            return grade;
        }
    }
}
