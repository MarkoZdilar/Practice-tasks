using System;
using System.Collections.Generic;

namespace Sum_of_digits
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insert number: ");
            int number;
            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.Write("Wrong input! Insert number:");
            }
            SumSomeDigits(number);
            SumSomeDigits2(number);
            
        }
        static void SumSomeDigits(int _number)
        {
            int sum = 0;
            while(_number != 0 )
            {
                Console.Write(_number % 10);
                sum += _number % 10;
                _number /= 10;
                if (_number != 0)
                    Console.Write("+");

            }
            Console.Write($" = {sum}\n");
        }
        static void SumSomeDigits2(int _number)
        {
            int sum = 0;
            List<int> digits = new List<int>();
            while(_number != 0)
            {
                sum += _number % 10;
                digits.Add(_number % 10);
                _number /= 10;
            }
            for(int i = digits.Count -1; i >= 0; i--)
            {
                Console.Write(digits[i]);
                if (i != 0)
                    Console.Write("+");
            }
            Console.Write($" = {sum}");
        }
    }
}