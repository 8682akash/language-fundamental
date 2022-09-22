using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace positivenega
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter any number");
            int num=Convert.ToInt32(Console.ReadLine());
            if (num >0)
            {
                Console.WriteLine("num is positive");
            }
            else if(num <0)
            {
                Console.WriteLine("num is negative");
            }
            else
            {
                Console.WriteLine("num is zero");
            }
        }
    }
}
