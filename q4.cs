using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    class q4
    {
        public void solution()
        {
            Console.Write("Enter first number:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number:");
            int b = Convert.ToInt32(Console.ReadLine());
            if ((a >= -10 && a <= 10) || (b <= 10 && b >= -10))
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("Flase");
            }
        }
    }
}
