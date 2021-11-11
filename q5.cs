using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    class q5
    {
        public void solution()
        {
            Console.WriteLine("Enter the numbers. Format: \"num1,num2\"");
            String s = Console.ReadLine();
            int loc_of_comma = -1;    // getting the location of comma
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ',')
                {
                    loc_of_comma = i;
                    break;
                }
            }
            String num1 = s.Substring(0, loc_of_comma);      // string sliced
            String num2 = s.Substring(loc_of_comma + 1);
            int a = int.Parse(num1);
            int b = int.Parse(num2);

            if (a == b)
            {
                Console.WriteLine(3 * (a + b));
            }
            else
            {
                Console.WriteLine(a + b);
            }
        }
    }
}
