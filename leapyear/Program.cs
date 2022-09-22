using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leapyear
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a any year");
            int year = Convert.ToInt32(Console.ReadLine());
            if(year % 4 == 0)
            {
                Console.WriteLine("year is leap year");
            }
            else
            {
                Console.WriteLine("year is not leap year");
            }
        }
    }
}
