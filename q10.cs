using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    class q10
    {
        public void solution()
        {
            Console.WriteLine("For first operation");
            Console.Write("Enter the first operand:");
            int op1_1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the second operand:");
            int op1_2 = int.Parse(Console.ReadLine());
            Console.Write("enter the operator:");
            String operator1 = Console.ReadLine();

            Console.WriteLine("For second operation");
            Console.Write("Enter the first operand:");
            int op2_1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the second operand:");
            int op2_2 = int.Parse(Console.ReadLine());
            Console.Write("enter the operator:");
            String operator2 = Console.ReadLine();

            if (IsResultTheSame(getNumber(op1_1, op1_2, operator1), getNumber(op2_1, op2_2, operator2)))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("flase");
            }
        }




        public static bool IsResultTheSame(int a, int b)
        {
            return a == b;
        }

        public static int getNumber(int a, int b, String s)
        {
            switch (s)
            {
                case "+":
                    return a + b;
                case "-":
                    return a - b;
                case "/":
                    return (int)(a / b);
                case "*":
                    return a * b;
                default:
                    Console.WriteLine("Wrong operator given " + s + ". \nAvailable choices [+,-,*,\\]. Considering it as +.");
                    return a + b;
            }
        }
    }
}
