using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    class q9
    {
        public void solution()
        {
            Console.WriteLine("Enter the string");
            String s = Console.ReadLine();
            if (AlmostOnlyLetters(s))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }


        public static bool AlmostOnlyLetters(String s)
        {
            foreach (char c in s)
            {
                int ascii = (int)c;
                if ((ascii < 65 || (ascii > 90 && ascii < 97) || ascii > 122) && !(c == ' '))
                {
                    return false;
                }
            }
            return true;
        }


    }
}
