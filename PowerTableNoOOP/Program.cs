using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerTableNoOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            string cont = "y";

            Console.WriteLine("Welcome to the Power Table Calculator! What is your name?");
            string uName = Console.ReadLine();

            while (cont == "y")
            {
                string userNumber;
                double toPower;
                
                // user is prompted to give a valid number

                Console.WriteLine($"{uName}, please enter a number, and you will receive all of the " +
                    "squares and cubes from one to your number!");

                userNumber = Console.ReadLine();

                while (!Double.TryParse(userNumber, out toPower) || toPower < 1)
                {
                    Console.WriteLine("Please enter a number greater than 0");
                    userNumber = Console.ReadLine();
                }

                // header is printed in the correct format

                Console.WriteLine("{0, -15}{1, -30}{2, -30}", "Number", "Squared", "Cubed");
                Console.WriteLine("{0, -15}{0, -30}{0, -30}\n", "=======");

                // from i=1 to i=toPower, i is passed into GetPows and the three results are printed on a new line

                for(int i = 1; i < toPower + 1; i++)
                {
                    double[] pows = GetPows(i);
                    Console.WriteLine("{0,-15}{1,-30}{2, -30}\n", pows[0], pows[1], pows[2]);
                }

                //user is prompted to continue or quit

                Console.WriteLine($"{uName}, would you like to continue? (y/n)");
                cont = Console.ReadLine();

                // user input for cont is checked

                while (cont != "y" && cont != "n")
                {
                    Console.WriteLine($"{uName}, please enter y to continue or n to quit.");
                    cont = Console.ReadLine();
                }
            }
        }
        
        // GetPows takes a double and returns an array of doubles where double[0] is the original number,
        // double[1] is the square, and double[2] is the cube

        public static double[] GetPows(double num)
        {
            double[] pows = new double[] { num, Math.Pow(num, 2), Math.Pow(num, 3) };

            return pows;
        }


    }
}
