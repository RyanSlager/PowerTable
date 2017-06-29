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

            while (cont == "y")
            {
                string userNumber;
                double toPower;

                Console.WriteLine("Welcome to the Power Table Calculator! \nPlease enter a number, and you will receive all of the " +
                    "squares and cubes from one to your number!");

                userNumber = Console.ReadLine();

                while (!Double.TryParse(userNumber, out toPower) || toPower < 0)
                {
                    Console.WriteLine("Please enter a number greater than 0");
                    userNumber = Console.ReadLine();
                }

                Console.WriteLine("{0, -15}{1, -30}{2, -30}", "Number", "Squared", "Cubed");
                Console.WriteLine("{0, -15}{0, -30}{0, -30}\n", "=======");

                for(int i = 1; i < toPower + 1; i++)
                {
                    double[] pows = GetPows(i);
                    Console.WriteLine("{0,-15}{1,-30}{2, -30}\n", pows[0], pows[1], pows[2]);
                }
            }
        }
        
        public static double[] GetPows(double num)
        {
            double[] pows = new double[3];

            pows[0] = num;
            pows[1] = Math.Pow(num, 2);
            pows[2] = Math.Pow(num, 3);

            return pows;
        }


    }
}
