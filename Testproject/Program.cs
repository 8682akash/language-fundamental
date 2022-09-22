using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testproject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("this is my first programme");
            int age = 21;
            string city = "pune";
            float per = 79.76f;

            Console.WriteLine("age is"+ age+"my city is"+ city+"my per is"+ per);
            Console.WriteLine("age is {0} city is{1} per is {2}",age,city,per);
           Console.WriteLine($"age is {age} city is {city} per is {per}");
        }
    }
}
