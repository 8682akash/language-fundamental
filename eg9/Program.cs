using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eg9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the two numbers");
            int num1=Convert.ToInt32(Console.ReadLine());
            int num2=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("1.add");
            Console.WriteLine("2.sub");
            Console.WriteLine("3.mul");
            Console.WriteLine("4.div");
            Console.WriteLine("5.mod");
            Console.WriteLine("select  the number of operation ");
            int number=Convert.ToInt32(Console.ReadLine());
            switch (number)
            {
                case 1:
                    int num3 = num1 + num2;
                    Console.WriteLine($"addition of {num1} and {num2} is "+num3);
                break;
                case 2:
                    int num4 = num1 - num2;
                    Console.WriteLine($"sub of {num1} and {num2} is " + num4);
                break;
                case 3:
                    int num5 = num1 * num2;
                    Console.WriteLine($"mul of {num1} and {num2} is " + num5);
                break;
                case 4:
                    int num6 = num1 / num2;
                    Console.WriteLine($"div of {num1} and {num2} is " + num6);
                break;
                case 5:
                    int num7 = num1 % num2;
                    Console.WriteLine($"mod of {num1} and {num2} is " + num7);
                break;
                default:
                    Console.WriteLine("wrong number of selection");
                break;

            }
        }
    }
}
