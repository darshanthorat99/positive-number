using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace positive_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int num=Convert.ToInt32(Console.ReadLine());
            if (num > 0)
            {
                Console.WriteLine("number is positive");
            }
            else if(num < 0)
            {
                Console.WriteLine("number is negative");
            }
            else
            {
                Console.WriteLine("number is zero");
                Console.WriteLine("abdcnc");
            }
        }
    }
}
