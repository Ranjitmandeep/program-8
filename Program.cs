using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program_8
{
    class Program
    // This program will check the number whether it is positive or negative.
    {
        static void Main(string[] args)
        {
            int num;
            Console.Write("\n\n");
            Console.Write("Check whether a number is positive or negative:\n");
            Console.Write("----------------------------------------------");
            Console.Write("\n\n");
            Console.Write("Input an integer : ");
            num = Convert.ToInt32(Console.ReadLine());
            if (num >= 0)

                Console.WriteLine("{0} is a positive number.\n", num);
            else
                Console.WriteLine("{0} is a negative number. \n", num);
        }
    }
}
