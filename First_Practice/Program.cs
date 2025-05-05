using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Strings
            Console.WriteLine("Enter Your First Name: ");
            string fname = Console.ReadLine();
            Console.WriteLine("Enter Your Last Name: ");
            string lname = Console.ReadLine();
            Console.WriteLine("Your name is " + fname + " " + lname + "."); //String concatination
            Console.WriteLine("Your name is {0} {1}.", fname, lname); //Placeholder syntax (preferred)

            Console.WriteLine("\n\n---------------------------\n\n");

            // Integers
            Console.WriteLine("Enter first Number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second Number: ");
            int num2 = int.Parse(Console.ReadLine());

            int sum = num1 + num2;
            Console.WriteLine("Total sum is {0} + {1} = {2}", num1, num2, sum);
        }
    }
}
