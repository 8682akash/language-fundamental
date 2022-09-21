using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass2009_2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the BS");
            int BS=Convert.ToInt32(Console.ReadLine());
            if( BS <= 10000)
            {
                int DA = (BS * 80) / 100;
                int HRA = (BS * 20) / 100;
                int GS = BS + DA + HRA;
                Console.WriteLine("gross sallary is " + GS);
            }else if (BS <= 20000)
            {
                int DA1 = (BS * 90) / 100;
                int HRA1 = (BS * 35) / 100;
                int GS1 = (BS + DA1) + HRA1;
                Console.WriteLine("gross sallary is " + GS1);
            }
            else
            {
                int DA2 = (BS * 95) / 100;
                int HRA2 = (BS * 40) / 100;
                int GS2 = (BS + DA2) + HRA2;
                Console.WriteLine("gross sallary is " + GS2);
            }
        }
    }
}
