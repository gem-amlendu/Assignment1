using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    class q8
    {
        public void solution()
        {
            Console.WriteLine("Enter the string");
            string s = Console.ReadLine();
            if (IfConsistsOfUppercaseLetters(s))
            {
                Console.WriteLine("true");
            }
            else
            {
                //Console.WriteLine("All letters are not upper case");
                Console.WriteLine("false");
            }
        }

        public static bool IfConsistsOfUppercaseLetters(String s)
        {
            foreach (char c in s)
            {
                int ascii = (int)c;
                if (ascii < 65 || ascii > 90)
                {
                    return false;
                }
            }
            return true;
        }

    }
}
