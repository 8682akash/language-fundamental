using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass2009_1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the marks of physics");
            int phy=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the marks of chemistry");
            int chem=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the marks of maths");
            int math=Convert.ToInt32(Console.ReadLine());
            int total = phy+chem+math;
            Console.WriteLine("the marks of akash is" + total);
            double per = total * 100f / 300;
            Console.WriteLine("the percentage of akash is" + per);
            if (per < 100 && per >80)
            {
                Console.WriteLine("Grade A");
            }
            else if(per<80 && per>70)
            {
                Console.WriteLine("Grade B");
            }
            else if(per<70 && per > 60)
            {
                Console.WriteLine("Grade C");
                
            }
            else if (per<60 && per > 35)
            {
                Console.WriteLine("Grade D");
            }
            Console.WriteLine("Test");
          
        }
    }
}
