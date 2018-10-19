﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            string userChoice = "y";
            while (userChoice.ToLower() == "y")
            {

                int number;
                string name;

                Console.WriteLine("Please enter your name");
                name = Console.ReadLine();

                Console.WriteLine("Please enter an integer between 1 and 100");
                number = int.Parse(Console.ReadLine());

                if (number >= 100 || number <= 1 )
                {
                    Console.WriteLine(name + " your number is not in the given range. Please try again!");
                }
                 
                else if
                   ((number % 2 == 0) & (number >= 2) & (number <= 25))
                {
                    Console.WriteLine(name + " the number is even and less than 25");
                }
                else if
                    ((number % 2 == 0) & (number >= 26) & (number <= 60))
                {
                    Console.WriteLine(name + " the number is even");
                }

                else if
                ((number % 2 == 0) & (number > 60) & (number < 100))

                {
                    Console.WriteLine(name + number + " is even");
                }

                else if
                    (number % 2 != 0)

                {
                    Console.WriteLine(name +", " +  number + " is odd");
                }

                Console.WriteLine("Do you want to continue \"(y/n)\"?");
                userChoice = Console.ReadLine();
            }

        }
    }
}
