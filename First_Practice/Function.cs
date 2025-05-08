using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_Practice
{
    public class Functions
    {
        public static void StringConcatFunc()
        {
            Console.WriteLine("Enter Your First Name: ");
            string fname = Console.ReadLine();
            Console.WriteLine("Enter Your Last Name: ");
            string lname = Console.ReadLine();
            Console.WriteLine("Your name is " + fname + " " + lname + "."); //String concatination
            Console.WriteLine("Your name is {0} {1}.", fname, lname); //Placeholder syntax (preferred)
        }

        public static void IntegersFunc()
        {
            Console.WriteLine("Enter first Number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second Number: ");
            int num2 = int.Parse(Console.ReadLine());

            int sum = num1 + num2;
            Console.WriteLine("Total sum is {0} + {1} = {2}", num1, num2, sum);
        }

        public static void ArithmeticOperatorFunc()
        {
            int number1 = 0, number2 = 0, totalSum;
            Console.WriteLine("Enter first Number: ");
            number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second Number: ");
            number2 = int.Parse(Console.ReadLine());

            totalSum = number1 + number2;
            Console.WriteLine("Addition: {0} + {1} = {2}", number1, number2, totalSum);
            Console.WriteLine("Subtraction: {0} - {1} = {2}", number1, number2, number1 - number2);
            Console.WriteLine("Multiplication: {0} * {1} = {2}", number1, number2, number1 * number2);
            Console.WriteLine("Division: {0} / {1} = {2}", number1, number2, number1 / number2);
            Console.WriteLine("Modulus: {0} % {1} = {2}", number1, number2, number1 % number2);
        }

        public static int ConditionalOperatorFunc(int num1, int num2)
        {
            if (num1 > num2)
            {
                return 1;
            }
            else if (num1 < num2)
            {
                return 0;
            } else
            {
                return -1;
            }
        }

        public static void SwitchOperatorFunc()
        {
            int week_number = 10;

            switch (week_number)
            {
                case 0:
                    Console.WriteLine("its zero");
                    break;
                case 5:
                    Console.WriteLine("its five");
                    break;
                case 10:
                    Console.WriteLine("its ten");
                    break;
                default:
                    Console.WriteLine("nothing");
                    break;
            }
        }

        public static void Calculator()
        {
            int number1 = 0, number2 = 0;
            string operation = "";
            string tryAgain = "Y";



            while (tryAgain == "Y" || tryAgain == "y") 
            {
                Console.WriteLine("Enter first Number: ");
                number1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter second Number: ");
                number2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Select an operation ( + , - , * , / , % ): ");
                operation = Console.ReadLine();

                switch (operation)
                {
                    case "+":
                        Console.WriteLine("Addition: {0} + {1} = {2}", number1, number2, number1 + number2);
                        break;
                    case "-":
                        Console.WriteLine("Subtraction: {0} - {1} = {2}", number1, number2, number1 - number2);
                        break;
                    case "*":
                        Console.WriteLine("Multiplication: {0} * {1} = {2}", number1, number2, number1 * number2);
                        break;
                    case "/":
                        Console.WriteLine("Division: {0} / {1} = {2}", number1, number2, number1 / number2);
                        break;
                    case "%":
                        Console.WriteLine("Modulus: {0} % {1} = {2}", number1, number2, number1 % number2);
                        break;
                    default:
                        Console.WriteLine("Wreon Operation");
                        break;
                }

                Console.WriteLine("\nDo you want to try another operation? (Y/N):  ");
                tryAgain = Console.ReadLine();
            }
        }

        public static void ForLoopFunc()
        {
            string[] names = { "Farhan", "Zain", "Qasim", "Mehmood" };

            for (int i = 0; i < names.Length; i++) 
            {
                Console.WriteLine(names[i]);
            }
        }

        public static void VowelsCountFunc() 
        {
            char[] names = { 'a', 'e', 'i', 'o', 'u' };
            string text = "aettaeizzaeiouffiourr";
            List<int> counts = new List<int>();
            bool isTrailing = false;
            int count = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (names.Contains(text[i]) && i == (text.Length - 1))
                {
                    count++;
                    counts.Add(count);
                } else if (names.Contains(text[i]))
                {
                        count++;
                }
                else if (count > 0)
                {
                    counts.Add(count);
                    count = 0;
                }
            }

            Console.WriteLine("Elements in the list:");
            foreach (int i in counts)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Max Number of Trailing Vowels: {0}", counts.Max());
        }
    }
}
