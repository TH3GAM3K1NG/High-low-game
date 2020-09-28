using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace High_low
{
    class Program
    {
        static void Main(string[] args)
        {
            //welcome message
            Console.WriteLine("welcome to the high low game");
            Console.WriteLine("press any key to proceed");
            Console.ReadKey();
            //generates rng
            Random rng = new Random();
            //generates number
            int number = rng.Next(1, 11);
            //displays the number (for testing)
            //Console.WriteLine(number);

            //tracks number of tries taken
            int Tries = new int();

            while (true)
            {
                try
                {

                    //enter users guess
                    Console.WriteLine();
                    Console.Write("Input guess (1-10): ");
                    int guess = Convert.ToInt32(Console.ReadLine());
                    //compares the guess to the number
                    if (guess < number)
                    {
                        Console.WriteLine("guess is too low, go higher");
                        Tries = Tries + 1;
                    }

                    else if (guess > number)
                    {
                        Console.WriteLine("guess is too high, go lower");
                        Tries = Tries + 1;
                    }

                    else
                    {
                        Tries = Tries + 1;
                        Console.WriteLine("Correct and you only took " + Tries + " tries, good job");
                        Console.WriteLine("Press any key to exit");
                        break;
                    }

                }

                catch
                {
                    Console.WriteLine("There has been an error please type a number");
                }
            }

            Console.ReadKey();
        }
    }
}
