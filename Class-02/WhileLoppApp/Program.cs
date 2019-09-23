using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoppApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
             while(true)
            {
                if(i % 2 != 0)
                {
                    i++;
                    continue;
                }
                Console.WriteLine(i);
                i++;
                if(i>100)
                {
                    break;
                }
            }
        }
    }
}
