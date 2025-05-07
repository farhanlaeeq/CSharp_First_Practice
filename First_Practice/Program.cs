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
            Console.WriteLine("-------------STRINGS--------------");
            Console.WriteLine("Enter Your First Name: ");
            string fname = Console.ReadLine();
            Console.WriteLine("Enter Your Last Name: ");
            string lname = Console.ReadLine();
            Console.WriteLine("Your name is " + fname + " " + lname + "."); //String concatination
            Console.WriteLine("Your name is {0} {1}.", fname, lname); //Placeholder syntax (preferred)


            // Integers
            Console.WriteLine("\n\n-------------INTEGERS--------------");
            Console.WriteLine("Enter first Number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second Number: ");
            int num2 = int.Parse(Console.ReadLine());

            int sum = num1 + num2;
            Console.WriteLine("Total sum is {0} + {1} = {2}", num1, num2, sum);


            // Arithmetic Operators +, -, *, /, %
            Console.WriteLine("\n\n--------------ARITHMETIC OPERATORS-------------");
            int number1 = 0, number2 = 0, totalSum;
            Console.WriteLine("Enter first Number: ");
            number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second Number: ");
            number2 = int.Parse(Console.ReadLine());

            totalSum = number1 + number2;
            Console.WriteLine("Addition: {0} + {1} = {2}", number1, number2, totalSum);
            Console.WriteLine("Subtraction: {0} - {1} = {2}", number1, number2, number1-number2);
            Console.WriteLine("Multiplication: {0} * {1} = {2}", number1, number2, number1*number2);
            Console.WriteLine("Division: {0} / {1} = {2}", number1, number2, number1/number2);
            Console.WriteLine("Modulus: {0} % {1} = {2}", number1, number2, number1%number2);
        }
    }
}
