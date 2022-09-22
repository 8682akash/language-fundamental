using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mypractise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the first number");
            int num1=int.Parse(Console.ReadLine());
            Console.WriteLine("enter the second number");
            int num2 = int.Parse(Console.ReadLine());
            int temp;
            temp = num1;
            num1 = num2;
            num2 = temp;
            Console.WriteLine("number 1"+num1);
            Console.WriteLine("number 2"+num2);
        }
    }
}
