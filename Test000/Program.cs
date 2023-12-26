using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jack
{
    class Program
    {
        static void Main(string[] args)
        {

            double x, y, z;
            Console.WriteLine("請輸入x值");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("請輸入y值");
            y = Convert.ToDouble(Console.ReadLine());


            if (x > y)
            {
                z = x;
                Console.WriteLine($"\"x比較大\",{z}");
            }
            else
            {
                z = y;
                Console.WriteLine($"\"y比較大\",{z}");
            }

            Console.ReadKey();
        }


    }
}



