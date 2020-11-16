using System;
using System.Runtime.InteropServices;

namespace Factorial_in_two_ways
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number to calculate it's factorial: ");
            int number = 0;
            while(int.TryParse(Console.ReadLine(), out number) == false || number < 0)
            {
                Console.Write("Wrong input! Enter a positive number: ");
            }
            Console.WriteLine($"Factorial of {number} is {CalculateFactorial(number)}");
            Console.WriteLine($"\n~~~RECURSION~~~\nFactorial of {number} is {FactorialRecursion(number)}");

        }
        static double CalculateFactorial(int _number)
        {
            double result = 1;
            for (int i = _number; i > 0; i--)
            {
                result *= i;
            }
            return result;
        }

        static double FactorialRecursion(int _number)
        {
            //Exit condition
            if (_number == 1)
                return 1;
            return _number * FactorialRecursion(_number - 1);
        }
    }
}