using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodApp_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the mark: ");
            int mark = Convert.ToInt32(Console.ReadLine());

            string grade = GetGrade(mark);
            Console.WriteLine("The grade is: " + grade);

            Console.ReadKey();
        }

        static string GetGrade(int mark)
        {
            int Mark = mark;
            string grade = "";

            if(Mark>=80 && Mark<=100)
            {
                grade = "A+";
            }
            else if(Mark>=70 && Mark<80)
            {
                grade = "A";
            }
            else if(Mark>=60 && Mark<70)
            {
                grade = "A-";
            }
            else if(Mark>=50 && Mark<60)
            {
                grade = "B";
            }
            else if(Mark>=40 && Mark<50)
            {
                grade = "C";
            }
            else if(Mark>=33 && Mark<40)
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
