using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    class q3
    {
        public void solution()
        {
            Console.Write("Input the first number:");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Input the second number:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("After swapping:");
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("First number:" + a + "\nSecond number:" + b);
        }
    }
}
