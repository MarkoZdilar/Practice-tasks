using System;

namespace Greatest_common_divisor
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.WriteLine("~~~FIND GREATEST COMMON DIVISOR PROGRAM~~~");
            Console.Write("Enter first number: ");
            while(!int.TryParse(Console.ReadLine(), out num1))
            {
                Console.Write("Wrong input, enter first number again: ");
            }
            Console.Write("Enter second number: ");
            while (!int.TryParse(Console.ReadLine(), out num2))
            {
                Console.Write("Wrong input, enter second number again: ");
            }

            Console.WriteLine($"Greatest divisor of {num1} and {num2} is {FindGreatestDivisor(num1, num2)}."); 
        }
        static int FindGreatestDivisor(int _number1, int _number2)
        {
            int greatestDivisor = 1;
            int smallestNumber;
            if (_number1 < _number2)
                smallestNumber = _number1;
            else
                smallestNumber = _number2;

            for(int i = 1; i <= smallestNumber; i++)
            {
                if (_number1 % i == 0 && _number2 % i == 0)
                    greatestDivisor = i;
            }
            return greatestDivisor;
        }
    }
}