using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace greatestnum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the three numbers");
            int num1=Convert.ToInt32(Console.ReadLine());
            int num2=Convert.ToInt32(Console.ReadLine());   
            int num3=Convert.ToInt32(Console.ReadLine());
            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.WriteLine($"{num1} is greatest number");
                }
            }
            else if (num2 > num3)
            {
                if (num2 > num1)
                {
                    Console.WriteLine($"{num2} is greatest number");
                }
            }
            else
            {
                Console.WriteLine($"{num3} is a greatest number");
            }
            }
        }
    
}
 