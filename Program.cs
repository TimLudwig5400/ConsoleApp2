using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Test for Define Constants");
            string test = "";
#if USI
                test = "USI";
#elif CTC
                test = "CTC";
#elif PW
                test = "Partswatch";
#endif

            Console.WriteLine(test);

        }
    }
}
