using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace charwowel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the any alphabet");
            char ch = Convert.ToChar(Console.ReadLine());
            if(ch == 'a' || ch == 'e' || ch == 'i' || ch == '0' || ch == 'u' || ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
            {
                Console.WriteLine("char is vowel");

            }
            else
            {
                Console.WriteLine("char is consonants");
            }
        }
    }
}
