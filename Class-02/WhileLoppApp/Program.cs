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
                i++;
                if(i == 100)
                {
                    break;
                }

                if(i%2 == 1)
                {
                    continue;
                }

                Console.WriteLine(i);
            }
        }
    }
}
