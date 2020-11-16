using System;
using System.Collections.Generic;

namespace DecimalToBinary
{
    class program
    {
        static void Main(string[] args)
        {
            int number;
            Console.Write("Please enter your number: ");
            while (!int.TryParse(Console.ReadLine(), out number))
                Console.Write("Wrong input! Please enter a number: ");
            ConvertDecimalToBinary(number);
            BitwiseDecimalToBinary(number);
            DecimalToBinaryViaFunction(number);
        }
        static void ConvertDecimalToBinary(int _number)
        {
            Console.WriteLine("~~DECIMAL TO BINARY USING FORMULA~~");
            double binaryNum = 0;
            int remainder;
            int numOfZeros=0;
            Console.Write($"{_number} = ");
            while (_number != 0)
            {
                remainder = _number % 2;
                if (remainder == 0)
                    ;
                else
                    binaryNum += Math.Pow(10, numOfZeros) * remainder;
                numOfZeros++;
                _number /= 2;
            }
            Console.Write(binaryNum);
        }

        static void BitwiseDecimalToBinary(int _number)
        {
            Console.WriteLine("\n~~USING BITWISE OPERATORS~~");
            List<int> DigitList = new List<int>();
            Console.Write($"{_number} = ");
            while (_number > 0)
            {
                if ((_number & 1) == 1)
                    DigitList.Add(1);
                else
                    DigitList.Add(0);
                _number =_number >> 1;
            }
            for(int i = DigitList.Count - 1; i >= 0; i--)
                Console.Write(DigitList[i]);
        }
        static void DecimalToBinaryViaFunction(int _number)
        {
            Console.WriteLine("\n~~USING FUNCTION~~");
            string binary = Convert.ToString(_number, 2);
            Console.WriteLine($"{_number} = {binary}");
        }
    }
}