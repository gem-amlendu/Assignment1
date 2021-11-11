using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    class q6
    {
        public void solution()
        {
            String username = "vasu";
            String password = "p@ssword";
            int tries = 3;
            int flag = 0;
            while (tries > 0)
            {
                if (tries < 3)
                {
                    Console.WriteLine("WRONG PASSWORD!!!!");
                    Console.WriteLine(tries + " tries left.....");
                }
                Console.WriteLine("Enter username and password");
                Console.Write("Username: ");
                String testUsername = Console.ReadLine();
                Console.Write("Password: ");
                String testPassword = Console.ReadLine();

                if (username == testUsername && password == testPassword)
                {
                    flag = 1;
                    break;
                }

                tries--;
            }

            if (flag == 1)
            {
                Console.WriteLine("Welcome " + username);
            }
            else
            {
                Console.WriteLine("you are rejected ----- wrong credentials ------");
            }
        }
    }
}
