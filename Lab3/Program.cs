using System;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            // James - You don't have to do this line at all, you can just do your while loop
            // and say have it's condition be true, so...
            // while (true)
            string userChoice = "y";

            // James = I like that you are using string.ToLower() in this line, but I would maybe 
            // use string.Equals("y", StrinComparison.OrdinalCase)
            while (userChoice.ToLower() == "y")
            {
                // James - I would define this number closer to where the varialbe is 
                int number;
                string name;

                Console.WriteLine("Please enter your name");

                // James - I would initialize the variable where it's being defined here, 
                // string name = Console.ReadLine();
                name = Console.ReadLine();

                Console.WriteLine("Please enter an integer between 1 and 100.");
                string input = Console.ReadLine();

                if (!int.TryParse(input, out number))
                {
                    Console.WriteLine(name + "," + " you did not enter an integer!!");
                }

                // James - currently your program does not work correctly for 
                // number 100 and number 1.  I would change your condition to make sure
                // you are doing something for number 1 and number 100.
                else if (number >= 100 || number <= 1)
                {
                    Console.WriteLine(name + "," + " your number is not in the given range. Please try again!");
                }

                else if
                   ((number % 2 == 0) & (number >= 2) & (number <= 25))
                {
                    Console.WriteLine(name + "," + " the number is even and less than 25.");
                }
                else if
                    ((number % 2 == 0) & (number >= 26) & (number <= 60))
                {
                    Console.WriteLine(name + "," + " the number is even.");
                }

                else if
                ((number % 2 == 0) & (number > 60) & (number < 100))

                {
                    Console.WriteLine(name + ", " + number + " is even.");
                }

                else if
                    (number % 2 != 0)

                {
                    Console.WriteLine(name + ", " + number + " is odd.");
                }

                Console.WriteLine("Do you want to continue \"(y/n)\"?");
                userChoice = Console.ReadLine();
            }

        }
    }
}
